namespace TravletAgence.CSUI.FrmSub
{
    partial class FrmTodaySubmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodaySubmit));
            this.panelDgv = new DevComponents.DotNetBar.PanelEx();
            this.rowMergeView1 = new RowMergeView();
            this.panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.btnGetTodaySubmitExcel = new DevComponents.DotNetBar.ButtonX();
            this.cmsDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导出报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个签意见书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.金桥大名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人申请表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisaInfo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visa_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.cmsDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDgv
            // 
            this.panelDgv.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelDgv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDgv.Controls.Add(this.rowMergeView1);
            this.panelDgv.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgv.Location = new System.Drawing.Point(0, 0);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(896, 424);
            this.panelDgv.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDgv.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelDgv.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelDgv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelDgv.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelDgv.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelDgv.Style.GradientAngle = 90;
            this.panelDgv.TabIndex = 1;
            // 
            // rowMergeView1
            // 
            this.rowMergeView1.AllowUserToAddRows = false;
            this.rowMergeView1.AllowUserToDeleteRows = false;
            this.rowMergeView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowMergeView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Name,
            this.IssuePlace,
            this.Residence,
            this.DepartureType,
            this.ReturnTime,
            this.Remark,
            this.Identification,
            this.VisaInfo_id,
            this.Visa_Id});
            this.rowMergeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowMergeView1.Location = new System.Drawing.Point(0, 0);
            this.rowMergeView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.rowMergeView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rowMergeView1.MergeColumnNames")));
            this.rowMergeView1.Name = "rowMergeView1";
            this.rowMergeView1.ReadOnly = true;
            this.rowMergeView1.RowTemplate.Height = 23;
            this.rowMergeView1.Size = new System.Drawing.Size(896, 424);
            this.rowMergeView1.TabIndex = 0;
            this.rowMergeView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rowMergeView1_CellMouseClick);
            this.rowMergeView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.rowMergeView1_RowsAdded);
            // 
            // panelBottom
            // 
            this.panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBottom.Controls.Add(this.btnGetTodaySubmitExcel);
            this.panelBottom.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 385);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(896, 39);
            this.panelBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBottom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBottom.Style.GradientAngle = 90;
            this.panelBottom.TabIndex = 5;
            // 
            // btnGetTodaySubmitExcel
            // 
            this.btnGetTodaySubmitExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGetTodaySubmitExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGetTodaySubmitExcel.Location = new System.Drawing.Point(370, 4);
            this.btnGetTodaySubmitExcel.Name = "btnGetTodaySubmitExcel";
            this.btnGetTodaySubmitExcel.Size = new System.Drawing.Size(137, 23);
            this.btnGetTodaySubmitExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGetTodaySubmitExcel.TabIndex = 0;
            this.btnGetTodaySubmitExcel.Text = "生成今日送签情况报表";
            this.btnGetTodaySubmitExcel.Click += new System.EventHandler(this.buttonGetTodaySubmitExcel_Click);
            // 
            // cmsDgv
            // 
            this.cmsDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出报表ToolStripMenuItem});
            this.cmsDgv.Name = "cmsDgv";
            this.cmsDgv.Size = new System.Drawing.Size(125, 26);
            // 
            // 导出报表ToolStripMenuItem
            // 
            this.导出报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个签意见书ToolStripMenuItem,
            this.金桥大名单ToolStripMenuItem,
            this.人申请表ToolStripMenuItem});
            this.导出报表ToolStripMenuItem.Name = "导出报表ToolStripMenuItem";
            this.导出报表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出报表ToolStripMenuItem.Text = "导出报表";
            // 
            // 个签意见书ToolStripMenuItem
            // 
            this.个签意见书ToolStripMenuItem.Name = "个签意见书ToolStripMenuItem";
            this.个签意见书ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.个签意见书ToolStripMenuItem.Text = "个签意见书";
            this.个签意见书ToolStripMenuItem.Click += new System.EventHandler(this.个签意见书ToolStripMenuItem_Click);
            // 
            // 金桥大名单ToolStripMenuItem
            // 
            this.金桥大名单ToolStripMenuItem.Name = "金桥大名单ToolStripMenuItem";
            this.金桥大名单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.金桥大名单ToolStripMenuItem.Text = "金桥大名单";
            this.金桥大名单ToolStripMenuItem.Click += new System.EventHandler(this.金桥大名单ToolStripMenuItem_Click);
            // 
            // 人申请表ToolStripMenuItem
            // 
            this.人申请表ToolStripMenuItem.Name = "人申请表ToolStripMenuItem";
            this.人申请表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.人申请表ToolStripMenuItem.Text = "8人申请表";
            this.人申请表ToolStripMenuItem.Click += new System.EventHandler(this.人申请表ToolStripMenuItem_Click);
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "Name";
            this._Name.HeaderText = "姓名";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            // 
            // IssuePlace
            // 
            this.IssuePlace.DataPropertyName = "IssuePlace";
            this.IssuePlace.HeaderText = "签发地";
            this.IssuePlace.Name = "IssuePlace";
            this.IssuePlace.ReadOnly = true;
            // 
            // Residence
            // 
            this.Residence.DataPropertyName = "Residence";
            this.Residence.HeaderText = "居住地";
            this.Residence.Name = "Residence";
            this.Residence.ReadOnly = true;
            // 
            // DepartureType
            // 
            this.DepartureType.DataPropertyName = "DepartureType";
            this.DepartureType.HeaderText = "签证类型";
            this.DepartureType.Name = "DepartureType";
            this.DepartureType.ReadOnly = true;
            // 
            // ReturnTime
            // 
            this.ReturnTime.DataPropertyName = "ReturnTime";
            this.ReturnTime.HeaderText = "归国时间";
            this.ReturnTime.Name = "ReturnTime";
            this.ReturnTime.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "关系";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // Identification
            // 
            this.Identification.DataPropertyName = "Identification";
            this.Identification.HeaderText = "";
            this.Identification.Name = "Identification";
            this.Identification.ReadOnly = true;
            // 
            // VisaInfo_id
            // 
            this.VisaInfo_id.DataPropertyName = "VisaInfo_id";
            this.VisaInfo_id.HeaderText = "VisaInfo_id";
            this.VisaInfo_id.Name = "VisaInfo_id";
            this.VisaInfo_id.ReadOnly = true;
            this.VisaInfo_id.Visible = false;
            // 
            // Visa_Id
            // 
            this.Visa_Id.DataPropertyName = "Visa_Id";
            this.Visa_Id.HeaderText = "Visa_Id";
            this.Visa_Id.Name = "Visa_Id";
            this.Visa_Id.ReadOnly = true;
            this.Visa_Id.Visible = false;
            // 
            // FrmTodaySubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 424);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelDgv);
            this.Name = "FrmTodaySubmit";
            this.Text = "今日送签情况";
            this.Load += new System.EventHandler(this.FrmTodaySubmit_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.cmsDgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RowMergeView rowMergeView1;
        private DevComponents.DotNetBar.PanelEx panelDgv;
        private DevComponents.DotNetBar.PanelEx panelBottom;
        private DevComponents.DotNetBar.ButtonX btnGetTodaySubmitExcel;
        private System.Windows.Forms.ContextMenuStrip cmsDgv;
        private System.Windows.Forms.ToolStripMenuItem 导出报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个签意见书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 金桥大名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人申请表ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identification;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisaInfo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visa_Id;
    }
}