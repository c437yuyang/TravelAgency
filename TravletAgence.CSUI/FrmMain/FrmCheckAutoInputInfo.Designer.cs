namespace TravletAgence.CSUI.FrmMain
{
    partial class FrmCheckAutoInputInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new DevComponents.DotNetBar.PanelEx();
            this.picPassportNo = new System.Windows.Forms.PictureBox();
            this.panelRight = new DevComponents.DotNetBar.PanelEx();
            this.txtCheckPerson = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisaInfo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveChanges = new DevComponents.DotNetBar.ButtonX();
            this.btnNoFault = new DevComponents.DotNetBar.ButtonX();
            this.btnPre = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtExpireDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtLicenseTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtBirthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassNo = new System.Windows.Forms.TextBox();
            this.txtIssuePlace = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassportNo)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpireDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Controls.Add(this.picPassportNo);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelEx2);
            this.panelMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1247, 556);
            this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMain.Style.GradientAngle = 90;
            this.panelMain.TabIndex = 0;
            // 
            // picPassportNo
            // 
            this.picPassportNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPassportNo.Location = new System.Drawing.Point(220, 0);
            this.picPassportNo.Name = "picPassportNo";
            this.picPassportNo.Size = new System.Drawing.Size(730, 556);
            this.picPassportNo.TabIndex = 40;
            this.picPassportNo.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelRight.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelRight.Controls.Add(this.txtCheckPerson);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Controls.Add(this.labelX12);
            this.panelRight.Controls.Add(this.btnSaveChanges);
            this.panelRight.Controls.Add(this.btnNoFault);
            this.panelRight.Controls.Add(this.btnPre);
            this.panelRight.Controls.Add(this.btnNext);
            this.panelRight.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(950, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(297, 556);
            this.panelRight.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelRight.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelRight.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelRight.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelRight.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelRight.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelRight.Style.GradientAngle = 90;
            this.panelRight.TabIndex = 33;
            // 
            // txtCheckPerson
            // 
            // 
            // 
            // 
            this.txtCheckPerson.Border.Class = "TextBoxBorder";
            this.txtCheckPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCheckPerson.Location = new System.Drawing.Point(110, 526);
            this.txtCheckPerson.Name = "txtCheckPerson";
            this.txtCheckPerson.PreventEnterBeep = true;
            this.txtCheckPerson.Size = new System.Drawing.Size(89, 21);
            this.txtCheckPerson.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassportNo,
            this._Name,
            this.HasChecked,
            this.VisaInfo_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(297, 489);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // PassportNo
            // 
            this.PassportNo.DataPropertyName = "PassportNo";
            this.PassportNo.HeaderText = "护照号";
            this.PassportNo.Name = "PassportNo";
            this.PassportNo.ReadOnly = true;
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "Name";
            this._Name.HeaderText = "姓名";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            // 
            // HasChecked
            // 
            this.HasChecked.DataPropertyName = "HasChecked";
            this.HasChecked.HeaderText = "已校验";
            this.HasChecked.Name = "HasChecked";
            this.HasChecked.ReadOnly = true;
            // 
            // VisaInfo_id
            // 
            this.VisaInfo_id.DataPropertyName = "VisaInfo_id";
            this.VisaInfo_id.HeaderText = "VisaInfo_id";
            this.VisaInfo_id.Name = "VisaInfo_id";
            this.VisaInfo_id.ReadOnly = true;
            this.VisaInfo_id.Visible = false;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(37, 526);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(56, 23);
            this.labelX12.TabIndex = 22;
            this.labelX12.Text = "操作员:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveChanges.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveChanges.Location = new System.Drawing.Point(211, 524);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(81, 23);
            this.btnSaveChanges.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "保存当前页";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnNoFault
            // 
            this.btnNoFault.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNoFault.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNoFault.Location = new System.Drawing.Point(13, 495);
            this.btnNoFault.Name = "btnNoFault";
            this.btnNoFault.Size = new System.Drawing.Size(88, 23);
            this.btnNoFault.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNoFault.TabIndex = 17;
            this.btnNoFault.Text = "确认无误";
            this.btnNoFault.Click += new System.EventHandler(this.btnNoFault_Click);
            // 
            // btnPre
            // 
            this.btnPre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPre.Location = new System.Drawing.Point(110, 495);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(89, 23);
            this.btnPre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPre.TabIndex = 14;
            this.btnPre.Text = "上一张";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(211, 495);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 23);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "下一张";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtExpireDate);
            this.panelEx2.Controls.Add(this.txtLicenseTime);
            this.panelEx2.Controls.Add(this.txtBirthday);
            this.panelEx2.Controls.Add(this.labelX11);
            this.panelEx2.Controls.Add(this.labelX10);
            this.panelEx2.Controls.Add(this.labelX9);
            this.panelEx2.Controls.Add(this.labelX8);
            this.panelEx2.Controls.Add(this.labelX7);
            this.panelEx2.Controls.Add(this.labelX6);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.txtName);
            this.panelEx2.Controls.Add(this.txtPassNo);
            this.panelEx2.Controls.Add(this.txtIssuePlace);
            this.panelEx2.Controls.Add(this.txtBirthPlace);
            this.panelEx2.Controls.Add(this.txtSex);
            this.panelEx2.Controls.Add(this.txtEnglishName);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(220, 556);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 23;
            // 
            // txtExpireDate
            // 
            // 
            // 
            // 
            this.txtExpireDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtExpireDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpireDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtExpireDate.ButtonDropDown.Visible = true;
            this.txtExpireDate.IsPopupCalendarOpen = false;
            this.txtExpireDate.Location = new System.Drawing.Point(93, 240);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtExpireDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpireDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtExpireDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtExpireDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpireDate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.txtExpireDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.txtExpireDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtExpireDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtExpireDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtExpireDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpireDate.MonthCalendar.TodayButtonVisible = true;
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(100, 21);
            this.txtExpireDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtExpireDate.TabIndex = 20;
            // 
            // txtLicenseTime
            // 
            // 
            // 
            // 
            this.txtLicenseTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLicenseTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtLicenseTime.ButtonDropDown.Visible = true;
            this.txtLicenseTime.IsPopupCalendarOpen = false;
            this.txtLicenseTime.Location = new System.Drawing.Point(93, 208);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtLicenseTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtLicenseTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtLicenseTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseTime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.txtLicenseTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.txtLicenseTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtLicenseTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtLicenseTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtLicenseTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseTime.MonthCalendar.TodayButtonVisible = true;
            this.txtLicenseTime.Name = "txtLicenseTime";
            this.txtLicenseTime.Size = new System.Drawing.Size(100, 21);
            this.txtLicenseTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtLicenseTime.TabIndex = 20;
            // 
            // txtBirthday
            // 
            // 
            // 
            // 
            this.txtBirthday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBirthday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtBirthday.ButtonDropDown.Visible = true;
            this.txtBirthday.IsPopupCalendarOpen = false;
            this.txtBirthday.Location = new System.Drawing.Point(93, 148);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtBirthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBirthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtBirthday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBirthday.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.txtBirthday.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.txtBirthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBirthday.MonthCalendar.TodayButtonVisible = true;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(100, 21);
            this.txtBirthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtBirthday.TabIndex = 20;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("华文新魏", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX11.Location = new System.Drawing.Point(12, 12);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(150, 23);
            this.labelX11.TabIndex = 19;
            this.labelX11.Text = "护照信息确认:";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(12, 299);
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
            this.labelX9.Location = new System.Drawing.Point(12, 270);
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
            this.labelX8.Location = new System.Drawing.Point(12, 240);
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
            this.labelX7.Location = new System.Drawing.Point(12, 208);
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
            this.labelX6.Location = new System.Drawing.Point(12, 177);
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
            this.labelX5.Location = new System.Drawing.Point(12, 150);
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
            this.labelX4.Location = new System.Drawing.Point(12, 118);
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
            this.labelX3.Location = new System.Drawing.Point(12, 84);
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
            this.labelX2.Location = new System.Drawing.Point(12, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "本国姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 9;
            // 
            // txtPassNo
            // 
            this.txtPassNo.Location = new System.Drawing.Point(93, 177);
            this.txtPassNo.Name = "txtPassNo";
            this.txtPassNo.Size = new System.Drawing.Size(100, 21);
            this.txtPassNo.TabIndex = 10;
            // 
            // txtIssuePlace
            // 
            this.txtIssuePlace.Location = new System.Drawing.Point(93, 297);
            this.txtIssuePlace.Name = "txtIssuePlace";
            this.txtIssuePlace.Size = new System.Drawing.Size(100, 21);
            this.txtIssuePlace.TabIndex = 9;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(93, 270);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(100, 21);
            this.txtBirthPlace.TabIndex = 9;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(93, 121);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 21);
            this.txtSex.TabIndex = 9;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(93, 86);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(100, 21);
            this.txtEnglishName.TabIndex = 9;
            // 
            // FrmCheckAutoInputInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 556);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmCheckAutoInputInfo";
            this.Text = "自动录入信息校验:";
            this.Load += new System.EventHandler(this.FrmCheckAutoInputInfo_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassportNo)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpireDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelMain;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtExpireDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtLicenseTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtBirthday;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnNoFault;
        private DevComponents.DotNetBar.ButtonX btnSaveChanges;
        private DevComponents.DotNetBar.ButtonX btnPre;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassNo;
        private System.Windows.Forms.TextBox txtIssuePlace;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtEnglishName;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCheckPerson;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisaInfo_id;
        private DevComponents.DotNetBar.PanelEx panelRight;
        private System.Windows.Forms.PictureBox picPassportNo;
    }
}