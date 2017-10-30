using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravletAgence.Model;

namespace TravletAgence.CSUI.FrmSub
{
    public partial class FrmGroupOrIndividual : Form
    {
        List<Model.VisaInfo> _list; //传过来的list，再传给设置团号的页面
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托，再传给设置团号的页面
        private readonly int _curPage; //主界面更新数据库需要一个当前页，再传给设置团号的页面

        public FrmGroupOrIndividual(List<Model.VisaInfo> list,Action<int> del,int page)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            _list = list;
            _updateDel = del;
            _curPage = page;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "个签")
            {
                
                FrmSetGroup frmSetGroup = new FrmSetGroup(_list, _updateDel, _curPage);
                frmSetGroup.ShowDialog();
            }
            else if (cbType.Text == "团签")
            {
                
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGroupOrIndividual_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            
            cbType.Items.Add("个签");
            cbType.Items.Add("团签");
            cbType.SelectedIndex = 0;
        }
    }
}
