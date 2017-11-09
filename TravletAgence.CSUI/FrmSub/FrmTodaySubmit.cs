using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TravletAgence.Common.Excel.Japan;
using TravletAgence.Common.Word.Japan;
using TravletAgence.CSUI.Properties;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmSub
{
    public partial class FrmTodaySubmit : Form
    {
        private readonly List<List<VisaInfo>> _listVisaInfo;
        private readonly List<Visa> _listVisa;
        private readonly List<VisaInfo> _listDgv = new List<VisaInfo>();
        public FrmTodaySubmit(List<Visa> listVisa, List<List<VisaInfo>> listVisaInfo)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            _listVisa = listVisa;
            _listVisaInfo = listVisaInfo;
            foreach (List<VisaInfo> t in _listVisaInfo)
            {
                _listDgv.AddRange(t);
            }
        }

        private void FrmTodaySubmit_Load(object sender, EventArgs e)
        {
            rowMergeView1.AutoGenerateColumns = false;
            rowMergeView1.MultiSelect = true;
            rowMergeView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rowMergeView1.DataSource = _listDgv;
            rowMergeView1.MergeColumnNames.Add("Remark");
        }

        private void rowMergeView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < rowMergeView1.Rows.Count; i++)
            {
                DataGridViewRow row = rowMergeView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString();

                for (int j = 0; j < _listVisaInfo.Count; j++)
                {
                    if (_listVisaInfo[j].Contains(_listDgv[i]))
                    {
                        row.Cells["DepartureType"].Value = _listVisa[j].DepartureType;
                    }

                    if (_listVisaInfo[j].Contains(_listDgv[i]))
                    {
                        row.Cells["Remark"].Value = _listVisa[j].Remark;
                    }
                }
            }
        }

        private void buttonGetTodaySubmitExcel_Click(object sender, EventArgs e)
        {
            ExcelGenerator.GetEverydayExcel(_listVisa, _listVisaInfo);
        }



        /// <summary>
        /// 获取选中项的list
        /// </summary>
        /// <returns></returns>
        private List<Model.VisaInfo> GetDgvSelList()
        {
            int count = this.rowMergeView1.SelectedRows.Count;
            List<Model.VisaInfo> list = new List<VisaInfo>();
            for (int i = 0; i != count; ++i)
            {
                list.Add(_listDgv[rowMergeView1.SelectedRows[i].Index]);
            }
            return list;
        }
        #region dgv右键响应

        private void 个签意见书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<Visa> set = new HashSet<Visa>();
            Model.Visa visaModel = null;
            int idx = 0; //visaModel的下标
            for (int i = 0; i < rowMergeView1.SelectedRows.Count; i++)
            {
                for (int j = 0; j < _listVisa.Count; j++)
                {
                    if (_listVisaInfo[j].Contains(_listDgv[rowMergeView1.SelectedRows[i].Index]))
                    {
                        if (!set.Contains(_listVisa[j]))
                        {
                            set.Add(_listVisa[j]);
                            visaModel = _listVisa[j];
                            idx = j;
                        }

                    }
                }

            }
            if (set.Count > 1)
            {
                MessageBoxEx.Show("请选择同一个团号的签证进行导出!");
                return;
            }

            if (visaModel == null)
                return;
            ExcelGenerator.GetIndividualVisaExcel(_listVisaInfo[idx], visaModel.Remark, visaModel.GroupNo);
        }

        private void 金桥大名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var visainfoList = GetDgvSelList();
            List<string> list = new List<string>();
            for (int i = 0; i < visainfoList.Count; i++)
            {
                list.Add(visainfoList[i].Name);
            }

            DocGenerator docGenerator = new DocGenerator(DocGenerator.DocType.Type01JinQiaoList);
            docGenerator.Generate(list);
        }

        private void 人申请表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var visainfos = GetDgvSelList();
            XlsGenerator.GetPre8List(visainfos);
        }
        #endregion

        private void rowMergeView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {

                    //若行已是选中状态就不再进行设置
                    //如果没选中当前活动行则选中这一行
                    if (rowMergeView1.Rows[e.RowIndex].Selected == false)
                    {
                        rowMergeView1.ClearSelection();
                        rowMergeView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (rowMergeView1.SelectedRows.Count == 1)
                    {
                        if (e.ColumnIndex != -1) //选中表头了
                            rowMergeView1.CurrentCell = rowMergeView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        else
                            rowMergeView1.CurrentCell = rowMergeView1.Rows[e.RowIndex].Cells[0];
                    }
                    //弹出操作菜单

                    cmsDgv.Show(MousePosition.X, MousePosition.Y);

                }
            }
        }


    }
}
