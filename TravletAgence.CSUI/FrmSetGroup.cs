using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.Common;
using TravletAgence.Model;

namespace TravletAgence.CSUI
{
    public partial class FrmSetGroup : Form
    {

        private List<Model.VisaInfo> _list = new List<VisaInfo>();

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
            if (_list.Count == 0)
                return;
            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem liv = new ListViewItem(_list[i].Name);
                ListViewItem.ListViewSubItem livSubItem = new ListViewItem.ListViewSubItem(liv,DateTimeFormator.DateTimeToString(_list[i].EntryTime));
                ListViewItem.ListViewSubItem livSubItem1 = new ListViewItem.ListViewSubItem(liv,_list[i].IssuePlace);

                liv.SubItems.Add(livSubItem);
                liv.SubItems.Add(livSubItem1);
                liv.Tag = _list[i];
                lvOut.Items.Add(liv);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }



}
