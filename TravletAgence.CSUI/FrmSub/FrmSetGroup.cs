using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravletAgence.Common;
using TravletAgence.Common.Enums;
using TravletAgence.Common.Excel;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmSub
{
    public partial class FrmSetGroup : Form
    {

        private List<Model.VisaInfo> _list = new List<VisaInfo>();
        private List<Model.VisaInfo> _dgvList = new List<VisaInfo>();
        private BLL.VisaInfo bll = new BLL.VisaInfo();

        private string _visaName = "QZC" + DateTime.Now.ToString("yyMMdd") + "|";

        public FrmSetGroup()
        {
            InitializeComponent();
        }

        public FrmSetGroup(List<Model.VisaInfo> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void FrmSetGroup_Load(object sender, EventArgs e)
        {
            dgvGroupInfo.AutoGenerateColumns = false;
            dgvGroupInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //列宽自适应
            dgvGroupInfo.Columns["Birthday"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;//某一些列关闭自适应

            //初始化时间选择控件
            txtDepartureTime.Text = DateTime.Now.ToString();

            if (_list.Count == 0)
                return;
            //加载列表
            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem liv = new ListViewItem(_list[i].Name);
                ListViewItem.ListViewSubItem livSubItem = new ListViewItem.ListViewSubItem(liv, DateTimeFormator.DateTimeToString(_list[i].EntryTime));
                ListViewItem.ListViewSubItem livSubItem1 = new ListViewItem.ListViewSubItem(liv, _list[i].IssuePlace);
                liv.SubItems.Add(livSubItem);
                liv.SubItems.Add(livSubItem1);
                liv.Tag = _list[i];
                lvOut.Items.Add(liv);
            }

            //设置列表多选
            lvIn.MultiSelect = true;
            lvOut.MultiSelect = true;
        }





        #region 状态更新函数

        private void updateGroupNo()
        {
            _visaName = "QZC" + txtDepartureTime.Value.ToString("yyMMdd");
            for (int i = 0; i < lvIn.Items.Count; ++i)
            {
                _visaName += ((Model.VisaInfo)lvIn.Items[i].Tag).Name;
                if (i == lvIn.Items.Count - 1)
                    break;
                _visaName += "、";
            }
            this.txtGroupNo.Text = _visaName;
            this.lbCount.Text = "团队人数:" + lvIn.Items.Count + "人";
        }

        private void updateDgvData()
        {
            _dgvList.Clear();
            for (int i = 0; i < lvIn.Items.Count; ++i)
            {
                _dgvList.Add((Model.VisaInfo)lvIn.Items[i].Tag);
            }
            dgvGroupInfo.DataSource = null; //必须加，不然报错，不知道为什么
            dgvGroupInfo.DataSource = _dgvList;
            //dgvGroupInfo.Invalidate();
            //dgvGroupInfo.Update();
        }

        private void dgvToModelList(List<Model.VisaInfo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].HasTypeIn = HasTypeIn.Yes;
                list[i].Country = cbCountry.Text;
                //TODO:修改对应团号VisaId
                //list[i].Visa_id = 
            }
            int res = bll.UpdateByList(_dgvList);
            MessageBox.Show(res + "条记录成功更新," + (list.Count - res) + "条记录更新失败.");
        }

        #endregion

        #region dgv响应
        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
            {
                dgvGroupInfo.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// 备注批量修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >=0 && dgvGroupInfo.Columns[e.ColumnIndex].Name == "Remark")
            {
                string remark = dgvGroupInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                for (int i = 0; i < dgvGroupInfo.Rows.Count; i++)
                {
                    dgvGroupInfo.Rows[i].Cells[e.ColumnIndex].Value = remark;

                }
            }
        }

        #endregion


        #region 自己的按钮

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.Items[i];
                lvOut.Items.Remove(lvOut.Items[i]);
                lvIn.Items.Add(lvItem);
            }
            updateGroupNo();
            updateDgvData();
        }

        private void btnAllOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.Items[i];
                lvIn.Items.Remove(lvIn.Items[i]);
                lvOut.Items.Add(lvItem);
            }
            updateGroupNo();
            updateDgvData();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.SelectedItems[i];
                lvOut.Items.Remove(lvOut.SelectedItems[i]);
                lvIn.Items.Insert(0, lvItem);
            }
            updateGroupNo();
            updateDgvData();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.SelectedItems[i];
                lvIn.Items.Remove(lvIn.SelectedItems[i]);
                lvOut.Items.Insert(0, lvItem);
            }
            updateGroupNo();
            updateDgvData();
        }


        /// <summary>
        /// 生成报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if( dgvGroupInfo.Rows[0].Cells["Remark"].Value!=null)
                GroupExcel.GenGroupInfoExcel(_dgvList, dgvGroupInfo.Rows[0].Cells["Remark"].Value.ToString(), txtGroupNo.Text);
            else
                GroupExcel.GenGroupInfoExcel(_dgvList, string.Empty, txtGroupNo.Text);
        }

        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("是否提交修改?", "确认", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel)
                return;

            //1.更新model,设置资料已录入
            _dgvList = (List<Model.VisaInfo>)dgvGroupInfo.DataSource;
            //2.1更新VisaInfo数据库
            dgvToModelList(_dgvList);
            //2.2保存团号信息修改到数据库,Visa表（sales_person,country,GroupNo,PredictTime）

            //
        }

        #endregion
















    }



}
