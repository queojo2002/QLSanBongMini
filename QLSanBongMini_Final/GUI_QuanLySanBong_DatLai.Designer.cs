
namespace QLSanBongMini_Final
{
    partial class frmDatlai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatlai));
            this.gcKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.btnThemKH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.cbeSDTKH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cbeTenKH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDatLai = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.lblGhiChu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            this.gcKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSDTKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Controls.Add(this.btnThemKH);
            this.gcKhachHang.Controls.Add(this.labelControl15);
            this.gcKhachHang.Controls.Add(this.cbeSDTKH);
            this.gcKhachHang.Controls.Add(this.labelControl14);
            this.gcKhachHang.Controls.Add(this.cbeTenKH);
            this.gcKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(637, 93);
            this.gcKhachHang.TabIndex = 11;
            this.gcKhachHang.Text = "Thông tin khách hàng đặt lại";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Appearance.Options.UseFont = true;
            this.btnThemKH.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThemKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKH.ImageOptions.SvgImage")));
            this.btnThemKH.Location = new System.Drawing.Point(455, 26);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(177, 58);
            this.btnThemKH.TabIndex = 14;
            this.btnThemKH.Text = "Thêm mới khách hàng";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(5, 58);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(145, 26);
            this.labelControl15.TabIndex = 13;
            this.labelControl15.Text = "SĐT khách hàng: ";
            // 
            // cbeSDTKH
            // 
            this.cbeSDTKH.Location = new System.Drawing.Point(154, 58);
            this.cbeSDTKH.Name = "cbeSDTKH";
            this.cbeSDTKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeSDTKH.Properties.Appearance.Options.UseFont = true;
            this.cbeSDTKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSDTKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeSDTKH.Size = new System.Drawing.Size(295, 26);
            this.cbeSDTKH.TabIndex = 3;
            this.cbeSDTKH.SelectedIndexChanged += new System.EventHandler(this.cbeSDTKH_SelectedIndexChanged);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseTextOptions = true;
            this.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Location = new System.Drawing.Point(5, 26);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(145, 26);
            this.labelControl14.TabIndex = 11;
            this.labelControl14.Text = "Tên khách hàng: ";
            // 
            // cbeTenKH
            // 
            this.cbeTenKH.Location = new System.Drawing.Point(154, 26);
            this.cbeTenKH.Name = "cbeTenKH";
            this.cbeTenKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeTenKH.Properties.Appearance.Options.UseFont = true;
            this.cbeTenKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeTenKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeTenKH.Size = new System.Drawing.Size(295, 26);
            this.cbeTenKH.TabIndex = 2;
            this.cbeTenKH.SelectedIndexChanged += new System.EventHandler(this.cbeTenKH_SelectedIndexChanged);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.Appearance.Options.UseFont = true;
            this.btnDatLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnDatLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDatLai.Location = new System.Drawing.Point(156, 132);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(476, 54);
            this.btnDatLai.TabIndex = 20;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(156, 100);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Properties.Appearance.Options.UseFont = true;
            this.txtGhiChu.Size = new System.Drawing.Size(476, 26);
            this.txtGhiChu.TabIndex = 19;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Appearance.Options.UseFont = true;
            this.lblGhiChu.Appearance.Options.UseTextOptions = true;
            this.lblGhiChu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblGhiChu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGhiChu.Location = new System.Drawing.Point(12, 99);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(145, 87);
            this.lblGhiChu.TabIndex = 18;
            this.lblGhiChu.Text = "Ghi chú: ";
            // 
            // frmDatlai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 191);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.gcKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDatlai.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmDatlai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lại";
            this.Load += new System.EventHandler(this.frmDatlai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            this.gcKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeSDTKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnThemKH;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSDTKH;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.ComboBoxEdit cbeTenKH;
        private DevExpress.XtraEditors.SimpleButton btnDatLai;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl lblGhiChu;
    }
}