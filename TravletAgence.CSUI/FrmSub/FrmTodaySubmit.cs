using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.Common.Excel.Japan;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmSub
{
    public partial class FrmTodaySubmit : Form
    {
        private readonly List<List<VisaInfo>> _listVisaInfo;
        private readonly List<Visa> _listVisa;
        private readonly List<VisaInfo> _listDgv = new List<VisaInfo>();
        public FrmTodaySubmit(List<Visa> listVisa,List<List<VisaInfo>> listVisaInfo)
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ExcelGenerator.GetEverydayExcel(_listVisa, _listVisaInfo);
        }
    }
}
