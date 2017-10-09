namespace TravletAgence.CSUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.lb_page = new DevComponents.DotNetBar.LabelX();
            this.btn_pageDown = new DevComponents.DotNetBar.ButtonX();
            this.btn_pageUp = new DevComponents.DotNetBar.ButtonX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnAddToDatabase = new DevComponents.DotNetBar.ButtonX();
            this.btnReadData = new DevComponents.DotNetBar.ButtonX();
            this.btnAutoRead = new DevComponents.DotNetBar.ButtonX();
            this.btnLoadKernel = new DevComponents.DotNetBar.ButtonX();
            this.btnFreeKernel = new DevComponents.DotNetBar.ButtonX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPicPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassNo = new System.Windows.Forms.TextBox();
            this.txtIssuePlace = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.txtLicenseTime = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Name,
            this.EnglishName,
            this.Sex,
            this.BirthDay,
            this.PassportNo,
            this.LicenseTime,
            this.ExpiryDate,
            this.Birthplace,
            this.IssuePlace});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 532);
            this.dataGridView1.TabIndex = 10;
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "Name";
            this._Name.HeaderText = "本国姓名";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            // 
            // EnglishName
            // 
            this.EnglishName.DataPropertyName = "EnglishName";
            this.EnglishName.HeaderText = "英语姓名";
            this.EnglishName.Name = "EnglishName";
            this.EnglishName.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "Birthday";
            this.BirthDay.HeaderText = "生日";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // PassportNo
            // 
            this.PassportNo.DataPropertyName = "PassportNo";
            this.PassportNo.HeaderText = "护照号";
            this.PassportNo.Name = "PassportNo";
            this.PassportNo.ReadOnly = true;
            // 
            // LicenseTime
            // 
            this.LicenseTime.DataPropertyName = "LicenseTime";
            this.LicenseTime.HeaderText = "发证日期";
            this.LicenseTime.Name = "LicenseTime";
            this.LicenseTime.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "有效期";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // Birthplace
            // 
            this.Birthplace.DataPropertyName = "Birthplace";
            this.Birthplace.HeaderText = "出生地";
            this.Birthplace.Name = "Birthplace";
            this.Birthplace.ReadOnly = true;
            // 
            // IssuePlace
            // 
            this.IssuePlace.DataPropertyName = "IssuePlace";
            this.IssuePlace.HeaderText = "签发地";
            this.IssuePlace.Name = "IssuePlace";
            this.IssuePlace.ReadOnly = true;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dataGridView1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1044, 532);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 11;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.lb_page);
            this.panelEx3.Controls.Add(this.btn_pageDown);
            this.panelEx3.Controls.Add(this.btn_pageUp);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1271, 41);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 19;
            // 
            // lb_page
            // 
            // 
            // 
            // 
            this.lb_page.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_page.Location = new System.Drawing.Point(149, 12);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(236, 20);
            this.lb_page.TabIndex = 12;
            this.lb_page.Text = "labelX2";
            // 
            // btn_pageDown
            // 
            this.btn_pageDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_pageDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_pageDown.Location = new System.Drawing.Point(399, 9);
            this.btn_pageDown.Name = "btn_pageDown";
            this.btn_pageDown.Size = new System.Drawing.Size(75, 23);
            this.btn_pageDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_pageDown.TabIndex = 11;
            this.btn_pageDown.Text = "下一页";
            this.btn_pageDown.Click += new System.EventHandler(this.btn_pageDown_Click);
            // 
            // btn_pageUp
            // 
            this.btn_pageUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_pageUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_pageUp.Location = new System.Drawing.Point(68, 9);
            this.btn_pageUp.Name = "btn_pageUp";
            this.btn_pageUp.Size = new System.Drawing.Size(75, 23);
            this.btn_pageUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_pageUp.TabIndex = 10;
            this.btn_pageUp.Text = "上一页";
            this.btn_pageUp.Click += new System.EventHandler(this.btn_pageUp_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelEx3);
            this.splitContainer1.Size = new System.Drawing.Size(1271, 577);
            this.splitContainer1.SplitterDistance = 532;
            this.splitContainer1.TabIndex = 27;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelEx1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelEx2);
            this.splitContainer2.Size = new System.Drawing.Size(1271, 532);
            this.splitContainer2.SplitterDistance = 1044;
            this.splitContainer2.TabIndex = 15;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnAddToDatabase);
            this.panelEx2.Controls.Add(this.btnReadData);
            this.panelEx2.Controls.Add(this.btnAutoRead);
            this.panelEx2.Controls.Add(this.btnLoadKernel);
            this.panelEx2.Controls.Add(this.btnFreeKernel);
            this.panelEx2.Controls.Add(this.labelX10);
            this.panelEx2.Controls.Add(this.labelX9);
            this.panelEx2.Controls.Add(this.labelX8);
            this.panelEx2.Controls.Add(this.labelX7);
            this.panelEx2.Controls.Add(this.labelX6);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.txtPicPath);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.txtName);
            this.panelEx2.Controls.Add(this.txtPassNo);
            this.panelEx2.Controls.Add(this.txtIssuePlace);
            this.panelEx2.Controls.Add(this.txtBirthPlace);
            this.panelEx2.Controls.Add(this.txtExpireDate);
            this.panelEx2.Controls.Add(this.txtLicenseTime);
            this.panelEx2.Controls.Add(this.txtBirthday);
            this.panelEx2.Controls.Add(this.txtSex);
            this.panelEx2.Controls.Add(this.txtEnglishName);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(223, 532);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 19;
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddToDatabase.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddToDatabase.Location = new System.Drawing.Point(12, 481);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(88, 23);
            this.btnAddToDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddToDatabase.TabIndex = 18;
            this.btnAddToDatabase.Text = "添加到数据库";
            this.btnAddToDatabase.Click += new System.EventHandler(this.buttonAddToDatabase_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReadData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReadData.Location = new System.Drawing.Point(12, 441);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(88, 23);
            this.btnReadData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReadData.TabIndex = 17;
            this.btnReadData.Text = "读取签证信息";
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnAutoRead
            // 
            this.btnAutoRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAutoRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAutoRead.Location = new System.Drawing.Point(118, 441);
            this.btnAutoRead.Name = "btnAutoRead";
            this.btnAutoRead.Size = new System.Drawing.Size(81, 23);
            this.btnAutoRead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAutoRead.TabIndex = 16;
            this.btnAutoRead.Text = "开始自动读取";
            this.btnAutoRead.Click += new System.EventHandler(this.btnAutoRead_Click);
            // 
            // btnLoadKernel
            // 
            this.btnLoadKernel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoadKernel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoadKernel.Location = new System.Drawing.Point(12, 399);
            this.btnLoadKernel.Name = "btnLoadKernel";
            this.btnLoadKernel.Size = new System.Drawing.Size(88, 23);
            this.btnLoadKernel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoadKernel.TabIndex = 15;
            this.btnLoadKernel.Text = "加载识别内核";
            this.btnLoadKernel.Click += new System.EventHandler(this.btnLoadKernel_Click);
            // 
            // btnFreeKernel
            // 
            this.btnFreeKernel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFreeKernel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFreeKernel.Location = new System.Drawing.Point(118, 399);
            this.btnFreeKernel.Name = "btnFreeKernel";
            this.btnFreeKernel.Size = new System.Drawing.Size(81, 23);
            this.btnFreeKernel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFreeKernel.TabIndex = 14;
            this.btnFreeKernel.Text = "释放识别内核";
            this.btnFreeKernel.Click += new System.EventHandler(this.btnFreeKernel_Click);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(12, 303);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 13;
            this.labelX10.Text = "签发地:";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(12, 274);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 13;
            this.labelX9.Text = "出生地:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(12, 244);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 13;
            this.labelX8.Text = "有效期:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(12, 212);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 13;
            this.labelX7.Text = "发证日期:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 181);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "护照号码:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 154);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "出生日期:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 122);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "性别:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 88);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "英文姓名:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "本国姓名:";
            // 
            // txtPicPath
            // 
            // 
            // 
            // 
            this.txtPicPath.Border.Class = "TextBoxBorder";
            this.txtPicPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPicPath.Location = new System.Drawing.Point(12, 363);
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.PreventEnterBeep = true;
            this.txtPicPath.Size = new System.Drawing.Size(173, 21);
            this.txtPicPath.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 334);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "图像保存路径:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 9;
            // 
            // txtPassNo
            // 
            this.txtPassNo.Location = new System.Drawing.Point(93, 181);
            this.txtPassNo.Name = "txtPassNo";
            this.txtPassNo.Size = new System.Drawing.Size(100, 21);
            this.txtPassNo.TabIndex = 10;
            // 
            // txtIssuePlace
            // 
            this.txtIssuePlace.Location = new System.Drawing.Point(93, 301);
            this.txtIssuePlace.Name = "txtIssuePlace";
            this.txtIssuePlace.Size = new System.Drawing.Size(100, 21);
            this.txtIssuePlace.TabIndex = 9;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(93, 274);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(100, 21);
            this.txtBirthPlace.TabIndex = 9;
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Location = new System.Drawing.Point(93, 244);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(100, 21);
            this.txtExpireDate.TabIndex = 9;
            // 
            // txtLicenseTime
            // 
            this.txtLicenseTime.Location = new System.Drawing.Point(93, 214);
            this.txtLicenseTime.Name = "txtLicenseTime";
            this.txtLicenseTime.Size = new System.Drawing.Size(100, 21);
            this.txtLicenseTime.TabIndex = 9;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(93, 154);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(100, 21);
            this.txtBirthday.TabIndex = 9;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(93, 125);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 21);
            this.txtSex.TabIndex = 9;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(93, 90);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(100, 21);
            this.txtEnglishName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 577);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "东瀛假日:签证自动扫描识别系统V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX lb_page;
        private DevComponents.DotNetBar.ButtonX btn_pageDown;
        private DevComponents.DotNetBar.ButtonX btn_pageUp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPicPath;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassNo;
        private System.Windows.Forms.TextBox txtIssuePlace;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.TextBox txtLicenseTime;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtEnglishName;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnLoadKernel;
        private DevComponents.DotNetBar.ButtonX btnFreeKernel;
        private DevComponents.DotNetBar.ButtonX btnReadData;
        private DevComponents.DotNetBar.ButtonX btnAutoRead;
        private DevComponents.DotNetBar.ButtonX btnAddToDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuePlace;
    }
}

