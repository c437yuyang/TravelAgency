﻿namespace TravletAgence.CSUI.FrmMain
{
    partial class FrmVisaTypeIn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasTypeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisaInfo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain = new DevComponents.DotNetBar.PanelEx();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnPageFirst = new DevComponents.DotNetBar.ButtonItem();
            this.btnPagePre = new DevComponents.DotNetBar.ButtonItem();
            this.btnPageNext = new DevComponents.DotNetBar.ButtonItem();
            this.btnPageLast = new DevComponents.DotNetBar.ButtonItem();
            this.cbCurPage = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnGoto = new DevComponents.DotNetBar.ButtonItem();
            this.lbRecordCount = new DevComponents.DotNetBar.LabelItem();
            this.lbl = new DevComponents.DotNetBar.LabelItem();
            this.cbPageSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.lbCurPage = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtLicenseTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtBirthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
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
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.cmsDgvRb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemTypeInInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodeShow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodeBatchGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodeBatchPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemRefreshState = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemSetGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.txtExpireDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday)).BeginInit();
            this.cmsDgvRb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpireDate)).BeginInit();
            this.SuspendLayout();
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
            this._Name,
            this.EnglishName,
            this.Sex,
            this.BirthDay,
            this.PassportNo,
            this.LicenceTime,
            this.ExpiryDate,
            this.Birthplace,
            this.IssuePlace,
            this.outState,
            this.HasTypeIn,
            this.GroupNo,
            this.VisaInfo_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(224, 28);
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
            this.dataGridView1.Size = new System.Drawing.Size(1047, 549);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
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
            // LicenceTime
            // 
            this.LicenceTime.DataPropertyName = "LicenceTime";
            this.LicenceTime.HeaderText = "发证日期";
            this.LicenceTime.Name = "LicenceTime";
            this.LicenceTime.ReadOnly = true;
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
            // outState
            // 
            this.outState.DataPropertyName = "outState";
            this.outState.HeaderText = "送签状态";
            this.outState.Name = "outState";
            this.outState.ReadOnly = true;
            // 
            // HasTypeIn
            // 
            this.HasTypeIn.DataPropertyName = "HasTypeIn";
            this.HasTypeIn.HeaderText = "资料录入";
            this.HasTypeIn.Name = "HasTypeIn";
            this.HasTypeIn.ReadOnly = true;
            // 
            // GroupNo
            // 
            this.GroupNo.DataPropertyName = "GroupNo";
            this.GroupNo.HeaderText = "团号";
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            // 
            // VisaInfo_id
            // 
            this.VisaInfo_id.DataPropertyName = "VisaInfo_id";
            this.VisaInfo_id.HeaderText = "VisaInfo_id";
            this.VisaInfo_id.Name = "VisaInfo_id";
            this.VisaInfo_id.ReadOnly = true;
            this.VisaInfo_id.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.bar1);
            this.panelMain.Controls.Add(this.panelEx2);
            this.panelMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1271, 577);
            this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMain.Style.GradientAngle = 90;
            this.panelMain.TabIndex = 23;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.DockTabStripHeight = 30;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPageFirst,
            this.btnPagePre,
            this.btnPageNext,
            this.btnPageLast,
            this.cbCurPage,
            this.btnGoto,
            this.lbRecordCount,
            this.lbl,
            this.cbPageSize,
            this.labelItem2,
            this.lbCurPage,
            this.labelItem1,
            this.labelItem3,
            this.labelItem4,
            this.labelItem5,
            this.labelItem6,
            this.labelItem7});
            this.bar1.ItemSpacing = 5;
            this.bar1.Location = new System.Drawing.Point(224, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1047, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 23;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Text = "首页";
            this.btnPageFirst.Click += new System.EventHandler(this.btnPageFirst_Click);
            // 
            // btnPagePre
            // 
            this.btnPagePre.Name = "btnPagePre";
            this.btnPagePre.Text = "上一页";
            this.btnPagePre.Click += new System.EventHandler(this.btnPagePre_Click);
            // 
            // btnPageNext
            // 
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Text = "下一页";
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnPageLast
            // 
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Text = "尾页";
            this.btnPageLast.Click += new System.EventHandler(this.btnPageLast_Click);
            // 
            // cbCurPage
            // 
            this.cbCurPage.DropDownHeight = 106;
            this.cbCurPage.ItemHeight = 17;
            this.cbCurPage.Name = "cbCurPage";
            // 
            // btnGoto
            // 
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Text = "Go";
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Text = "共有记录";
            // 
            // lbl
            // 
            this.lbl.Name = "lbl";
            this.lbl.Text = "每页显示";
            // 
            // cbPageSize
            // 
            this.cbPageSize.DropDownHeight = 106;
            this.cbPageSize.ItemHeight = 17;
            this.cbPageSize.Name = "cbPageSize";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "条";
            // 
            // lbCurPage
            // 
            this.lbCurPage.Name = "lbCurPage";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "进签:";
            // 
            // labelItem3
            // 
            this.labelItem3.BackColor = System.Drawing.Color.Yellow;
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "          ";
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "出签:";
            // 
            // labelItem5
            // 
            this.labelItem5.BackColor = System.Drawing.Color.Green;
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Text = "          ";
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "未正常出签:";
            // 
            // labelItem7
            // 
            this.labelItem7.BackColor = System.Drawing.Color.Red;
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "          ";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtExpireDate);
            this.panelEx2.Controls.Add(this.txtLicenseTime);
            this.panelEx2.Controls.Add(this.txtBirthday);
            this.panelEx2.Controls.Add(this.labelX11);
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
            this.panelEx2.Controls.Add(this.txtSex);
            this.panelEx2.Controls.Add(this.txtEnglishName);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(224, 577);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 19;
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
            this.txtLicenseTime.Location = new System.Drawing.Point(93, 212);
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
            this.txtBirthday.Location = new System.Drawing.Point(93, 152);
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
            this.labelX11.Location = new System.Drawing.Point(12, 16);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(150, 23);
            this.labelX11.TabIndex = 19;
            this.labelX11.Text = "护照信息录入:";
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddToDatabase.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddToDatabase.Location = new System.Drawing.Point(12, 501);
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
            this.btnReadData.Location = new System.Drawing.Point(12, 472);
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
            this.btnAutoRead.Location = new System.Drawing.Point(118, 472);
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
            this.btnLoadKernel.Location = new System.Drawing.Point(12, 441);
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
            this.btnFreeKernel.Location = new System.Drawing.Point(118, 441);
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
            this.txtPicPath.Multiline = true;
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.PreventEnterBeep = true;
            this.txtPicPath.Size = new System.Drawing.Size(173, 72);
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
            // cmsDgvRb
            // 
            this.cmsDgvRb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemDelete,
            this.cmsItemModify,
            this.cmsItemTypeInInfo,
            this.cmsItemQRCodeShow,
            this.cmsItemQRCodeBatchGenerate,
            this.cmsItemQRCodeBatchPrint,
            this.cmsItemQRCodePrint,
            this.cmsItemRefreshState,
            this.cmsItemSetGroup});
            this.cmsDgvRb.Name = "cmsDgvRb";
            this.cmsDgvRb.Size = new System.Drawing.Size(161, 202);
            // 
            // cmsItemDelete
            // 
            this.cmsItemDelete.Name = "cmsItemDelete";
            this.cmsItemDelete.Size = new System.Drawing.Size(160, 22);
            this.cmsItemDelete.Text = "删除";
            this.cmsItemDelete.Click += new System.EventHandler(this.cmsItemDelete_Click);
            // 
            // cmsItemModify
            // 
            this.cmsItemModify.Name = "cmsItemModify";
            this.cmsItemModify.Size = new System.Drawing.Size(160, 22);
            this.cmsItemModify.Text = "修改";
            // 
            // cmsItemTypeInInfo
            // 
            this.cmsItemTypeInInfo.Name = "cmsItemTypeInInfo";
            this.cmsItemTypeInInfo.Size = new System.Drawing.Size(160, 22);
            this.cmsItemTypeInInfo.Text = "录入资料";
            this.cmsItemTypeInInfo.Click += new System.EventHandler(this.cmsItemTypeInInfo_Click);
            // 
            // cmsItemQRCodeShow
            // 
            this.cmsItemQRCodeShow.Name = "cmsItemQRCodeShow";
            this.cmsItemQRCodeShow.Size = new System.Drawing.Size(160, 22);
            this.cmsItemQRCodeShow.Text = "显示二维码";
            this.cmsItemQRCodeShow.Click += new System.EventHandler(this.showQRCode_Click);
            // 
            // cmsItemQRCodeBatchGenerate
            // 
            this.cmsItemQRCodeBatchGenerate.Name = "cmsItemQRCodeBatchGenerate";
            this.cmsItemQRCodeBatchGenerate.Size = new System.Drawing.Size(160, 22);
            this.cmsItemQRCodeBatchGenerate.Text = "批量生成二维码";
            this.cmsItemQRCodeBatchGenerate.Click += new System.EventHandler(this.cmsItemQRCodeBatchGenerate_Click);
            // 
            // cmsItemQRCodeBatchPrint
            // 
            this.cmsItemQRCodeBatchPrint.Name = "cmsItemQRCodeBatchPrint";
            this.cmsItemQRCodeBatchPrint.Size = new System.Drawing.Size(160, 22);
            this.cmsItemQRCodeBatchPrint.Text = "批量打印二维码";
            // 
            // cmsItemQRCodePrint
            // 
            this.cmsItemQRCodePrint.Name = "cmsItemQRCodePrint";
            this.cmsItemQRCodePrint.Size = new System.Drawing.Size(160, 22);
            this.cmsItemQRCodePrint.Text = "打印二维码";
            // 
            // cmsItemRefreshState
            // 
            this.cmsItemRefreshState.Name = "cmsItemRefreshState";
            this.cmsItemRefreshState.Size = new System.Drawing.Size(160, 22);
            this.cmsItemRefreshState.Text = "刷新数据库状态";
            this.cmsItemRefreshState.Click += new System.EventHandler(this.cmsItemRefreshState_Click);
            // 
            // cmsItemSetGroup
            // 
            this.cmsItemSetGroup.Name = "cmsItemSetGroup";
            this.cmsItemSetGroup.Size = new System.Drawing.Size(160, 22);
            this.cmsItemSetGroup.Text = "设置团号";
            this.cmsItemSetGroup.Click += new System.EventHandler(this.cmsItemSetGroup_Click);
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
            this.txtExpireDate.Location = new System.Drawing.Point(93, 244);
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
            // FrmVisaTypeIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 577);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmVisaTypeIn";
            this.Text = "签证信息录入";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday)).EndInit();
            this.cmsDgvRb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtExpireDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private DevComponents.DotNetBar.PanelEx panelMain;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPageFirst;
        private DevComponents.DotNetBar.ButtonItem btnPagePre;
        private DevComponents.DotNetBar.ButtonItem btnPageNext;
        private DevComponents.DotNetBar.ButtonItem btnPageLast;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnAddToDatabase;
        private DevComponents.DotNetBar.ButtonX btnReadData;
        private DevComponents.DotNetBar.ButtonX btnAutoRead;
        private DevComponents.DotNetBar.ButtonX btnLoadKernel;
        private DevComponents.DotNetBar.ButtonX btnFreeKernel;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPicPath;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassNo;
        private System.Windows.Forms.TextBox txtIssuePlace;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtEnglishName;
        private DevComponents.DotNetBar.ComboBoxItem cbCurPage;
        private DevComponents.DotNetBar.ButtonItem btnGoto;
        private DevComponents.DotNetBar.LabelItem lbRecordCount;
        private DevComponents.DotNetBar.LabelItem lbl;
        private DevComponents.DotNetBar.ComboBoxItem cbPageSize;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem lbCurPage;
        private System.Windows.Forms.ContextMenuStrip cmsDgvRb;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodeShow;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsItemModify;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodeBatchGenerate;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodeBatchPrint;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodePrint;
        private System.Windows.Forms.ToolStripMenuItem cmsItemRefreshState;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private System.Windows.Forms.ToolStripMenuItem cmsItemTypeInInfo;
        private System.Windows.Forms.ToolStripMenuItem cmsItemSetGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn outState;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasTypeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisaInfo_id;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtBirthday;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtLicenseTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtExpireDate;

    }
}

