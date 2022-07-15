
namespace QLSanBongMini_Final
{
    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.flpFWA = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFWA = new DevExpress.XtraEditors.PanelControl();
            this.panelFWA_top = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbeLoaiFWA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelFWA)).BeginInit();
            this.panelFWA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFWA_top)).BeginInit();
            this.panelFWA_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flpFWA
            // 
            this.flpFWA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFWA.Location = new System.Drawing.Point(2, 139);
            this.flpFWA.Name = "flpFWA";
            this.flpFWA.Size = new System.Drawing.Size(524, 502);
            this.flpFWA.TabIndex = 0;
            // 
            // panelFWA
            // 
            this.panelFWA.Controls.Add(this.flpFWA);
            this.panelFWA.Controls.Add(this.panelFWA_top);
            this.panelFWA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFWA.Location = new System.Drawing.Point(0, 0);
            this.panelFWA.Name = "panelFWA";
            this.panelFWA.Size = new System.Drawing.Size(528, 643);
            this.panelFWA.TabIndex = 1;
            // 
            // panelFWA_top
            // 
            this.panelFWA_top.Controls.Add(this.groupControl1);
            this.panelFWA_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFWA_top.Location = new System.Drawing.Point(2, 2);
            this.panelFWA_top.Name = "panelFWA_top";
            this.panelFWA_top.Size = new System.Drawing.Size(524, 137);
            this.panelFWA_top.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cbeLoaiFWA);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(520, 133);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Lọc fwa";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(328, 76);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(189, 41);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Xóa lọc !!!";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(136, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(189, 41);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Lọc !!!";
            // 
            // cbeLoaiFWA
            // 
            this.cbeLoaiFWA.EditValue = "Thức ăn";
            this.cbeLoaiFWA.Location = new System.Drawing.Point(136, 42);
            this.cbeLoaiFWA.Name = "cbeLoaiFWA";
            this.cbeLoaiFWA.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbeLoaiFWA.Properties.Appearance.Options.UseFont = true;
            this.cbeLoaiFWA.Properties.Appearance.Options.UseTextOptions = true;
            this.cbeLoaiFWA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbeLoaiFWA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLoaiFWA.Properties.Items.AddRange(new object[] {
            "Thức ăn",
            "Nước uống",
            "Phụ kiện"});
            this.cbeLoaiFWA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeLoaiFWA.Size = new System.Drawing.Size(381, 28);
            this.cbeLoaiFWA.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Lọc theo loại FWA:";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 643);
            this.Controls.Add(this.panelFWA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.money;
            this.MaximizeBox = false;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán sân bóng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelFWA)).EndInit();
            this.panelFWA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelFWA_top)).EndInit();
            this.panelFWA_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFWA;
        private DevExpress.XtraEditors.PanelControl panelFWA;
        private DevExpress.XtraEditors.PanelControl panelFWA_top;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLoaiFWA;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}