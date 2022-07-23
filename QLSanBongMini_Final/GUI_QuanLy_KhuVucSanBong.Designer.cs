
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_KV_SanBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_KV_SanBong));
            this.gcViewKVSB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pc_bottom = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.pc_fill = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcViewKVSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_bottom)).BeginInit();
            this.pc_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_fill)).BeginInit();
            this.pc_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcViewKVSB
            // 
            this.gcViewKVSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcViewKVSB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcViewKVSB.Location = new System.Drawing.Point(2, 2);
            this.gcViewKVSB.MainView = this.gridView1;
            this.gcViewKVSB.Name = "gcViewKVSB";
            this.gcViewKVSB.Size = new System.Drawing.Size(1088, 508);
            this.gcViewKVSB.TabIndex = 0;
            this.gcViewKVSB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.FontSizeDelta = 1;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gcViewKVSB;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pc_bottom
            // 
            this.pc_bottom.Controls.Add(this.btnXoa);
            this.pc_bottom.Controls.Add(this.btnChinhSua);
            this.pc_bottom.Controls.Add(this.btnThem);
            this.pc_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pc_bottom.Location = new System.Drawing.Point(0, 512);
            this.pc_bottom.Name = "pc_bottom";
            this.pc_bottom.Size = new System.Drawing.Size(1092, 64);
            this.pc_bottom.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Location = new System.Drawing.Point(910, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(177, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChinhSua.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Appearance.Options.UseFont = true;
            this.btnChinhSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnChinhSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChinhSua.ImageOptions.SvgImage")));
            this.btnChinhSua.Location = new System.Drawing.Point(727, 5);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(177, 53);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(544, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(177, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pc_fill
            // 
            this.pc_fill.Controls.Add(this.gcViewKVSB);
            this.pc_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pc_fill.Location = new System.Drawing.Point(0, 0);
            this.pc_fill.Name = "pc_fill";
            this.pc_fill.Size = new System.Drawing.Size(1092, 512);
            this.pc_fill.TabIndex = 2;
            // 
            // frmQuanLy_KV_SanBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 576);
            this.Controls.Add(this.pc_fill);
            this.Controls.Add(this.pc_bottom);
            this.IconOptions.Image = global::QLSanBongMini_Final.Properties.Resources.sanbong;
            this.Name = "frmQuanLy_KV_SanBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khu vực sân bóng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_SanBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcViewKVSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_bottom)).EndInit();
            this.pc_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_fill)).EndInit();
            this.pc_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcViewKVSB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pc_bottom;
        private DevExpress.XtraEditors.PanelControl pc_fill;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnChinhSua;
    }
}