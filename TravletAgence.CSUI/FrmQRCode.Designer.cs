namespace TravletAgence.CSUI
{
    partial class FrmQRCode
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnSavePic = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateQRCode = new DevComponents.DotNetBar.ButtonX();
            this.txtQRCodeInfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnPrint);
            this.panelEx1.Controls.Add(this.btnSavePic);
            this.panelEx1.Controls.Add(this.btnUpdateQRCode);
            this.panelEx1.Controls.Add(this.txtQRCodeInfo);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.picQRCode);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(365, 188);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Location = new System.Drawing.Point(183, 157);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印二维码";
            // 
            // btnSavePic
            // 
            this.btnSavePic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSavePic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSavePic.Location = new System.Drawing.Point(264, 128);
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(83, 23);
            this.btnSavePic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSavePic.TabIndex = 4;
            this.btnSavePic.Text = "保存到图像";
            // 
            // btnUpdateQRCode
            // 
            this.btnUpdateQRCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateQRCode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateQRCode.Location = new System.Drawing.Point(183, 128);
            this.btnUpdateQRCode.Name = "btnUpdateQRCode";
            this.btnUpdateQRCode.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateQRCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateQRCode.TabIndex = 3;
            this.btnUpdateQRCode.Text = "刷新二维码";
            this.btnUpdateQRCode.Click += new System.EventHandler(this.btnUpdateQRCode_Click);
            // 
            // txtQRCodeInfo
            // 
            // 
            // 
            // 
            this.txtQRCodeInfo.Border.Class = "TextBoxBorder";
            this.txtQRCodeInfo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQRCodeInfo.Location = new System.Drawing.Point(183, 50);
            this.txtQRCodeInfo.Multiline = true;
            this.txtQRCodeInfo.Name = "txtQRCodeInfo";
            this.txtQRCodeInfo.PreventEnterBeep = true;
            this.txtQRCodeInfo.Size = new System.Drawing.Size(164, 69);
            this.txtQRCodeInfo.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(183, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 32);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "二维码中信息:";
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(12, 11);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(165, 165);
            this.picQRCode.TabIndex = 0;
            this.picQRCode.TabStop = false;
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 188);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQRCode";
            this.Text = "签证信息二维码";
            this.Load += new System.EventHandler(this.FrmQRCode_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.PictureBox picQRCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQRCodeInfo;
        private DevComponents.DotNetBar.ButtonX btnUpdateQRCode;
        private DevComponents.DotNetBar.ButtonX btnSavePic;
        private DevComponents.DotNetBar.ButtonX btnPrint;

    }
}