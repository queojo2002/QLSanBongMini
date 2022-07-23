
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_LichDat_SanBong_XemChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_LichDat_SanBong_XemChiTiet));
            this.grid_view_chitietlichdat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_chitietlichdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_view_chitietlichdat
            // 
            this.grid_view_chitietlichdat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_view_chitietlichdat.Location = new System.Drawing.Point(0, 0);
            this.grid_view_chitietlichdat.MainView = this.gridView1;
            this.grid_view_chitietlichdat.Name = "grid_view_chitietlichdat";
            this.grid_view_chitietlichdat.Size = new System.Drawing.Size(816, 341);
            this.grid_view_chitietlichdat.TabIndex = 0;
            this.grid_view_chitietlichdat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.FontSizeDelta = 1;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.grid_view_chitietlichdat;
            this.gridView1.Name = "gridView1";
            // 
            // frmQuanLy_LichDat_SanBong_XemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 341);
            this.Controls.Add(this.grid_view_chitietlichdat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmQuanLy_LichDat_SanBong_XemChiTiet.IconOptions.LargeImage")));
            this.Name = "frmQuanLy_LichDat_SanBong_XemChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem chi tiết";
            this.Load += new System.EventHandler(this.frmQuanLy_LichDat_SanBong_XemChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_chitietlichdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_view_chitietlichdat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}