﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.BLL;

namespace TravletAgence.CSUI
{
    public partial class FrmVisaSubmit : Form
    {
        private readonly TravletAgence.BLL.VisaInfo bll = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private int _recordCount = 0;
        private string _preTxt = String.Empty;

        class PersonInfo
        {
            public string passportNo { get; set; }
            public string name { get; set; }
        }



        public FrmVisaSubmit()
        {
            InitializeComponent();
        }



        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string str = txtInput.Text.TrimEnd();

            if (_preTxt == str)
            {
                return;
            }
            _preTxt = str;
            string[] lines = str.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            //printArray(lines);
            PersonInfo personInfo = new PersonInfo();
            personInfo.passportNo = lines[lines.Length - 1].Split('|')[0];
            personInfo.name = lines[lines.Length - 1].Split('|')[1];

            int i = bll.GetRecordCount(string.Empty);

            TravletAgence.Model.VisaInfo model = bll.GetModelByPassportNo(personInfo.passportNo);

            //TODO:添加更新数据库签证状态逻辑
            model.outState = "进签";
            if (!bll.Update(model))
            {
                MessageBox.Show("更新签证状态失败!");
                return;

            }

            loadDataToDataGridView(_curPage);

            Console.WriteLine(model.EntryTime.ToString());
        }

        private void FrmVisaSubmit_Load(object sender, EventArgs e)
        {
            _recordCount = bll.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            cbPageSize.Items.Add(_pageSize.ToString());
            cbPageSize.SelectedIndex = 0;
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
            string name = dataGridView1.SelectedRows[0].Cells["_Name"].Value.ToString();

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
            FrmQRCode frm = new FrmQRCode("State:进签");
            frm.ShowDialog();
        }

        private void btnShowAbnormalOutQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode("State:出签");
            frm.ShowDialog();
        }

        private void btnShowNormalOutQR_Click(object sender, EventArgs e)
        {
            FrmQRCode frm = new FrmQRCode("State:未正常出签");
            frm.ShowDialog();
        }


    }
}
