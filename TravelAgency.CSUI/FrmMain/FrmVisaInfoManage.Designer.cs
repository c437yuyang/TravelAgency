namespace TravelAgency.CSUI.FrmMain
{
    partial class FrmVisaInfoManage
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
            this.QRCodeImage = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.Types = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisaInfo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain = new DevComponents.DotNetBar.PanelEx();
            this.panelDgv = new DevComponents.DotNetBar.PanelEx();
            this.panelBars = new DevComponents.DotNetBar.PanelEx();
            this.panelSerachBar = new DevComponents.DotNetBar.PanelEx();
            this.cbCountry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnShowToday = new DevComponents.DotNetBar.ButtonX();
            this.progressLoading = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.btnClearSchConditions = new DevComponents.DotNetBar.ButtonX();
            this.cbDisplayType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtSchGroupNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb1 = new DevComponents.DotNetBar.LabelX();
            this.txtSchEntryTimeTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSchEntryTimeFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtSchPassportNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.btnShowAll = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSchName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbSchName = new DevComponents.DotNetBar.LabelX();
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
            this.cmsDgvRb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemTypeInInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodeShow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodeBatchGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodeBatchPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemQRCodePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemRefreshState = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemSetGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.添加到团号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外领担保函ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人申请表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.机票报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.护照图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.头像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.护照红外图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelDgv.SuspendLayout();
            this.panelBars.SuspendLayout();
            this.panelSerachBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.cmsDgvRb.SuspendLayout();
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
            this.QRCodeImage,
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
            this.Types,
            this.VisaInfo_id,
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
            this.dataGridView1.Size = new System.Drawing.Size(1271, 532);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // QRCodeImage
            // 
            this.QRCodeImage.HeaderText = "二维码";
            this.QRCodeImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.QRCodeImage.Name = "QRCodeImage";
            this.QRCodeImage.ReadOnly = true;
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
            // Types
            // 
            this.Types.DataPropertyName = "Types";
            this.Types.HeaderText = "类型";
            this.Types.Name = "Types";
            this.Types.ReadOnly = true;
            // 
            // VisaInfo_id
            // 
            this.VisaInfo_id.DataPropertyName = "VisaInfo_id";
            this.VisaInfo_id.HeaderText = "VisaInfo_id";
            this.VisaInfo_id.Name = "VisaInfo_id";
            this.VisaInfo_id.ReadOnly = true;
            this.VisaInfo_id.Visible = false;
            // 
            // Visa_id
            // 
            this.Visa_id.DataPropertyName = "Visa_id";
            this.Visa_id.HeaderText = "Visa_id";
            this.Visa_id.Name = "Visa_id";
            this.Visa_id.ReadOnly = true;
            this.Visa_id.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Controls.Add(this.panelDgv);
            this.panelMain.Controls.Add(this.panelBars);
            this.panelMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1271, 623);
            this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMain.Style.GradientAngle = 90;
            this.panelMain.TabIndex = 23;
            // 
            // panelDgv
            // 
            this.panelDgv.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelDgv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDgv.Controls.Add(this.dataGridView1);
            this.panelDgv.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgv.Location = new System.Drawing.Point(0, 91);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1271, 532);
            this.panelDgv.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDgv.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelDgv.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelDgv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelDgv.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelDgv.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelDgv.Style.GradientAngle = 90;
            this.panelDgv.TabIndex = 38;
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
            this.panelBars.Size = new System.Drawing.Size(1271, 91);
            this.panelBars.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBars.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBars.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBars.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBars.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBars.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBars.Style.GradientAngle = 90;
            this.panelBars.TabIndex = 34;
            // 
            // panelSerachBar
            // 
            this.panelSerachBar.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelSerachBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelSerachBar.Controls.Add(this.cbCountry);
            this.panelSerachBar.Controls.Add(this.labelX3);
            this.panelSerachBar.Controls.Add(this.btnShowToday);
            this.panelSerachBar.Controls.Add(this.progressLoading);
            this.panelSerachBar.Controls.Add(this.btnClearSchConditions);
            this.panelSerachBar.Controls.Add(this.cbDisplayType);
            this.panelSerachBar.Controls.Add(this.labelX15);
            this.panelSerachBar.Controls.Add(this.txtSchGroupNo);
            this.panelSerachBar.Controls.Add(this.lb1);
            this.panelSerachBar.Controls.Add(this.txtSchEntryTimeTo);
            this.panelSerachBar.Controls.Add(this.txtSchEntryTimeFrom);
            this.panelSerachBar.Controls.Add(this.labelX14);
            this.panelSerachBar.Controls.Add(this.labelX12);
            this.panelSerachBar.Controls.Add(this.txtSchPassportNo);
            this.panelSerachBar.Controls.Add(this.labelX13);
            this.panelSerachBar.Controls.Add(this.btnShowAll);
            this.panelSerachBar.Controls.Add(this.btnSearch);
            this.panelSerachBar.Controls.Add(this.txtSchName);
            this.panelSerachBar.Controls.Add(this.lbSchName);
            this.panelSerachBar.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelSerachBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerachBar.Location = new System.Drawing.Point(0, 28);
            this.panelSerachBar.Name = "panelSerachBar";
            this.panelSerachBar.Size = new System.Drawing.Size(1271, 63);
            this.panelSerachBar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelSerachBar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelSerachBar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelSerachBar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelSerachBar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelSerachBar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelSerachBar.Style.GradientAngle = 90;
            this.panelSerachBar.TabIndex = 24;
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "Text";
            this.cbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.ItemHeight = 15;
            this.cbCountry.Location = new System.Drawing.Point(545, 6);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(83, 21);
            this.cbCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCountry.TabIndex = 38;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(508, 7);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(46, 21);
            this.labelX3.TabIndex = 37;
            this.labelX3.Text = "国家:";
            // 
            // btnShowToday
            // 
            this.btnShowToday.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowToday.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowToday.Location = new System.Drawing.Point(731, 33);
            this.btnShowToday.Name = "btnShowToday";
            this.btnShowToday.Size = new System.Drawing.Size(92, 23);
            this.btnShowToday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowToday.TabIndex = 28;
            this.btnShowToday.Text = "显示今日";
            this.btnShowToday.Click += new System.EventHandler(this.btnShowToday_Click);
            // 
            // progressLoading
            // 
            // 
            // 
            // 
            this.progressLoading.BackgroundStyle.BackgroundImageAlpha = ((byte)(64));
            this.progressLoading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressLoading.FocusCuesEnabled = false;
            this.progressLoading.Location = new System.Drawing.Point(829, 1);
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
            this.btnClearSchConditions.Location = new System.Drawing.Point(633, 34);
            this.btnClearSchConditions.Name = "btnClearSchConditions";
            this.btnClearSchConditions.Size = new System.Drawing.Size(92, 23);
            this.btnClearSchConditions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearSchConditions.TabIndex = 26;
            this.btnClearSchConditions.Text = "清空搜索条件";
            this.btnClearSchConditions.Click += new System.EventHandler(this.btnClearSchConditions_Click);
            // 
            // cbDisplayType
            // 
            this.cbDisplayType.DisplayMember = "Text";
            this.cbDisplayType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDisplayType.FormattingEnabled = true;
            this.cbDisplayType.ItemHeight = 15;
            this.cbDisplayType.Location = new System.Drawing.Point(399, 34);
            this.cbDisplayType.Name = "cbDisplayType";
            this.cbDisplayType.Size = new System.Drawing.Size(103, 21);
            this.cbDisplayType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDisplayType.TabIndex = 25;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(340, 36);
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
            this.txtSchGroupNo.Location = new System.Drawing.Point(399, 5);
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
            this.lb1.Location = new System.Drawing.Point(340, 6);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(63, 21);
            this.lb1.TabIndex = 22;
            this.lb1.Text = "所在团号:";
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
            this.labelX12.Location = new System.Drawing.Point(0, 33);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(63, 21);
            this.labelX12.TabIndex = 17;
            this.labelX12.Text = "录入时间:";
            // 
            // txtSchPassportNo
            // 
            // 
            // 
            // 
            this.txtSchPassportNo.Border.Class = "TextBoxBorder";
            this.txtSchPassportNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchPassportNo.Location = new System.Drawing.Point(58, 5);
            this.txtSchPassportNo.Name = "txtSchPassportNo";
            this.txtSchPassportNo.Size = new System.Drawing.Size(121, 21);
            this.txtSchPassportNo.TabIndex = 16;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(0, 6);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(63, 21);
            this.labelX13.TabIndex = 15;
            this.labelX13.Text = "护照号:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowAll.Location = new System.Drawing.Point(731, 5);
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
            this.btnSearch.Location = new System.Drawing.Point(633, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSchName
            // 
            // 
            // 
            // 
            this.txtSchName.Border.Class = "TextBoxBorder";
            this.txtSchName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSchName.Location = new System.Drawing.Point(222, 6);
            this.txtSchName.Name = "txtSchName";
            this.txtSchName.Size = new System.Drawing.Size(103, 21);
            this.txtSchName.TabIndex = 12;
            // 
            // lbSchName
            // 
            // 
            // 
            // 
            this.lbSchName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSchName.Location = new System.Drawing.Point(185, 6);
            this.lbSchName.Name = "lbSchName";
            this.lbSchName.Size = new System.Drawing.Size(63, 21);
            this.lbSchName.TabIndex = 11;
            this.lbSchName.Text = "姓名:";
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
            this.lbCurPage,
            this.labelItem1,
            this.labelItem3,
            this.labelItem4,
            this.labelItem5,
            this.labelItem6,
            this.labelItem7});
            this.bar1.ItemSpacing = 5;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1271, 28);
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
            this.cbPageSize.Click += new System.EventHandler(this.cbPageSize_Click);
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
            // cmsDgvRb
            // 
            this.cmsDgvRb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemDelete,
            this.cmsItemTypeInInfo,
            this.cmsItemQRCodeShow,
            this.cmsItemQRCodeBatchGenerate,
            this.cmsItemQRCodeBatchPrint,
            this.cmsItemQRCodePrint,
            this.cmsItemRefreshState,
            this.cmsItemSetGroup,
            this.添加到团号ToolStripMenuItem,
            this.生成报表ToolStripMenuItem,
            this.导出图像ToolStripMenuItem});
            this.cmsDgvRb.Name = "cmsDgvRb";
            this.cmsDgvRb.Size = new System.Drawing.Size(161, 246);
            // 
            // cmsItemDelete
            // 
            this.cmsItemDelete.Name = "cmsItemDelete";
            this.cmsItemDelete.Size = new System.Drawing.Size(160, 22);
            this.cmsItemDelete.Text = "删除";
            this.cmsItemDelete.Click += new System.EventHandler(this.cmsItemDelete_Click);
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
            // 添加到团号ToolStripMenuItem
            // 
            this.添加到团号ToolStripMenuItem.Name = "添加到团号ToolStripMenuItem";
            this.添加到团号ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加到团号ToolStripMenuItem.Text = "添加到已有团号";
            this.添加到团号ToolStripMenuItem.Click += new System.EventHandler(this.添加到团号ToolStripMenuItem_Click);
            // 
            // 生成报表ToolStripMenuItem
            // 
            this.生成报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.外领担保函ToolStripMenuItem,
            this.人申请表ToolStripMenuItem,
            this.机票报表ToolStripMenuItem});
            this.生成报表ToolStripMenuItem.Name = "生成报表ToolStripMenuItem";
            this.生成报表ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.生成报表ToolStripMenuItem.Text = "生成报表";
            // 
            // 外领担保函ToolStripMenuItem
            // 
            this.外领担保函ToolStripMenuItem.Name = "外领担保函ToolStripMenuItem";
            this.外领担保函ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.外领担保函ToolStripMenuItem.Text = "外领担保函";
            this.外领担保函ToolStripMenuItem.Click += new System.EventHandler(this.外领担保函ToolStripMenuItem_Click);
            // 
            // 人申请表ToolStripMenuItem
            // 
            this.人申请表ToolStripMenuItem.Name = "人申请表ToolStripMenuItem";
            this.人申请表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.人申请表ToolStripMenuItem.Text = "8人申请表";
            this.人申请表ToolStripMenuItem.Click += new System.EventHandler(this.人申请表ToolStripMenuItem_Click);
            // 
            // 机票报表ToolStripMenuItem
            // 
            this.机票报表ToolStripMenuItem.Name = "机票报表ToolStripMenuItem";
            this.机票报表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.机票报表ToolStripMenuItem.Text = "机票报表";
            this.机票报表ToolStripMenuItem.Click += new System.EventHandler(this.机票报表ToolStripMenuItem_Click);
            // 
            // 导出图像ToolStripMenuItem
            // 
            this.导出图像ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.护照图像ToolStripMenuItem,
            this.头像ToolStripMenuItem,
            this.护照红外图像ToolStripMenuItem,
            this.全部ToolStripMenuItem});
            this.导出图像ToolStripMenuItem.Name = "导出图像ToolStripMenuItem";
            this.导出图像ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.导出图像ToolStripMenuItem.Text = "导出图像";
            // 
            // 护照图像ToolStripMenuItem
            // 
            this.护照图像ToolStripMenuItem.Name = "护照图像ToolStripMenuItem";
            this.护照图像ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.护照图像ToolStripMenuItem.Text = "护照图像";
            this.护照图像ToolStripMenuItem.Click += new System.EventHandler(this.护照图像ToolStripMenuItem_Click);
            // 
            // 头像ToolStripMenuItem
            // 
            this.头像ToolStripMenuItem.Name = "头像ToolStripMenuItem";
            this.头像ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.头像ToolStripMenuItem.Text = "头像";
            this.头像ToolStripMenuItem.Click += new System.EventHandler(this.头像ToolStripMenuItem_Click);
            // 
            // 护照红外图像ToolStripMenuItem
            // 
            this.护照红外图像ToolStripMenuItem.Name = "护照红外图像ToolStripMenuItem";
            this.护照红外图像ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.护照红外图像ToolStripMenuItem.Text = "护照红外图像";
            this.护照红外图像ToolStripMenuItem.Visible = false;
            this.护照红外图像ToolStripMenuItem.Click += new System.EventHandler(this.护照红外图像ToolStripMenuItem_Click);
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.全部ToolStripMenuItem.Text = "全部";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // bgWorkerLoadData
            // 
            this.bgWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerLoadData_DoWork);
            this.bgWorkerLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerLoadData_ProgressChanged);
            this.bgWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerLoadData_RunWorkerCompleted);
            // 
            // FrmVisaInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 623);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmVisaInfoManage";
            this.Text = "签证信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVisaInfoManage_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelDgv.ResumeLayout(false);
            this.panelBars.ResumeLayout(false);
            this.panelSerachBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchEntryTimeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.cmsDgvRb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private DevComponents.DotNetBar.PanelEx panelMain;
        private System.Windows.Forms.ContextMenuStrip cmsDgvRb;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodeShow;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodeBatchGenerate;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodeBatchPrint;
        private System.Windows.Forms.ToolStripMenuItem cmsItemQRCodePrint;
        private System.Windows.Forms.ToolStripMenuItem cmsItemRefreshState;
        private System.Windows.Forms.ToolStripMenuItem cmsItemTypeInInfo;
        private System.Windows.Forms.ToolStripMenuItem cmsItemSetGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishName;
        private System.Windows.Forms.DataGridViewImageColumn QRCodeImage;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Types;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisaInfo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visa_id;
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
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.PanelEx panelDgv;
        private DevComponents.DotNetBar.PanelEx panelBars;
        private DevComponents.DotNetBar.PanelEx panelSerachBar;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchPassportNo;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.ButtonX btnShowAll;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchName;
        private DevComponents.DotNetBar.LabelX lbSchName;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtSchEntryTimeTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtSchEntryTimeFrom;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSchGroupNo;
        private DevComponents.DotNetBar.LabelX lb1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbDisplayType;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.ButtonX btnClearSchConditions;
        private DevComponents.DotNetBar.Controls.CircularProgress progressLoading;
        private System.ComponentModel.BackgroundWorker bgWorkerLoadData;
        private System.Windows.Forms.ToolStripMenuItem 添加到团号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外领担保函ToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX btnShowToday;
        private System.Windows.Forms.ToolStripMenuItem 人申请表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 机票报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 护照图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 头像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 护照红外图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountry;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}

