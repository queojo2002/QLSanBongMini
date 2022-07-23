
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_KV_SanBong_ChinhSua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_KV_SanBong_ChinhSua));
            this.nudGiaTien_KVSB = new System.Windows.Forms.NumericUpDown();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtTen_KVSB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIDKVSB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien_KVSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen_KVSB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKVSB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGiaTien_KVSB
            // 
            this.nudGiaTien_KVSB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGiaTien_KVSB.Location = new System.Drawing.Point(185, 72);
            this.nudGiaTien_KVSB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudGiaTien_KVSB.Name = "nudGiaTien_KVSB";
            this.nudGiaTien_KVSB.Size = new System.Drawing.Size(310, 25);
            this.nudGiaTien_KVSB.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(342, 103);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Appearance.Options.UseFont = true;
            this.btnChinhSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnChinhSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChinhSua.ImageOptions.SvgImage")));
            this.btnChinhSua.Location = new System.Drawing.Point(185, 103);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(150, 40);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // txtTen_KVSB
            // 
            this.txtTen_KVSB.Location = new System.Drawing.Point(185, 42);
            this.txtTen_KVSB.Name = "txtTen_KVSB";
            this.txtTen_KVSB.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen_KVSB.Properties.Appearance.Options.UseFont = true;
            this.txtTen_KVSB.Size = new System.Drawing.Size(310, 24);
            this.txtTen_KVSB.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(167, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Giá tiền khu vực sân bóng: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(167, 24);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tên khu vực sân bóng: ";
            // 
            // txtIDKVSB
            // 
            this.txtIDKVSB.Location = new System.Drawing.Point(185, 12);
            this.txtIDKVSB.Name = "txtIDKVSB";
            this.txtIDKVSB.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKVSB.Properties.Appearance.Options.UseFont = true;
            this.txtIDKVSB.Properties.ReadOnly = true;
            this.txtIDKVSB.Size = new System.Drawing.Size(310, 24);
            this.txtIDKVSB.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 24);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "ID khu vực sân bóng: ";
            // 
            // frmQuanLy_KV_SanBong_ChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 151);
            this.Controls.Add(this.txtIDKVSB);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.nudGiaTien_KVSB);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.txtTen_KVSB);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = global::QLSanBongMini_Final.Properties.Resources.sanbong;
            this.MaximizeBox = false;
            this.Name = "frmQuanLy_KV_SanBong_ChinhSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa khu vực sân bóng";
            this.Load += new System.EventHandler(this.frmQuanLy_SanBong_ChinhSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTien_KVSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen_KVSB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKVSB.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGiaTien_KVSB;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnChinhSua;
        private DevExpress.XtraEditors.TextEdit txtTen_KVSB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIDKVSB;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}