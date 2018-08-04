namespace BTL
{
    partial class frmThemMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMonHoc = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoTiet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã môn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMonHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMonHoc.Image")));
            this.btnThemMonHoc.Location = new System.Drawing.Point(126, 181);
            this.btnThemMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(129, 38);
            this.btnThemMonHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemMonHoc.TabIndex = 4;
            this.btnThemMonHoc.Text = "Thêm môn học";
            this.btnThemMonHoc.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên môn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tiết";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaMon
            // 
            // 
            // 
            // 
            this.txtMaMon.Border.Class = "TextBoxBorder";
            this.txtMaMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaMon.Border.PaddingBottom = 3;
            this.txtMaMon.Border.PaddingTop = 10;
            this.txtMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(126, 38);
            this.txtMaMon.Multiline = true;
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(175, 34);
            this.txtMaMon.TabIndex = 0;
            // 
            // txtTenMon
            // 
            // 
            // 
            // 
            this.txtTenMon.Border.Class = "TextBoxBorder";
            this.txtTenMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenMon.Border.PaddingBottom = 3;
            this.txtTenMon.Border.PaddingTop = 10;
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(126, 82);
            this.txtTenMon.Multiline = true;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(175, 34);
            this.txtTenMon.TabIndex = 1;
            // 
            // txtSoTiet
            // 
            // 
            // 
            // 
            this.txtSoTiet.Border.Class = "TextBoxBorder";
            this.txtSoTiet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoTiet.Border.PaddingBottom = 3;
            this.txtSoTiet.Border.PaddingTop = 10;
            this.txtSoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTiet.Location = new System.Drawing.Point(126, 125);
            this.txtSoTiet.Multiline = true;
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(175, 34);
            this.txtSoTiet.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHuy.Location = new System.Drawing.Point(263, 181);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(38, 38);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 8;
            this.btnHuy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnHuy);
            this.panelEx1.Controls.Add(this.txtSoTiet);
            this.panelEx1.Controls.Add(this.txtTenMon);
            this.panelEx1.Controls.Add(this.txtMaMon);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.btnThemMonHoc);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(344, 291);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // frmThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 291);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmThemMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm môn học";
            this.Load += new System.EventHandler(this.frmThemMonHoc_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnThemMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoTiet;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}