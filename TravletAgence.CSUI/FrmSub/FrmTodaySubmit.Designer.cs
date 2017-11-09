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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodaySubmit));
            this.panelDgv = new DevComponents.DotNetBar.PanelEx();
            this.panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.rowMergeView1 = new RowMergeView();
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
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).BeginInit();
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
            // panelBottom
            // 
            this.panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBottom.Controls.Add(this.buttonX1);
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
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(370, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(137, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "生成今日送签情况报表";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
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
            this.rowMergeView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.rowMergeView1_RowsAdded);
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
            this.Residence.HeaderText = "签发地";
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
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RowMergeView rowMergeView1;
        private DevComponents.DotNetBar.PanelEx panelDgv;
        private DevComponents.DotNetBar.PanelEx panelBottom;
        private DevComponents.DotNetBar.ButtonX buttonX1;
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