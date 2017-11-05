namespace TravletAgence.CSUI.FrmMain
{
    partial class FrmVisaManage
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
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.PredictTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Types = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemShowGroupNo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemRefreshDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBars = new DevComponents.DotNetBar.PanelEx();
            this.panelSerachBar = new DevComponents.DotNetBar.PanelEx();
            this.cbDisplayType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSchSalesPerson = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.progressLoading = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.btnClearSchConditions = new DevComponents.DotNetBar.ButtonX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtSchGroupNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb1 = new DevComponents.DotNetBar.LabelX();
            this.txtSchEntryTimeTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSchEntryTimeFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.btnShowAll = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.bgWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.panelDgv = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsDgv.SuspendLayout();
            this.panelBars.SuspendLayout();
            this.panelSerachBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeFrom)).BeginInit();
            this.panelDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
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
            this.lbCurPage});
            this.bar1.ItemSpacing = 5;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1041, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 25;
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
            this.cbPageSize.TextChanged += new System.EventHandler(this.cbPageSize_TextChanged);
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
            this.GroupNo,
            this.Country,
            this.CountryImage,
            this.PredictTime,
            this.EntryTime,
            this.SalesPerson,
            this.Types,
            this.Visa_id});
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
            this.dataGridView1.Size = new System.Drawing.Size(1041, 478);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // GroupNo
            // 
            this.GroupNo.DataPropertyName = "GroupNo";
            this.GroupNo.HeaderText = "团号";
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            this.GroupNo.Width = 300;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "国家";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // CountryImage
            // 
            this.CountryImage.HeaderText = "国家图标";
            this.CountryImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CountryImage.Name = "CountryImage";
            this.CountryImage.ReadOnly = true;
            this.CountryImage.Width = 200;
            // 
            // PredictTime
            // 
            this.PredictTime.DataPropertyName = "PredictTime";
            this.PredictTime.HeaderText = "出发时间";
            this.PredictTime.Name = "PredictTime";
            this.PredictTime.ReadOnly = true;
            // 
            // EntryTime
            // 
            this.EntryTime.DataPropertyName = "EntryTime";
            this.EntryTime.HeaderText = "办理时间";
            this.EntryTime.Name = "EntryTime";
            this.EntryTime.ReadOnly = true;
            // 
            // SalesPerson
            // 
            this.SalesPerson.DataPropertyName = "SalesPerson";
            this.SalesPerson.HeaderText = "办理人";
            this.SalesPerson.Name = "SalesPerson";
            this.SalesPerson.ReadOnly = true;
            // 
            // Types
            // 
            this.Types.DataPropertyName = "Types";
            this.Types.HeaderText = "类型";
            this.Types.Name = "Types";
            this.Types.ReadOnly = true;
            // 
            // Visa_id
            // 
            this.Visa_id.DataPropertyName = "Visa_id";
            this.Visa_id.HeaderText = "Visa_id";
            this.Visa_id.Name = "Visa_id";
            this.Visa_id.ReadOnly = true;
            this.Visa_id.Visible = false;
            // 
            // cmsDgv
            // 
            this.cmsDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.cmsItemShowGroupNo,
            this.cmsItemRefreshDatabase});
            this.cmsDgv.Name = "cmsDgv";
            this.cmsDgv.Size = new System.Drawing.Size(161, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // cmsItemShowGroupNo
            // 
            this.cmsItemShowGroupNo.Name = "cmsItemShowGroupNo";
            this.cmsItemShowGroupNo.Size = new System.Drawing.Size(160, 22);
            this.cmsItemShowGroupNo.Text = "查看选中团号";
            this.cmsItemShowGroupNo.Click += new System.EventHandler(this.cmsItemShowGroupNo_Click);
            // 
            // cmsItemRefreshDatabase
            // 
            this.cmsItemRefreshDatabase.Name = "cmsItemRefreshDatabase";
            this.cmsItemRefreshDatabase.Size = new System.Drawing.Size(160, 22);
            this.cmsItemRefreshDatabase.Text = "刷新数据库状态";
            this.cmsItemRefreshDatabase.Click += new System.EventHandler(this.cmsItemRefreshDatabase_Click);
            // 
            // panelBars
            // 
            this.panelBars.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBars.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBars.Controls.Add(this.panelSerachBar);
            this.panelBars.Controls.Add(this.bar1);
            this.panelBars.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBars.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBars.Location = new System.Drawing.Point(0, 0);
            this.panelBars.Name = "panelBars";
            this.panelBars.Size = new System.Drawing.Size(1041, 96);
            this.panelBars.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBars.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBars.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBars.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBars.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBars.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBars.Style.GradientAngle = 90;
            this.panelBars.TabIndex = 30;
            // 
            // panelSerachBar
            // 
            this.panelSerachBar.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelSerachBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelSerachBar.Controls.Add(this.cbDisplayType);
            this.panelSerachBar.Controls.Add(this.txtSchSalesPerson);
            this.panelSerachBar.Controls.Add(this.labelX1);
            this.panelSerachBar.Controls.Add(this.progressLoading);
            this.panelSerachBar.Controls.Add(this.btnClearSchConditions);
            this.panelSerachBar.Controls.Add(this.labelX15);
            this.panelSerachBar.Controls.Add(this.txtSchGroupNo);
            this.panelSerachBar.Controls.Add(this.lb1);
            this.panelSerachBar.Controls.Add(this.txtSchEntryTimeTo);
            this.panelSerachBar.Controls.Add(this.txtSchEntryTimeFrom);
            this.panelSerachBar.Controls.Add(this.labelX14);
            this.panelSerachBar.Controls.Add(this.labelX12);
            this.panelSerachBar.Controls.Add(this.btnShowAll);
            this.panelSerachBar.Controls.Add(this.btnSearch);
            this.panelSerachBar.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelSerachBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerachBar.Location = new System.Drawing.Point(0, 28);
            this.panelSerachBar.Name = "panelSerachBar";
            this.panelSerachBar.Size = new System.Drawing.Size(1041, 68);
            this.panelSerachBar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelSerachBar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelSerachBar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelSerachBar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelSerachBar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelSerachBar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelSerachBar.Style.GradientAngle = 90;
            this.panelSerachBar.TabIndex = 29;
            // 
            // cbDisplayType
            // 
            this.cbDisplayType.DisplayMember = "Text";
            this.cbDisplayType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDisplayType.FormattingEnabled = true;
            this.cbDisplayType.ItemHeight = 15;
            this.cbDisplayType.Location = new System.Drawing.Point(374, 3);
            this.cbDisplayType.Name = "cbDisplayType";
            this.cbDisplayType.Size = new System.Drawing.Size(83, 21);
            this.cbDisplayType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDisplayType.TabIndex = 30;
            // 
            // txtSchSalesPerson
            // 
            // 
            // 
            // 
            this.txtSchSalesPerson.Border.Class = "TextBoxBorder";
            this.txtSchSalesPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchSalesPerson.Location = new System.Drawing.Point(225, 5);
            this.txtSchSalesPerson.Name = "txtSchSalesPerson";
            this.txtSchSalesPerson.PreventEnterBeep = true;
            this.txtSchSalesPerson.Size = new System.Drawing.Size(100, 21);
            this.txtSchSalesPerson.TabIndex = 29;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(176, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(55, 23);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "办理人:";
            // 
            // progressLoading
            // 
            // 
            // 
            // 
            this.progressLoading.BackgroundStyle.BackgroundImageAlpha = ((byte)(64));
            this.progressLoading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressLoading.FocusCuesEnabled = false;
            this.progressLoading.Location = new System.Drawing.Point(730, 5);
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.progressLoading.ProgressColor = System.Drawing.Color.YellowGreen;
            this.progressLoading.Size = new System.Drawing.Size(73, 55);
            this.progressLoading.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressLoading.TabIndex = 27;
            this.progressLoading.Value = 100;
            // 
            // btnClearSchConditions
            // 
            this.btnClearSchConditions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearSchConditions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearSchConditions.Location = new System.Drawing.Point(521, 34);
            this.btnClearSchConditions.Name = "btnClearSchConditions";
            this.btnClearSchConditions.Size = new System.Drawing.Size(92, 23);
            this.btnClearSchConditions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearSchConditions.TabIndex = 26;
            this.btnClearSchConditions.Text = "清空搜索条件";
            this.btnClearSchConditions.Click += new System.EventHandler(this.btnClearSchConditions_Click);
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(336, 5);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(63, 21);
            this.labelX15.TabIndex = 24;
            this.labelX15.Text = "类型:";
            // 
            // txtSchGroupNo
            // 
            // 
            // 
            // 
            this.txtSchGroupNo.Border.Class = "TextBoxBorder";
            this.txtSchGroupNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchGroupNo.Location = new System.Drawing.Point(58, 4);
            this.txtSchGroupNo.Name = "txtSchGroupNo";
            this.txtSchGroupNo.Size = new System.Drawing.Size(103, 21);
            this.txtSchGroupNo.TabIndex = 23;
            // 
            // lb1
            // 
            // 
            // 
            // 
            this.lb1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb1.Location = new System.Drawing.Point(3, 5);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(49, 21);
            this.lb1.TabIndex = 22;
            this.lb1.Text = "团号:";
            // 
            // txtSchEntryTimeTo
            // 
            // 
            // 
            // 
            this.txtSchEntryTimeTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSchEntryTimeTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtSchEntryTimeTo.ButtonDropDown.Visible = true;
            this.txtSchEntryTimeTo.IsPopupCalendarOpen = false;
            this.txtSchEntryTimeTo.Location = new System.Drawing.Point(204, 32);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtSchEntryTimeTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtSchEntryTimeTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtSchEntryTimeTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeTo.MonthCalendar.DisplayMonth = new System.DateTime(2017, 11, 1, 0, 0, 0, 0);
            this.txtSchEntryTimeTo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.txtSchEntryTimeTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtSchEntryTimeTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSchEntryTimeTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtSchEntryTimeTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeTo.MonthCalendar.TodayButtonVisible = true;
            this.txtSchEntryTimeTo.Name = "txtSchEntryTimeTo";
            this.txtSchEntryTimeTo.Size = new System.Drawing.Size(121, 21);
            this.txtSchEntryTimeTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSchEntryTimeTo.TabIndex = 21;
            // 
            // txtSchEntryTimeFrom
            // 
            // 
            // 
            // 
            this.txtSchEntryTimeFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSchEntryTimeFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtSchEntryTimeFrom.ButtonDropDown.Visible = true;
            this.txtSchEntryTimeFrom.IsPopupCalendarOpen = false;
            this.txtSchEntryTimeFrom.Location = new System.Drawing.Point(58, 32);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtSchEntryTimeFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtSchEntryTimeFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtSchEntryTimeFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeFrom.MonthCalendar.DisplayMonth = new System.DateTime(2017, 11, 1, 0, 0, 0, 0);
            this.txtSchEntryTimeFrom.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.txtSchEntryTimeFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtSchEntryTimeFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSchEntryTimeFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtSchEntryTimeFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchEntryTimeFrom.MonthCalendar.TodayButtonVisible = true;
            this.txtSchEntryTimeFrom.Name = "txtSchEntryTimeFrom";
            this.txtSchEntryTimeFrom.Size = new System.Drawing.Size(121, 21);
            this.txtSchEntryTimeFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSchEntryTimeFrom.TabIndex = 20;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(185, 33);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(13, 21);
            this.labelX14.TabIndex = 19;
            this.labelX14.Text = "-";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(3, 32);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(63, 21);
            this.labelX12.TabIndex = 17;
            this.labelX12.Text = "录入时间:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowAll.Location = new System.Drawing.Point(619, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(91, 23);
            this.btnShowAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "显示全部";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(521, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bgWorkerLoadData
            // 
            this.bgWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerLoadData_DoWork);
            this.bgWorkerLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerLoadData_ProgressChanged);
            this.bgWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerLoadData_RunWorkerCompleted);
            // 
            // labelItem8
            // 
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.Text = "显示类型:";
            // 
            // panelDgv
            // 
            this.panelDgv.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelDgv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDgv.Controls.Add(this.dataGridView1);
            this.panelDgv.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgv.Location = new System.Drawing.Point(0, 96);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1041, 478);
            this.panelDgv.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDgv.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelDgv.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelDgv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelDgv.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelDgv.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelDgv.Style.GradientAngle = 90;
            this.panelDgv.TabIndex = 37;
            this.panelDgv.Text = "panelEx1";
            // 
            // FrmVisaManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 574);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.panelBars);
            this.Name = "FrmVisaManage";
            this.Text = "团号管理";
            this.Load += new System.EventHandler(this.FrmVisaManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsDgv.ResumeLayout(false);
            this.panelBars.ResumeLayout(false);
            this.panelSerachBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeFrom)).EndInit();
            this.panelDgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPageFirst;
        private DevComponents.DotNetBar.ButtonItem btnPagePre;
        private DevComponents.DotNetBar.ButtonItem btnPageNext;
        private DevComponents.DotNetBar.ButtonItem btnPageLast;
        private DevComponents.DotNetBar.ComboBoxItem cbCurPage;
        private DevComponents.DotNetBar.ButtonItem btnGoto;
        private DevComponents.DotNetBar.LabelItem lbRecordCount;
        private DevComponents.DotNetBar.LabelItem lbl;
        private DevComponents.DotNetBar.ComboBoxItem cbPageSize;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem lbCurPage;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cmsDgv;
        private System.Windows.Forms.ToolStripMenuItem cmsItemShowGroupNo;
        private System.Windows.Forms.ToolStripMenuItem cmsItemRefreshDatabase;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewImageColumn CountryImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredictTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Types;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visa_id;
        private DevComponents.DotNetBar.PanelEx panelBars;
        private DevComponents.DotNetBar.PanelEx panelSerachBar;
        private DevComponents.DotNetBar.Controls.CircularProgress progressLoading;
        private DevComponents.DotNetBar.ButtonX btnClearSchConditions;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchGroupNo;
        private DevComponents.DotNetBar.LabelX lb1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtSchEntryTimeTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtSchEntryTimeFrom;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.ButtonX btnShowAll;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchSalesPerson;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.ComponentModel.BackgroundWorker bgWorkerLoadData;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbDisplayType;
        private DevComponents.DotNetBar.PanelEx panelDgv;
    }
}