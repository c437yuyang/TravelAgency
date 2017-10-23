using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.CSUI.Properties;

namespace TravletAgence.CSUI.FrmMain
{
    public partial class FrmVisaManage : Form
    {
        private readonly TravletAgence.BLL.Visa _bllVisa = new TravletAgence.BLL.Visa();
        private readonly TravletAgence.BLL.VisaInfo _bllVisaInfo = new TravletAgence.BLL.VisaInfo();
        private int _curPage = 1;
        private int _pageCount = 0;
        private readonly int _pageSize = 30;
        private int _recordCount = 0;
        public FrmVisaManage()
        {
            InitializeComponent();
        }

        private void FrmVisaManage_Load(object sender, EventArgs e)
        {
            _recordCount = _bllVisa.GetRecordCount(string.Empty);
            _pageCount = (int)Math.Ceiling((double)_recordCount / _pageSize);
            cbPageSize.Items.Add(_pageSize.ToString());
            cbPageSize.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false; //不显示指定之外的列
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应
            //dataGridView1.Columns["CountryImage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //加载数据
            loadDataToDataGridView(_curPage);
            UpdateState();
        }



        #region dgv用到的相关方法
        public void loadDataToDataGridView(int page) //刷新后保持选中
        {
            int curSelectedRow = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                curSelectedRow = dataGridView1.SelectedRows[0].Index;
            dataGridView1.DataSource = _bllVisa.GetListByPage(page, _pageSize);
            if (curSelectedRow != -1)
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

        #endregion




    }
}
