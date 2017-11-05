using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.CSUI.FrmSub;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmVisaManage : Form
    {
        private readonly TravletAgence.BLL.Visa _bllVisa = new TravletAgence.BLL.Visa();
        private readonly TravletAgence.BLL.VisaInfo _bllVisaInfo = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize = 30;
        private int _recordCount = 0;
        private bool _init = false;


        private readonly Thread _thLoadDataToDgvAndUpdateState;

        public FrmVisaManage()
        {
            InitializeComponent();
            _thLoadDataToDgvAndUpdateState = new Thread(LoadAndUpdate);
            _thLoadDataToDgvAndUpdateState.IsBackground = true;
        }

        private void FrmVisaManage_Load(object sender, EventArgs e)
        {
            _recordCount = _bllVisa.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / _pageSize);
            cbPageSize.Items.Add("30");
            cbPageSize.Items.Add("50");
            cbPageSize.Items.Add("100");
            cbPageSize.SelectedIndex = 0;

            cbDisplayType.Items.Add("全部");
            cbDisplayType.Items.Add("未记录");
            cbDisplayType.Items.Add("个签");
            cbDisplayType.Items.Add("团签");
            cbDisplayType.SelectedIndex = 0;

            dataGridView1.AutoGenerateColumns = false; //不显示指定之外的列
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应
            //dataGridView1.Columns["CountryImage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //加载数据
            //loadDataToDataGridView(_curPage);
            //UpdateState();
            _thLoadDataToDgvAndUpdateState.Start();

        }



        #region dgv用到的相关方法

        //用于异步加载
        public void LoadAndUpdate()
        {
            this.Invoke(new Action(() =>
            {
                //dataGridView1.DataSource = null;
                LoadDataToDataGridView(_curPage);
                UpdateState();
            }));
            _init = true;
        }

        public void LoadDataToDataGridView(int page) //刷新后保持选中
        {
            int curSelectedRow = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                curSelectedRow = dataGridView1.SelectedRows[0].Index;
            string where = string.Empty;
            if (cbDisplayType.Text == "全部")
            {

            }
            else if (cbDisplayType.Text == "未记录")
            {
                where = " Types is null or Types='' ";
            }
            else if (cbDisplayType.Text == "个签")
            {
                where = " Types = '个签' ";

            }
            else if (cbDisplayType.Text == "团签")
            {
                where = " Types = '团签' ";
            }
            dataGridView1.DataSource = _bllVisa.GetListByPage(page, _pageSize, where);
            if (curSelectedRow != -1 && dataGridView1.Rows.Count > curSelectedRow)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];

        }

        public void UpdateState()
        {
            _recordCount = _bllVisa.GetRecordCount(string.Empty);
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
        #endregion


        #region dgv的bar栏
        private void btnPageNext_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(++_curPage);
            UpdateState();
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(--_curPage);
            UpdateState();
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void cbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (!_init) //因为窗口初始化的时候也会调用，所以禁止多次调用
                return;

            _pageSize = int.Parse(cbPageSize.Text);
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void cbDisplayType_TextChanged(object sender, EventArgs e)
        {
            if (!_init) //因为窗口初始化的时候也会调用，所以禁止多次调用
                return;
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        #endregion


        #region dgv消息响应
        /// <summary>
        /// dgv设置行号以及国家图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                if (dataGridView1.Rows[i].Cells["Country"].Value != null)
                {
                    string countryName = dataGridView1.Rows[i].Cells["Country"].Value.ToString();
                    if (countryName == "日本")
                        dataGridView1.Rows[i].Cells["CountryImage"].Value = Resources.Japan;
                    else if (countryName == "韩国")
                        dataGridView1.Rows[i].Cells["CountryImage"].Value = Resources.Korea;
                    else if (countryName == "泰国")
                        dataGridView1.Rows[i].Cells["CountryImage"].Value = Resources.Thailand;

                }
            }
        }

        /// <summary>
        /// dgv右键响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        if (e.ColumnIndex != -1) //选中表头了
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        else
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                    }
                    //弹出操作菜单
                    cmsDgv.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        #endregion

   

        #region dgv右键响应
        /// <summary>
        /// 查看选中团号，可以移出团号里的人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemShowGroupNo_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBoxEx.Show(Resources.SelectShowMoreThanOne);
                return;
            }

            Model.Visa model = _bllVisa.GetModel((Guid) dataGridView1.SelectedRows[0].Cells["Visa_id"].Value);
            if (model == null)
            {
                MessageBoxEx.Show(Resources.FindModelFailedPleaseCheckInfoCorrect);
                return;
            }

            if (model.Types == Common.Enums.Types.Individual)
            {
                FrmSetGroup frm = new FrmSetGroup(model, LoadDataToDataGridView, _curPage);
                frm.ShowDialog();
            }
            else if (model.Types == Common.Enums.Types.Team)
            {
                FrmSetTeamVisaGroup frm = new FrmSetTeamVisaGroup(model, LoadDataToDataGridView, _curPage);
                frm.ShowDialog();
            }
            
        }

        private void cmsItemRefreshDatabase_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(_curPage);
        }

        /// <summary>
        /// 右键删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (MessageBoxEx.Show("确认删除" + count + "条记录?", Resources.Confirm, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            int n = 0;
            for (int i = 0; i != count; ++i)
            {
                Model.Visa model =
                    _bllVisa.GetModel(Guid.Parse(dataGridView1.SelectedRows[i].Cells["Visa_id"].Value.ToString()));
                if(!_bllVisa.DeleteVisaAndModifyVisaInfos(model))
                {
                    MessageBoxEx.Show("删除失败!");
                }
                ++n;
            }
            MessageBoxEx.Show(n + "条记录删除成功," + (count - n) + "条记录删除失败.");
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        #endregion
















    }
}
