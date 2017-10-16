using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using TravletAgence.BLL;
using TravletAgence.Common;

namespace TravletAgence.CSUI
{
    public partial class FrmVisaSubmit : Form
    {
        private readonly TravletAgence.BLL.VisaInfo bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private int _recordCount = 0;
        private string _preTxt = string.Empty;
        private string _outState = string.Empty;

        class PersonInfo
        {
            public string passportNo { get; set; }
            public string englishName { get; set; }
        }

        public FrmVisaSubmit()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (_preTxt + "\r\n" != txtInput.Text)
            {
                _preTxt = txtInput.Text;
                return;
            }
            _preTxt = txtInput.Text;
            //Console.WriteLine(txtInput.Text);
            string str = txtInput.Text.TrimEnd(); //去掉最后的\r\n

            string[] lines = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            ////printArray(lines);
            PersonInfo personInfo = new PersonInfo();
            personInfo.passportNo = lines[lines.Length - 1].Split('|')[0];
            personInfo.englishName = lines[lines.Length - 1].Split('|')[1];

            //int i = bll.GetRecordCount(string.Empty);

            TravletAgence.Model.VisaInfo model = bll.GetModelByPassportNo(personInfo.passportNo);

            ////TODO:添加更新数据库签证状态逻辑
            model.outState = _outState;
            if (!bll.Update(model))
            {
                MessageBox.Show("更新签证状态失败!");
                return;
            }

            loadDataToDataGridView(_curPage);

            //Console.WriteLine(model.EntryTime.ToString());
        }

        private void FrmVisaSubmit_Load(object sender, EventArgs e)
        {
            _recordCount = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            cbPageSize.Items.Add(_pageSize.ToString());
            cbPageSize.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            rbtnIn.Select();
            //加载数据
            loadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void loadDataToDataGridView(int page)
        {
            dataGridView1.DataSource = bll.GetListByPage(page, _pageSize);
        }

        private void UpdateState()
        {
            _recordCount = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            if (_curPage == 1)
                btnPagePre.Enabled = false;
            else
                btnPagePre.Enabled = true;
            if (_curPage == _pageCount)
                btnPageNext.Enabled = false;
            else
                btnPageNext.Enabled = true;
            //lbRecordCount.Text = "当前为第:" + Convert.ToInt32(_curPage)
            //                + "页,共" + Convert.ToInt32(_pageCount) + "页,每页共" + _pageSize + "条.";
            lbRecordCount.Text = "共有记录:" + _recordCount + "条";
            lbCurPage.Text = "当前为第" + _curPage + "页";
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView(++_curPage);
            UpdateState();
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            loadDataToDataGridView(--_curPage);
            UpdateState();
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            loadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            loadDataToDataGridView(_curPage);

            UpdateState();
        }



        private void showQRCode_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("请选择一行数据进行查看");
                return;
            }

            string passportNo = dataGridView1.SelectedRows[0].Cells["PassportNo"].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells["EnglishName"].Value.ToString();

            FrmQRCode dlg = new FrmQRCode(passportNo + "|" + name);
            dlg.ShowDialog();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    //如果没选中当前活动行则选中这一行
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    //cmsDgvRb.Show(dataGridView1, e.Location);
                    cmsDgvRb.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void btnShowInQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode("State:02进签");
            frm.ShowDialog();
        }

        private void btnShowAbnormalOutQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode("State:03出签");
            frm.ShowDialog();
        }

        private void btnShowNormalOutQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode("State:04未正常出签");
            frm.ShowDialog();
        }

        private void rbtnIn_CheckedChanged(object sender, EventArgs e)
        {
            _outState = OutState.TYPE02In();
        }

        private void rBtnOut_CheckedChanged(object sender, EventArgs e)
        {
            _outState = OutState.TYPE03NormalOut();
        }

        private void rbtnAbOut_CheckedChanged(object sender, EventArgs e)
        {
            _outState = OutState.TYPE04AbnormalOut();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DataGridViewX dgv = (DataGridViewX)sender;
                Color c = Color.Empty;
                switch (e.Value.ToString())
                {
                    case "01未记录":
                        c = Color.AliceBlue;
                        break;
                    case "02进签":
                        c = Color.Yellow;
                        break;
                    case "03出签":
                        c = Color.Green;
                        break;
                    case "04未正常出签":
                        c = Color.Red;
                        break;
                    default:
                        c = Color.Black;
                        break;
                }
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = c;
            }
        }


    }
}
