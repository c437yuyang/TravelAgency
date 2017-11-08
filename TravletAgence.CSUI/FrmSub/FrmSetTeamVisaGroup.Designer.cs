namespace TravletAgence.CSUI.FrmSub
{
    partial class FrmSetTeamVisaGroup
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new DevComponents.DotNetBar.PanelEx();
            this.panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnCreateReport = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.panelMid2 = new DevComponents.DotNetBar.PanelEx();
            this.dgvGroupInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dgvPassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IssuePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceTime = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ExpiryDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Occupation = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMid = new DevComponents.DotNetBar.PanelEx();
            this.lvIn = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelGroupInfo = new DevComponents.DotNetBar.PanelEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbCountry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Japan = new DevComponents.Editors.ComboItem();
            this.Korea = new DevComponents.Editors.ComboItem();
            this.Thailand = new DevComponents.Editors.ComboItem();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtDepartureTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSalesPerson = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelInOutBtns = new DevComponents.DotNetBar.PanelEx();
            this.btnAllOut = new DevComponents.DotNetBar.ButtonX();
            this.btnOut = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnAllIn = new DevComponents.DotNetBar.ButtonX();
            this.lvOut = new DevComponents.DotNetBar.Controls.ListViewEx();
            this._Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssuePlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassportNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTop = new DevComponents.DotNetBar.PanelEx();
            this.lbCount = new DevComponents.DotNetBar.LabelX();
            this.txtGroupNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmsDgvRb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMid2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInfo)).BeginInit();
            this.panelMid.SuspendLayout();
            this.panelGroupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartureTime)).BeginInit();
            this.panelInOutBtns.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.cmsDgvRb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelMid2);
            this.panelMain.Controls.Add(this.panelMid);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1340, 725);
            this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMain.Style.GradientAngle = 90;
            this.panelMain.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnReset);
            this.panelBottom.Controls.Add(this.btnCreateReport);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnConfirm);
            this.panelBottom.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 688);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1340, 37);
            this.panelBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBottom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBottom.Style.GradientAngle = 90;
            this.panelBottom.TabIndex = 48;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(613, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除团号";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(527, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "恢复";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateReport.Location = new System.Drawing.Point(438, 3);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(75, 23);
            this.btnCreateReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateReport.TabIndex = 13;
            this.btnCreateReport.Text = "生成报表";
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(357, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Location = new System.Drawing.Point(276, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "确认修改";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelMid2
            // 
            this.panelMid2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMid2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMid2.Controls.Add(this.dgvGroupInfo);
            this.panelMid2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid2.Location = new System.Drawing.Point(0, 227);
            this.panelMid2.Name = "panelMid2";
            this.panelMid2.Size = new System.Drawing.Size(1340, 498);
            this.panelMid2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMid2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMid2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMid2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMid2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMid2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMid2.Style.GradientAngle = 90;
            this.panelMid2.TabIndex = 40;
            // 
            // dgvGroupInfo
            // 
            this.dgvGroupInfo.AllowUserToAddRows = false;
            this.dgvGroupInfo.AllowUserToDeleteRows = false;
            this.dgvGroupInfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.EnglishName,
            this.Sex,
            this.BirthPlace,
            this.BirthDay,
            this.dgvPassportNo,
            this._IssuePlace,
            this.LicenceTime,
            this.ExpiryDate,
            this.Occupation,
            this.Phone,
            this.Client,
            this.SalesPerson});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupInfo.EnableHeadersVisualStyles = false;
            this.dgvGroupInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvGroupInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvGroupInfo.Name = "dgvGroupInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGroupInfo.RowTemplate.Height = 30;
            this.dgvGroupInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGroupInfo.Size = new System.Drawing.Size(1340, 498);
            this.dgvGroupInfo.TabIndex = 10;
            this.dgvGroupInfo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGroupInfo_CellMouseUp);
            this.dgvGroupInfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupInfo_CellValueChanged);
            this.dgvGroupInfo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvGroupInfo_RowsAdded);
            this.dgvGroupInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGroupInfo_KeyDown);
            this.dgvGroupInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvGroupInfo_KeyPress);
            this.dgvGroupInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvGroupInfo_KeyUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "本国姓名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // EnglishName
            // 
            this.EnglishName.DataPropertyName = "EnglishName";
            this.EnglishName.HeaderText = "英语姓名";
            this.EnglishName.Name = "EnglishName";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.DropDownHeight = 106;
            this.Sex.DropDownWidth = 121;
            this.Sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sex.HeaderText = "性别";
            this.Sex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sex.IntegralHeight = false;
            this.Sex.ItemHeight = 16;
            this.Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Sex.Name = "Sex";
            this.Sex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // BirthPlace
            // 
            this.BirthPlace.DataPropertyName = "BirthPlace";
            this.BirthPlace.HeaderText = "出生地";
            this.BirthPlace.Name = "BirthPlace";
            // 
            // BirthDay
            // 
            // 
            // 
            // 
            this.BirthDay.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.BirthDay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BirthDay.DataPropertyName = "Birthday";
            this.BirthDay.HeaderText = "出生日期";
            this.BirthDay.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.BirthDay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BirthDay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.BirthDay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BirthDay.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.BirthDay.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.BirthDay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvPassportNo
            // 
            this.dgvPassportNo.DataPropertyName = "PassportNo";
            this.dgvPassportNo.HeaderText = "护照号";
            this.dgvPassportNo.Name = "dgvPassportNo";
            // 
            // _IssuePlace
            // 
            this._IssuePlace.DataPropertyName = "IssuePlace";
            this._IssuePlace.HeaderText = "签发地";
            this._IssuePlace.Name = "_IssuePlace";
            // 
            // LicenceTime
            // 
            // 
            // 
            // 
            this.LicenceTime.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.LicenceTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LicenceTime.DataPropertyName = "LicenceTime";
            this.LicenceTime.HeaderText = "签发日期";
            this.LicenceTime.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.LicenceTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LicenceTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.LicenceTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LicenceTime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.LicenceTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.LicenceTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LicenceTime.Name = "LicenceTime";
            // 
            // ExpiryDate
            // 
            // 
            // 
            // 
            this.ExpiryDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.ExpiryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "有效期至";
            this.ExpiryDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.ExpiryDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ExpiryDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.ExpiryDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ExpiryDate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.ExpiryDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.ExpiryDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // Occupation
            // 
            this.Occupation.DataPropertyName = "Occupation";
            this.Occupation.DropDownHeight = 106;
            this.Occupation.DropDownWidth = 121;
            this.Occupation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Occupation.HeaderText = "职业";
            this.Occupation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Occupation.IntegralHeight = false;
            this.Occupation.ItemHeight = 16;
            this.Occupation.Items.AddRange(new object[] {
            "教师",
            "学生",
            "会计师",
            "家庭主妇",
            "副经理"});
            this.Occupation.Name = "Occupation";
            this.Occupation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Occupation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Occupation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "联系电话";
            this.Phone.Name = "Phone";
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "客户";
            this.Client.Name = "Client";
            // 
            // SalesPerson
            // 
            this.SalesPerson.DataPropertyName = "SalesPerson";
            this.SalesPerson.HeaderText = "销售";
            this.SalesPerson.Name = "SalesPerson";
            // 
            // panelMid
            // 
            this.panelMid.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMid.Controls.Add(this.lvIn);
            this.panelMid.Controls.Add(this.panelGroupInfo);
            this.panelMid.Controls.Add(this.panelInOutBtns);
            this.panelMid.Controls.Add(this.lvOut);
            this.panelMid.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 35);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1340, 192);
            this.panelMid.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMid.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMid.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMid.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMid.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMid.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMid.Style.GradientAngle = 90;
            this.panelMid.TabIndex = 36;
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
            this.columnHeader3,
            this.columnHeader4});
            this.lvIn.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvIn.FullRowSelect = true;
            this.lvIn.Location = new System.Drawing.Point(481, 0);
            this.lvIn.Name = "lvIn";
            this.lvIn.Size = new System.Drawing.Size(359, 192);
            this.lvIn.TabIndex = 51;
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "护照号";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 118;
            // 
            // panelGroupInfo
            // 
            this.panelGroupInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelGroupInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelGroupInfo.Controls.Add(this.labelX6);
            this.panelGroupInfo.Controls.Add(this.txtClient);
            this.panelGroupInfo.Controls.Add(this.cbCountry);
            this.panelGroupInfo.Controls.Add(this.labelX4);
            this.panelGroupInfo.Controls.Add(this.txtDepartureTime);
            this.panelGroupInfo.Controls.Add(this.labelX3);
            this.panelGroupInfo.Controls.Add(this.txtSalesPerson);
            this.panelGroupInfo.Controls.Add(this.labelX1);
            this.panelGroupInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelGroupInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupInfo.Location = new System.Drawing.Point(839, 0);
            this.panelGroupInfo.Name = "panelGroupInfo";
            this.panelGroupInfo.Size = new System.Drawing.Size(501, 192);
            this.panelGroupInfo.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelGroupInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelGroupInfo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelGroupInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelGroupInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelGroupInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelGroupInfo.Style.GradientAngle = 90;
            this.panelGroupInfo.TabIndex = 47;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(49, 52);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(91, 23);
            this.labelX6.TabIndex = 75;
            this.labelX6.Text = "客户:";
            // 
            // txtClient
            // 
            // 
            // 
            // 
            this.txtClient.Border.Class = "TextBoxBorder";
            this.txtClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClient.Location = new System.Drawing.Point(146, 52);
            this.txtClient.Name = "txtClient";
            this.txtClient.PreventEnterBeep = true;
            this.txtClient.Size = new System.Drawing.Size(108, 21);
            this.txtClient.TabIndex = 7;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "Text";
            this.cbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.ItemHeight = 15;
            this.cbCountry.Items.AddRange(new object[] {
            this.Japan,
            this.Korea,
            this.Thailand});
            this.cbCountry.Location = new System.Drawing.Point(334, 16);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCountry.TabIndex = 8;
            // 
            // Japan
            // 
            this.Japan.Text = "日本";
            // 
            // Korea
            // 
            this.Korea.Text = "韩国";
            // 
            // Thailand
            // 
            this.Thailand.Text = "泰国";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(288, 16);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(40, 23);
            this.labelX4.TabIndex = 72;
            this.labelX4.Text = "国家:";
            // 
            // txtDepartureTime
            // 
            // 
            // 
            // 
            this.txtDepartureTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDepartureTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDepartureTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDepartureTime.ButtonDropDown.Visible = true;
            this.txtDepartureTime.IsPopupCalendarOpen = false;
            this.txtDepartureTime.Location = new System.Drawing.Point(146, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtDepartureTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDepartureTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtDepartureTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDepartureTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDepartureTime.MonthCalendar.DisplayMonth = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.txtDepartureTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.txtDepartureTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDepartureTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDepartureTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDepartureTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDepartureTime.MonthCalendar.TodayButtonVisible = true;
            this.txtDepartureTime.Name = "txtDepartureTime";
            this.txtDepartureTime.Size = new System.Drawing.Size(108, 21);
            this.txtDepartureTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtDepartureTime.TabIndex = 6;
            this.txtDepartureTime.TextChanged += new System.EventHandler(this.txtDepartureTime_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(49, 19);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 70;
            this.labelX3.Text = "出发日期:";
            // 
            // txtSalesPerson
            // 
            // 
            // 
            // 
            this.txtSalesPerson.Border.Class = "TextBoxBorder";
            this.txtSalesPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSalesPerson.DisabledBackColor = System.Drawing.Color.White;
            this.txtSalesPerson.Location = new System.Drawing.Point(334, 52);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.PreventEnterBeep = true;
            this.txtSalesPerson.Size = new System.Drawing.Size(121, 21);
            this.txtSalesPerson.TabIndex = 9;
            this.txtSalesPerson.TextChanged += new System.EventHandler(this.txtSalesPerson_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(280, 52);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(48, 23);
            this.labelX1.TabIndex = 63;
            this.labelX1.Text = "操作员:";
            // 
            // panelInOutBtns
            // 
            this.panelInOutBtns.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelInOutBtns.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelInOutBtns.Controls.Add(this.btnAllOut);
            this.panelInOutBtns.Controls.Add(this.btnOut);
            this.panelInOutBtns.Controls.Add(this.btnIn);
            this.panelInOutBtns.Controls.Add(this.btnAllIn);
            this.panelInOutBtns.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelInOutBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInOutBtns.Location = new System.Drawing.Point(347, 0);
            this.panelInOutBtns.Name = "panelInOutBtns";
            this.panelInOutBtns.Size = new System.Drawing.Size(134, 192);
            this.panelInOutBtns.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelInOutBtns.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelInOutBtns.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelInOutBtns.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelInOutBtns.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelInOutBtns.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelInOutBtns.Style.GradientAngle = 90;
            this.panelInOutBtns.TabIndex = 37;
            // 
            // btnAllOut
            // 
            this.btnAllOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAllOut.Location = new System.Drawing.Point(30, 152);
            this.btnAllOut.Name = "btnAllOut";
            this.btnAllOut.Size = new System.Drawing.Size(75, 23);
            this.btnAllOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllOut.TabIndex = 5;
            this.btnAllOut.Text = "<<";
            this.btnAllOut.Click += new System.EventHandler(this.btnAllOut_Click);
            // 
            // btnOut
            // 
            this.btnOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOut.Location = new System.Drawing.Point(30, 109);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = "<";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Location = new System.Drawing.Point(30, 65);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = ">";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnAllIn
            // 
            this.btnAllIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAllIn.Location = new System.Drawing.Point(30, 16);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(75, 23);
            this.btnAllIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllIn.TabIndex = 2;
            this.btnAllIn.Text = ">>";
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
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
            this.IssuePlace,
            this.PassportNo});
            this.lvOut.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvOut.FullRowSelect = true;
            this.lvOut.Location = new System.Drawing.Point(0, 0);
            this.lvOut.Name = "lvOut";
            this.lvOut.Size = new System.Drawing.Size(347, 192);
            this.lvOut.TabIndex = 35;
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
            // PassportNo
            // 
            this.PassportNo.Text = "护照号";
            this.PassportNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassportNo.Width = 118;
            // 
            // panelTop
            // 
            this.panelTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelTop.Controls.Add(this.lbCount);
            this.panelTop.Controls.Add(this.txtGroupNo);
            this.panelTop.Controls.Add(this.labelX2);
            this.panelTop.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1340, 35);
            this.panelTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTop.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTop.Style.GradientAngle = 90;
            this.panelTop.TabIndex = 32;
            // 
            // lbCount
            // 
            // 
            // 
            // 
            this.lbCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCount.Location = new System.Drawing.Point(589, 5);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(119, 23);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "团队人数:0人";
            // 
            // txtGroupNo
            // 
            // 
            // 
            // 
            this.txtGroupNo.Border.Class = "TextBoxBorder";
            this.txtGroupNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGroupNo.DisabledBackColor = System.Drawing.Color.White;
            this.txtGroupNo.Location = new System.Drawing.Point(40, 7);
            this.txtGroupNo.Name = "txtGroupNo";
            this.txtGroupNo.PreventEnterBeep = true;
            this.txtGroupNo.Size = new System.Drawing.Size(498, 21);
            this.txtGroupNo.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "团号:";
            // 
            // cmsDgvRb
            // 
            this.cmsDgvRb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.cmsDgvRb.Name = "cmsDgvRb";
            this.cmsDgvRb.Size = new System.Drawing.Size(101, 70);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // FrmSetTeamVisaGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 725);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.Name = "FrmSetTeamVisaGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置团签团号";
            this.Load += new System.EventHandler(this.FrmSetGroup_Load);
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelMid2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInfo)).EndInit();
            this.panelMid.ResumeLayout(false);
            this.panelGroupInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartureTime)).EndInit();
            this.panelInOutBtns.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.cmsDgvRb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelMain;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGroupNo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelTop;
        private DevComponents.DotNetBar.PanelEx panelMid;
        private DevComponents.DotNetBar.Controls.ListViewEx lvOut;
        private System.Windows.Forms.ColumnHeader _Name;
        private System.Windows.Forms.ColumnHeader EntryTime;
        private System.Windows.Forms.ColumnHeader IssuePlace;
        private DevComponents.DotNetBar.PanelEx panelMid2;
        private DevComponents.DotNetBar.PanelEx panelBottom;
        private DevComponents.DotNetBar.ButtonX btnCreateReport;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private DevComponents.DotNetBar.PanelEx panelInOutBtns;
        private DevComponents.DotNetBar.ButtonX btnAllOut;
        private DevComponents.DotNetBar.ButtonX btnOut;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnAllIn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGroupInfo;
        private DevComponents.DotNetBar.LabelX lbCount;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private System.Windows.Forms.ContextMenuStrip cmsDgvRb;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader PassportNo;
        private DevComponents.DotNetBar.PanelEx panelGroupInfo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSalesPerson;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDepartureTime;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountry;
        private DevComponents.Editors.ComboItem Japan;
        private DevComponents.Editors.ComboItem Korea;
        private DevComponents.Editors.ComboItem Thailand;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishName;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IssuePlace;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn LicenceTime;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ExpiryDate;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPerson;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClient;
    }
}