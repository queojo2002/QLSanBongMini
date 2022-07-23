
namespace QLSanBongMini_Final
{
    partial class frmTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            DevExpress.XtraBars.BarButtonItem btnDangXuat2;
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_QuanLySanBong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mnLichSanBong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mnFWA = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mnKhuVucSanBong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mnDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.rp_nhanvien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_quanlysanbong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_themlichdatsanbong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_manager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_mnKhachHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rgp_fwa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_quanlykhuvucsanbong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_admin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_mndoanhthu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_mntaikhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Document_Manager_1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.rpg_dangxuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDangXuat1 = new DevExpress.XtraBars.BarButtonItem();
            this.rgp_dangxuat1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_dangxuat2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDangXuat3 = new DevExpress.XtraBars.BarButtonItem();
            btnDangXuat2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Document_Manager_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_QuanLySanBong,
            this.btn_mnLichSanBong,
            this.btn_mnFWA,
            this.btn_mnKhuVucSanBong,
            this.btn_mnDoanhThu,
            this.btn_mnTaiKhoan,
            this.btn_mnKhachHang,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barCheckItem1,
            this.btnDangXuat1,
            btnDangXuat2,
            this.btnDangXuat3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rp_nhanvien,
            this.rp_manager,
            this.rp_admin});
            this.ribbonControl1.Size = new System.Drawing.Size(1054, 177);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_QuanLySanBong
            // 
            this.btn_QuanLySanBong.Caption = "Quản lý sân bóng";
            this.btn_QuanLySanBong.Id = 1;
            this.btn_QuanLySanBong.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.football_icon;
            this.btn_QuanLySanBong.Name = "btn_QuanLySanBong";
            this.btn_QuanLySanBong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QuanLySanBong_ItemClick);
            // 
            // btn_mnLichSanBong
            // 
            this.btn_mnLichSanBong.Caption = "Quản lý lịch đặt sân bóng";
            this.btn_mnLichSanBong.Id = 2;
            this.btn_mnLichSanBong.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.add_icon;
            this.btn_mnLichSanBong.Name = "btn_mnLichSanBong";
            this.btn_mnLichSanBong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mnLichSanBong_ItemClick);
            // 
            // btn_mnFWA
            // 
            this.btn_mnFWA.Caption = "Quản lý FWA";
            this.btn_mnFWA.Id = 3;
            this.btn_mnFWA.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.food_icon;
            this.btn_mnFWA.Name = "btn_mnFWA";
            this.btn_mnFWA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mnFWA_ItemClick);
            // 
            // btn_mnKhuVucSanBong
            // 
            this.btn_mnKhuVucSanBong.Caption = "Quản lý khu vực sân bóng";
            this.btn_mnKhuVucSanBong.Id = 6;
            this.btn_mnKhuVucSanBong.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.area;
            this.btn_mnKhuVucSanBong.Name = "btn_mnKhuVucSanBong";
            this.btn_mnKhuVucSanBong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mnKhuVucSanBong_ItemClick);
            // 
            // btn_mnDoanhThu
            // 
            this.btn_mnDoanhThu.Caption = "Quản lý doanh thu";
            this.btn_mnDoanhThu.Id = 7;
            this.btn_mnDoanhThu.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.money;
            this.btn_mnDoanhThu.Name = "btn_mnDoanhThu";
            this.btn_mnDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mnDoanhThu_ItemClick);
            // 
            // btn_mnTaiKhoan
            // 
            this.btn_mnTaiKhoan.Caption = "Quản lý tài khoản";
            this.btn_mnTaiKhoan.Id = 8;
            this.btn_mnTaiKhoan.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.account;
            this.btn_mnTaiKhoan.Name = "btn_mnTaiKhoan";
            this.btn_mnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mnTaiKhoan_ItemClick);
            // 
            // btn_mnKhachHang
            // 
            this.btn_mnKhachHang.Caption = "Quản lý khách hàng";
            this.btn_mnKhachHang.Id = 9;
            this.btn_mnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_mnKhachHang.ImageOptions.Image")));
            this.btn_mnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_mnKhachHang.ImageOptions.LargeImage")));
            this.btn_mnKhachHang.Name = "btn_mnKhachHang";
            this.btn_mnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mnKhachHang_ItemClick);
            // 
            // rp_nhanvien
            // 
            this.rp_nhanvien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_quanlysanbong,
            this.rpg_themlichdatsanbong,
            this.rpg_dangxuat});
            this.rp_nhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rp_nhanvien.ImageOptions.Image")));
            this.rp_nhanvien.Name = "rp_nhanvien";
            this.rp_nhanvien.Text = "Trang - Nhân viên thu ngân";
            // 
            // rpg_quanlysanbong
            // 
            this.rpg_quanlysanbong.AllowTextClipping = false;
            this.rpg_quanlysanbong.ItemLinks.Add(this.btn_QuanLySanBong);
            this.rpg_quanlysanbong.Name = "rpg_quanlysanbong";
            this.rpg_quanlysanbong.Text = "Trang chức năng: Quản lý sân bóng";
            // 
            // rpg_themlichdatsanbong
            // 
            this.rpg_themlichdatsanbong.AllowTextClipping = false;
            this.rpg_themlichdatsanbong.ItemLinks.Add(this.btn_mnLichSanBong);
            this.rpg_themlichdatsanbong.Name = "rpg_themlichdatsanbong";
            this.rpg_themlichdatsanbong.Text = "Trang chức năng: Thêm lịch đặt sân bóng";
            // 
            // rp_manager
            // 
            this.rp_manager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_mnKhachHang,
            this.rgp_fwa,
            this.rpg_quanlykhuvucsanbong,
            this.rgp_dangxuat1});
            this.rp_manager.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rp_manager.ImageOptions.SvgImage")));
            this.rp_manager.Name = "rp_manager";
            this.rp_manager.Text = "Trang - Người quản lý ";
            // 
            // rpg_mnKhachHang
            // 
            this.rpg_mnKhachHang.AllowTextClipping = false;
            this.rpg_mnKhachHang.ItemLinks.Add(this.btn_mnKhachHang);
            this.rpg_mnKhachHang.Name = "rpg_mnKhachHang";
            this.rpg_mnKhachHang.Text = "Trang chức năng: Quản lý khách hàng";
            // 
            // rgp_fwa
            // 
            this.rgp_fwa.AllowTextClipping = false;
            this.rgp_fwa.ItemLinks.Add(this.btn_mnFWA);
            this.rgp_fwa.Name = "rgp_fwa";
            this.rgp_fwa.Text = "Trang chức năng: Quản lý thức ăn, nước uống, phụ kiện";
            // 
            // rpg_quanlykhuvucsanbong
            // 
            this.rpg_quanlykhuvucsanbong.AllowTextClipping = false;
            this.rpg_quanlykhuvucsanbong.ItemLinks.Add(this.btn_mnKhuVucSanBong);
            this.rpg_quanlykhuvucsanbong.Name = "rpg_quanlykhuvucsanbong";
            this.rpg_quanlykhuvucsanbong.Text = "Trang chức năng: Quản lý khu vực sân bóng";
            // 
            // rp_admin
            // 
            this.rp_admin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_mndoanhthu,
            this.rpg_mntaikhoan,
            this.rpg_dangxuat2});
            this.rp_admin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rp_admin.ImageOptions.Image")));
            this.rp_admin.Name = "rp_admin";
            this.rp_admin.Text = "Trang - Quản trị viên";
            // 
            // rpg_mndoanhthu
            // 
            this.rpg_mndoanhthu.AllowTextClipping = false;
            this.rpg_mndoanhthu.ItemLinks.Add(this.btn_mnDoanhThu);
            this.rpg_mndoanhthu.Name = "rpg_mndoanhthu";
            this.rpg_mndoanhthu.Text = "Trang chức năng: Quản lý doanh thu";
            // 
            // rpg_mntaikhoan
            // 
            this.rpg_mntaikhoan.AllowTextClipping = false;
            this.rpg_mntaikhoan.ItemLinks.Add(this.btn_mnTaiKhoan);
            this.rpg_mntaikhoan.Name = "rpg_mntaikhoan";
            this.rpg_mntaikhoan.Text = "Trang chức năng: Quản lý tài khoản";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 549);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1054, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Document_Manager_1
            // 
            this.Document_Manager_1.MdiParent = this;
            this.Document_Manager_1.MenuManager = this.ribbonControl1;
            this.Document_Manager_1.View = this.tabbedView1;
            this.Document_Manager_1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng xuất";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 12;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // rpg_dangxuat
            // 
            this.rpg_dangxuat.AllowTextClipping = false;
            this.rpg_dangxuat.ItemLinks.Add(this.btnDangXuat1);
            this.rpg_dangxuat.Name = "rpg_dangxuat";
            this.rpg_dangxuat.Text = "Đăng xuất";
            // 
            // btnDangXuat1
            // 
            this.btnDangXuat1.Caption = "Đăng xuất";
            this.btnDangXuat1.Id = 13;
            this.btnDangXuat1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.btnDangXuat1.Name = "btnDangXuat1";
            this.btnDangXuat1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat1_ItemClick);
            // 
            // rgp_dangxuat1
            // 
            this.rgp_dangxuat1.AllowTextClipping = false;
            this.rgp_dangxuat1.ItemLinks.Add(btnDangXuat2);
            this.rgp_dangxuat1.Name = "rgp_dangxuat1";
            this.rgp_dangxuat1.Text = "Đăng xuất";
            // 
            // btnDangXuat2
            // 
            btnDangXuat2.Caption = "Đăng xuất";
            btnDangXuat2.Id = 14;
            btnDangXuat2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            btnDangXuat2.Name = "btnDangXuat2";
            btnDangXuat2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat2_ItemClick);
            // 
            // rpg_dangxuat2
            // 
            this.rpg_dangxuat2.AllowTextClipping = false;
            this.rpg_dangxuat2.ItemLinks.Add(this.btnDangXuat3);
            this.rpg_dangxuat2.Name = "rpg_dangxuat2";
            this.rpg_dangxuat2.Text = "Đăng xuất";
            // 
            // btnDangXuat3
            // 
            this.btnDangXuat3.Caption = "Đăng xuất";
            this.btnDangXuat3.Id = 15;
            this.btnDangXuat3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat3.ImageOptions.SvgImage")));
            this.btnDangXuat3.Name = "btnDangXuat3";
            this.btnDangXuat3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat3_ItemClick);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.football_icon;
            this.IsMdiContainer = true;
            this.Name = "frmTrangChu";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Trang Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Document_Manager_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_nhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_quanlysanbong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_themlichdatsanbong;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Docking2010.DocumentManager Document_Manager_1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_admin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_mndoanhthu;
        private DevExpress.XtraBars.BarButtonItem btn_QuanLySanBong;
        private DevExpress.XtraBars.BarButtonItem btn_mnLichSanBong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_manager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rgp_fwa;
        private DevExpress.XtraBars.BarButtonItem btn_mnFWA;
        private DevExpress.XtraBars.BarButtonItem btn_mnKhuVucSanBong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_quanlykhuvucsanbong;
        private DevExpress.XtraBars.BarButtonItem btn_mnDoanhThu;
        private DevExpress.XtraBars.BarButtonItem btn_mnTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_mntaikhoan;
        private DevExpress.XtraBars.BarButtonItem btn_mnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_mnKhachHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_dangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rgp_dangxuat1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_dangxuat2;
    }
}