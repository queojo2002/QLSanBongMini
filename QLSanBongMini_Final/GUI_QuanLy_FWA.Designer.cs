
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_FWA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_FWA));
            this.panel_top = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbeLoaiFWA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNhaplai = new DevExpress.XtraEditors.SimpleButton();
            this.panel_image = new DevExpress.XtraEditors.PanelControl();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.panel_lbl_Tenphukien = new DevExpress.XtraEditors.LabelControl();
            this.panel_lbl_Giatien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.numricGiaTien = new System.Windows.Forms.NumericUpDown();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.flow_ShowFWA = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_fill = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_image)).BeginInit();
            this.panel_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).BeginInit();
            this.panel_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.groupControl1);
            this.panel_top.Controls.Add(this.groupControl2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(474, 829);
            this.panel_top.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbeLoaiFWA);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnNhaplai);
            this.groupControl1.Controls.Add(this.panel_image);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.numricGiaTien);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 230);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(470, 537);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thêm Fwa";
            // 
            // cbeLoaiFWA
            // 
            this.cbeLoaiFWA.EditValue = "Nước uống";
            this.cbeLoaiFWA.Location = new System.Drawing.Point(205, 96);
            this.cbeLoaiFWA.Name = "cbeLoaiFWA";
            this.cbeLoaiFWA.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeLoaiFWA.Properties.Appearance.Options.UseFont = true;
            this.cbeLoaiFWA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLoaiFWA.Properties.Items.AddRange(new object[] {
            "Nước uống",
            "Phụ kiện",
            "Thức ăn"});
            this.cbeLoaiFWA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeLoaiFWA.Size = new System.Drawing.Size(254, 28);
            this.cbeLoaiFWA.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(5, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(194, 29);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Loại fwa cần thêm: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(5, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 28);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên fwa: ";
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaplai.Appearance.Options.UseFont = true;
            this.btnNhaplai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaplai.ImageOptions.Image")));
            this.btnNhaplai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNhaplai.Location = new System.Drawing.Point(267, 487);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(194, 45);
            this.btnNhaplai.TabIndex = 5;
            this.btnNhaplai.Text = "Nhập lại ";
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // panel_image
            // 
            this.panel_image.Controls.Add(this.pic_1);
            this.panel_image.Controls.Add(this.panel_lbl_Tenphukien);
            this.panel_image.Controls.Add(this.panel_lbl_Giatien);
            this.panel_image.Location = new System.Drawing.Point(205, 130);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(256, 349);
            this.panel_image.TabIndex = 3;
            // 
            // pic_1
            // 
            this.pic_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_1.Location = new System.Drawing.Point(2, 44);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(252, 255);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            this.pic_1.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // panel_lbl_Tenphukien
            // 
            this.panel_lbl_Tenphukien.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel_lbl_Tenphukien.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_lbl_Tenphukien.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_lbl_Tenphukien.Appearance.Options.UseBackColor = true;
            this.panel_lbl_Tenphukien.Appearance.Options.UseFont = true;
            this.panel_lbl_Tenphukien.Appearance.Options.UseForeColor = true;
            this.panel_lbl_Tenphukien.Appearance.Options.UseTextOptions = true;
            this.panel_lbl_Tenphukien.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.panel_lbl_Tenphukien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.panel_lbl_Tenphukien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_lbl_Tenphukien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.panel_lbl_Tenphukien.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel_lbl_Tenphukien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("panel_lbl_Tenphukien.ImageOptions.SvgImage")));
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
            this.panel_lbl_Giatien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("panel_lbl_Giatien.ImageOptions.SvgImage")));
            this.panel_lbl_Giatien.Location = new System.Drawing.Point(2, 299);
            this.panel_lbl_Giatien.Name = "panel_lbl_Giatien";
            this.panel_lbl_Giatien.Size = new System.Drawing.Size(252, 48);
            this.panel_lbl_Giatien.TabIndex = 2;
            this.panel_lbl_Giatien.Text = "Giá Tiền";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(5, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(194, 254);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Click vào để chọn hình ảnh";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(5, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(194, 29);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Giá tiền: ";
            // 
            // numricGiaTien
            // 
            this.numricGiaTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numricGiaTien.Location = new System.Drawing.Point(205, 60);
            this.numricGiaTien.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numricGiaTien.Name = "numricGiaTien";
            this.numricGiaTien.Size = new System.Drawing.Size(254, 29);
            this.numricGiaTien.TabIndex = 2;
            this.numricGiaTien.ValueChanged += new System.EventHandler(this.numricGiaTien_ValueChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(205, 26);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(256, 28);
            this.txtTen.TabIndex = 1;
            this.txtTen.EditValueChanged += new System.EventHandler(this.txtTen_EditValueChanged_1);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.Location = new System.Drawing.Point(10, 485);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(251, 45);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm !!!";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(470, 228);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Xem fwa theo tùy chọn";
            // 
            // flow_ShowFWA
            // 
            this.flow_ShowFWA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_ShowFWA.Location = new System.Drawing.Point(2, 2);
            this.flow_ShowFWA.Name = "flow_ShowFWA";
            this.flow_ShowFWA.Size = new System.Drawing.Size(677, 825);
            this.flow_ShowFWA.TabIndex = 1;
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.flow_ShowFWA);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(474, 0);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(681, 829);
            this.panel_fill.TabIndex = 2;
            // 
            // frmQuanLy_FWA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 829);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_top);
            this.MaximizeBox = false;
            this.Name = "frmQuanLy_FWA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý fwa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_FWA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_image)).EndInit();
            this.panel_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numricGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).EndInit();
            this.panel_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_top;
        private DevExpress.XtraEditors.LabelControl panel_lbl_Giatien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panel_image;
        private DevExpress.XtraEditors.LabelControl panel_lbl_Tenphukien;
        private System.Windows.Forms.PictureBox pic_1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.FlowLayoutPanel flow_ShowFWA;
        private DevExpress.XtraEditors.PanelControl panel_fill;
        private System.Windows.Forms.NumericUpDown numricGiaTien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNhaplai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLoaiFWA;
    }
}