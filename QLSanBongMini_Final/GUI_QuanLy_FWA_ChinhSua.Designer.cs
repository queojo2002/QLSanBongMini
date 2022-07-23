
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_FWA_Chinhsua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_FWA_Chinhsua));
            this.cbeLoaiFWA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblLoaiFWA = new DevExpress.XtraEditors.LabelControl();
            this.lblTenFWA = new DevExpress.XtraEditors.LabelControl();
            this.panel_image = new DevExpress.XtraEditors.PanelControl();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.panel_lbl_Tenphukien = new DevExpress.XtraEditors.LabelControl();
            this.panel_lbl_Giatien = new DevExpress.XtraEditors.LabelControl();
            this.lblClickVaoHinh = new DevExpress.XtraEditors.LabelControl();
            this.lblGiaTien = new DevExpress.XtraEditors.LabelControl();
            this.numricGiaTien = new System.Windows.Forms.NumericUpDown();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_image)).BeginInit();
            this.panel_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbeLoaiFWA
            // 
            this.cbeLoaiFWA.EditValue = "Phụ kiện";
            this.cbeLoaiFWA.Location = new System.Drawing.Point(221, 82);
            this.cbeLoaiFWA.Name = "cbeLoaiFWA";
            this.cbeLoaiFWA.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeLoaiFWA.Properties.Appearance.Options.UseFont = true;
            this.cbeLoaiFWA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLoaiFWA.Properties.Items.AddRange(new object[] {
            "Phụ kiện",
            "Nước uống",
            "Thức ăn"});
            this.cbeLoaiFWA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeLoaiFWA.Size = new System.Drawing.Size(254, 28);
            this.cbeLoaiFWA.TabIndex = 21;
            // 
            // lblLoaiFWA
            // 
            this.lblLoaiFWA.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiFWA.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiFWA.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblLoaiFWA.Appearance.Options.UseBackColor = true;
            this.lblLoaiFWA.Appearance.Options.UseFont = true;
            this.lblLoaiFWA.Appearance.Options.UseForeColor = true;
            this.lblLoaiFWA.Appearance.Options.UseTextOptions = true;
            this.lblLoaiFWA.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLoaiFWA.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLoaiFWA.Location = new System.Drawing.Point(12, 81);
            this.lblLoaiFWA.Name = "lblLoaiFWA";
            this.lblLoaiFWA.Size = new System.Drawing.Size(203, 29);
            this.lblLoaiFWA.TabIndex = 28;
            this.lblLoaiFWA.Text = "Loại FWA cần thêm: ";
            // 
            // lblTenFWA
            // 
            this.lblTenFWA.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTenFWA.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenFWA.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTenFWA.Appearance.Options.UseBackColor = true;
            this.lblTenFWA.Appearance.Options.UseFont = true;
            this.lblTenFWA.Appearance.Options.UseForeColor = true;
            this.lblTenFWA.Appearance.Options.UseTextOptions = true;
            this.lblTenFWA.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTenFWA.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTenFWA.Location = new System.Drawing.Point(12, 12);
            this.lblTenFWA.Name = "lblTenFWA";
            this.lblTenFWA.Size = new System.Drawing.Size(203, 28);
            this.lblTenFWA.TabIndex = 25;
            this.lblTenFWA.Text = "Tên FWA: ";
            // 
            // panel_image
            // 
            this.panel_image.Controls.Add(this.pic_1);
            this.panel_image.Controls.Add(this.panel_lbl_Tenphukien);
            this.panel_image.Controls.Add(this.panel_lbl_Giatien);
            this.panel_image.Location = new System.Drawing.Point(221, 116);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(256, 256);
            this.panel_image.TabIndex = 22;
            // 
            // pic_1
            // 
            this.pic_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_1.Location = new System.Drawing.Point(2, 44);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(252, 162);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            this.pic_1.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // panel_lbl_Tenphukien
            // 
            this.panel_lbl_Tenphukien.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel_lbl_Tenphukien.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_lbl_Tenphukien.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_lbl_Tenphukien.Appearance.Options.UseBackColor = true;
            this.panel_lbl_Tenphukien.Appearance.Options.UseFont = true;
            this.panel_lbl_Tenphukien.Appearance.Options.UseForeColor = true;
            this.panel_lbl_Tenphukien.Appearance.Options.UseTextOptions = true;
            this.panel_lbl_Tenphukien.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.panel_lbl_Tenphukien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.panel_lbl_Tenphukien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_lbl_Tenphukien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.panel_lbl_Tenphukien.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel_lbl_Tenphukien.Location = new System.Drawing.Point(2, 2);
            this.panel_lbl_Tenphukien.Name = "panel_lbl_Tenphukien";
            this.panel_lbl_Tenphukien.Size = new System.Drawing.Size(252, 42);
            this.panel_lbl_Tenphukien.TabIndex = 4;
            this.panel_lbl_Tenphukien.Text = "Tên FWA";
            // 
            // panel_lbl_Giatien
            // 
            this.panel_lbl_Giatien.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel_lbl_Giatien.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_lbl_Giatien.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_lbl_Giatien.Appearance.Options.UseBackColor = true;
            this.panel_lbl_Giatien.Appearance.Options.UseFont = true;
            this.panel_lbl_Giatien.Appearance.Options.UseForeColor = true;
            this.panel_lbl_Giatien.Appearance.Options.UseTextOptions = true;
            this.panel_lbl_Giatien.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.panel_lbl_Giatien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.panel_lbl_Giatien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_lbl_Giatien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.panel_lbl_Giatien.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel_lbl_Giatien.ImageOptions.Image = global::QLSanBongMini_Final.Properties.Resources.money1;
            this.panel_lbl_Giatien.Location = new System.Drawing.Point(2, 206);
            this.panel_lbl_Giatien.Name = "panel_lbl_Giatien";
            this.panel_lbl_Giatien.Size = new System.Drawing.Size(252, 48);
            this.panel_lbl_Giatien.TabIndex = 2;
            this.panel_lbl_Giatien.Text = "Giá Tiền";
            // 
            // lblClickVaoHinh
            // 
            this.lblClickVaoHinh.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblClickVaoHinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickVaoHinh.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblClickVaoHinh.Appearance.Options.UseBackColor = true;
            this.lblClickVaoHinh.Appearance.Options.UseFont = true;
            this.lblClickVaoHinh.Appearance.Options.UseForeColor = true;
            this.lblClickVaoHinh.Appearance.Options.UseTextOptions = true;
            this.lblClickVaoHinh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblClickVaoHinh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClickVaoHinh.Location = new System.Drawing.Point(12, 116);
            this.lblClickVaoHinh.Name = "lblClickVaoHinh";
            this.lblClickVaoHinh.Size = new System.Drawing.Size(203, 256);
            this.lblClickVaoHinh.TabIndex = 27;
            this.lblClickVaoHinh.Text = "Click vào để chọn hình ảnh";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblGiaTien.Appearance.Options.UseBackColor = true;
            this.lblGiaTien.Appearance.Options.UseFont = true;
            this.lblGiaTien.Appearance.Options.UseForeColor = true;
            this.lblGiaTien.Appearance.Options.UseTextOptions = true;
            this.lblGiaTien.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblGiaTien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGiaTien.Location = new System.Drawing.Point(12, 46);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(203, 29);
            this.lblGiaTien.TabIndex = 26;
            this.lblGiaTien.Text = "Giá tiền: ";
            // 
            // numricGiaTien
            // 
            this.numricGiaTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numricGiaTien.Location = new System.Drawing.Point(221, 46);
            this.numricGiaTien.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numricGiaTien.Name = "numricGiaTien";
            this.numricGiaTien.Size = new System.Drawing.Size(254, 29);
            this.numricGiaTien.TabIndex = 20;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(221, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(254, 28);
            this.txtTen.TabIndex = 19;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEdit.Location = new System.Drawing.Point(12, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(463, 45);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Chỉnh Sửa !!!";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmQuanLy_FWA_Chinhsua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 430);
            this.Controls.Add(this.cbeLoaiFWA);
            this.Controls.Add(this.lblLoaiFWA);
            this.Controls.Add(this.lblTenFWA);
            this.Controls.Add(this.panel_image);
            this.Controls.Add(this.lblClickVaoHinh);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.numricGiaTien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::QLSanBongMini_Final.Properties.Resources.food_image_128;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmQuanLy_FWA_Chinhsua.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLy_FWA_Chinhsua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa FWA";
            this.Load += new System.EventHandler(this.frmQuanLy_FWA_Chinhsua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_image)).EndInit();
            this.panel_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbeLoaiFWA;
        private DevExpress.XtraEditors.LabelControl lblLoaiFWA;
        private DevExpress.XtraEditors.LabelControl lblTenFWA;
        private DevExpress.XtraEditors.PanelControl panel_image;
        private System.Windows.Forms.PictureBox pic_1;
        private DevExpress.XtraEditors.LabelControl panel_lbl_Tenphukien;
        private DevExpress.XtraEditors.LabelControl panel_lbl_Giatien;
        private DevExpress.XtraEditors.LabelControl lblClickVaoHinh;
        private DevExpress.XtraEditors.LabelControl lblGiaTien;
        private System.Windows.Forms.NumericUpDown numricGiaTien;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
    }
}