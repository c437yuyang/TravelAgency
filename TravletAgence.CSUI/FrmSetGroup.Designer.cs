namespace TravletAgence.CSUI
{
    partial class FrmSetGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new DevComponents.DotNetBar.PanelEx();
            this.lvIn = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvOut = new DevComponents.DotNetBar.Controls.ListViewEx();
            this._Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssuePlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAllOut = new DevComponents.DotNetBar.ButtonX();
            this.btnOut = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnAllIn = new DevComponents.DotNetBar.ButtonX();
            this.btnCreateReport = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.txtSalesPerson = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtGroupNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Controls.Add(this.lvIn);
            this.panelMain.Controls.Add(this.lvOut);
            this.panelMain.Controls.Add(this.btnAllOut);
            this.panelMain.Controls.Add(this.btnOut);
            this.panelMain.Controls.Add(this.btnIn);
            this.panelMain.Controls.Add(this.btnAllIn);
            this.panelMain.Controls.Add(this.btnCreateReport);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnConfirm);
            this.panelMain.Controls.Add(this.txtGroupNo);
            this.panelMain.Controls.Add(this.labelX2);
            this.panelMain.Controls.Add(this.txtSalesPerson);
            this.panelMain.Controls.Add(this.labelX1);
            this.panelMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(874, 433);
            this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMain.Style.GradientAngle = 90;
            this.panelMain.TabIndex = 0;
            // 
            // lvIn
            // 
            // 
            // 
            // 
            this.lvIn.Border.Class = "ListViewBorder";
            this.lvIn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvIn.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvIn.FullRowSelect = true;
            this.lvIn.Location = new System.Drawing.Point(451, 70);
            this.lvIn.Name = "lvIn";
            this.lvIn.Size = new System.Drawing.Size(313, 238);
            this.lvIn.TabIndex = 30;
            this.lvIn.UseCompatibleStateImageBehavior = false;
            this.lvIn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "录入时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "签发地";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 86;
            // 
            // lvOut
            // 
            // 
            // 
            // 
            this.lvOut.Border.Class = "ListViewBorder";
            this.lvOut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Name,
            this.EntryTime,
            this.IssuePlace});
            this.lvOut.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvOut.FullRowSelect = true;
            this.lvOut.Location = new System.Drawing.Point(12, 70);
            this.lvOut.Name = "lvOut";
            this.lvOut.Size = new System.Drawing.Size(313, 238);
            this.lvOut.TabIndex = 29;
            this.lvOut.UseCompatibleStateImageBehavior = false;
            this.lvOut.View = System.Windows.Forms.View.Details;
            // 
            // _Name
            // 
            this._Name.Text = "姓名";
            this._Name.Width = 50;
            // 
            // EntryTime
            // 
            this.EntryTime.Text = "录入时间";
            this.EntryTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EntryTime.Width = 86;
            // 
            // IssuePlace
            // 
            this.IssuePlace.Text = "签发地";
            this.IssuePlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IssuePlace.Width = 86;
            // 
            // btnAllOut
            // 
            this.btnAllOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAllOut.Location = new System.Drawing.Point(342, 249);
            this.btnAllOut.Name = "btnAllOut";
            this.btnAllOut.Size = new System.Drawing.Size(75, 23);
            this.btnAllOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllOut.TabIndex = 28;
            this.btnAllOut.Text = "<<";
            this.btnAllOut.Click += new System.EventHandler(this.btnAllOut_Click);
            // 
            // btnOut
            // 
            this.btnOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOut.Location = new System.Drawing.Point(342, 197);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOut.TabIndex = 28;
            this.btnOut.Text = "<";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Location = new System.Drawing.Point(342, 145);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 28;
            this.btnIn.Text = ">";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnAllIn
            // 
            this.btnAllIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAllIn.Location = new System.Drawing.Point(342, 93);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(75, 23);
            this.btnAllIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllIn.TabIndex = 28;
            this.btnAllIn.Text = ">>";
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateReport.Location = new System.Drawing.Point(446, 397);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(75, 23);
            this.btnCreateReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateReport.TabIndex = 24;
            this.btnCreateReport.Text = "生成报表";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(365, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Location = new System.Drawing.Point(284, 397);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "确认修改";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSalesPerson
            // 
            // 
            // 
            // 
            this.txtSalesPerson.Border.Class = "TextBoxBorder";
            this.txtSalesPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSalesPerson.Location = new System.Drawing.Point(93, 399);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.PreventEnterBeep = true;
            this.txtSalesPerson.Size = new System.Drawing.Size(100, 21);
            this.txtSalesPerson.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 399);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "办理人:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 24);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(480, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "团号:";
            // 
            // txtGroupNo
            // 
            // 
            // 
            // 
            this.txtGroupNo.Border.Class = "TextBoxBorder";
            this.txtGroupNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGroupNo.Location = new System.Drawing.Point(93, 24);
            this.txtGroupNo.Name = "txtGroupNo";
            this.txtGroupNo.PreventEnterBeep = true;
            this.txtGroupNo.Size = new System.Drawing.Size(671, 21);
            this.txtGroupNo.TabIndex = 1;
            // 
            // FrmSetGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 433);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmSetGroup";
            this.Text = "设置团号";
            this.Load += new System.EventHandler(this.FrmSetGroup_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelMain;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSalesPerson;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCreateReport;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private DevComponents.DotNetBar.ButtonX btnAllOut;
        private DevComponents.DotNetBar.ButtonX btnOut;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnAllIn;
        private DevComponents.DotNetBar.Controls.ListViewEx lvIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevComponents.DotNetBar.Controls.ListViewEx lvOut;
        private System.Windows.Forms.ColumnHeader _Name;
        private System.Windows.Forms.ColumnHeader EntryTime;
        private System.Windows.Forms.ColumnHeader IssuePlace;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGroupNo;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}