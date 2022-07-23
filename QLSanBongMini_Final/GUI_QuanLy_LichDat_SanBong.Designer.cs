
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_LichDat_SanBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_LichDat_SanBong));
            this.gcViewLDSB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pc_bottom = new DevExpress.XtraEditors.PanelControl();
            this.btnXemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.pc_fill = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcViewLDSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_bottom)).BeginInit();
            this.pc_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_fill)).BeginInit();
            this.pc_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcViewLDSB
            // 
            this.gcViewLDSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcViewLDSB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcViewLDSB.Location = new System.Drawing.Point(2, 2);
            this.gcViewLDSB.MainView = this.gridView1;
            this.gcViewLDSB.Name = "gcViewLDSB";
            this.gcViewLDSB.Size = new System.Drawing.Size(897, 515);
            this.gcViewLDSB.TabIndex = 0;
            this.gcViewLDSB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.FontSizeDelta = 2;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gcViewLDSB;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pc_bottom
            // 
            this.pc_bottom.Controls.Add(this.btnXemChiTiet);
            this.pc_bottom.Controls.Add(this.btnXoa);
            this.pc_bottom.Controls.Add(this.btnThem);
            this.pc_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pc_bottom.Location = new System.Drawing.Point(0, 465);
            this.pc_bottom.Name = "pc_bottom";
            this.pc_bottom.Size = new System.Drawing.Size(901, 54);
            this.pc_bottom.TabIndex = 3;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXemChiTiet.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Appearance.Options.UseFont = true;
            this.btnXemChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTiet.ImageOptions.Image")));
            this.btnXemChiTiet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXemChiTiet.Location = new System.Drawing.Point(425, 5);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(153, 44);
            this.btnXemChiTiet.TabIndex = 3;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Location = new System.Drawing.Point(743, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 43);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(584, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pc_fill
            // 
            this.pc_fill.Controls.Add(this.gcViewLDSB);
            this.pc_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pc_fill.Location = new System.Drawing.Point(0, 0);
            this.pc_fill.Name = "pc_fill";
            this.pc_fill.Size = new System.Drawing.Size(901, 519);
            this.pc_fill.TabIndex = 4;
            // 
            // frmQuanLy_LichDat_SanBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 519);
            this.Controls.Add(this.pc_bottom);
            this.Controls.Add(this.pc_fill);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmQuanLy_LichDat_SanBong.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLy_LichDat_SanBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch đặt sân bóng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_LichDat_SanBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcViewLDSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_bottom)).EndInit();
            this.pc_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_fill)).EndInit();
            this.pc_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcViewLDSB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pc_bottom;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl pc_fill;
        private DevExpress.XtraEditors.SimpleButton btnXemChiTiet;
    }
}