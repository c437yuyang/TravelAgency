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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.Items.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.Items[i];
                lvOut.Items.Remove(lvOut.Items[i]);
                lvIn.Items.Add(lvItem);
            }
            updateGroupNo();
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
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int i = lvOut.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvOut.SelectedItems[i];
                lvOut.Items.Remove(lvOut.SelectedItems[i]);
                lvIn.Items.Insert(0,lvItem);
            }
            updateGroupNo();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            for (int i = lvIn.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem lvItem = lvIn.SelectedItems[i];
                lvIn.Items.Remove(lvIn.SelectedItems[i]);
                lvOut.Items.Insert(0,lvItem);
            }
            updateGroupNo();
        }

        private void updateGroupNo()
        {
            _visaName = "QZC" + DateTime.Now.ToString("yyMMdd") + "|";
            for (int i = 0; i < lvIn.Items.Count; ++i)
            {
                _visaName += ((Model.VisaInfo)lvIn.Items[i].Tag).Name;
                if (i == lvIn.Items.Count - 1)
                    break;
                _visaName += "、";
            }
            this.txtGroupNo.Text = _visaName;
        }



    }



}
