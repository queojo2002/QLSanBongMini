using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QLSanBongMini_Final
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string Username_Global = null;
        public string ChucVu = null;
        DataTable Get_TK = null;
        public frmTrangChu()
        {
            InitializeComponent();
        }
        public frmTrangChu(string Username)
        {
            InitializeComponent();
            Username_Global = Username;
            Get_TK = BUS_TaiKhoan.Instance.Select_By_Username(Username);
            ChucVu = Get_TK.Rows[0]["UserType"].ToString();
            if (ChucVu == "ADMIN")
            {
                rp_nhanvien.Visible = false;
                rp_manager.Visible = false;
            }
            else if (ChucVu == "NhanVien")
            {
                rp_manager.Visible = false;
                rp_admin.Visible = false;
            }
            else if (ChucVu == "NguoiQuanLy")
            {
                rp_admin.Visible = false;
                rp_nhanvien.Visible = false;
            }
        }
        private void btn_mnKhuVucSanBong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_KV_SanBong qlkv_sb = new frmQuanLy_KV_SanBong();
            qlkv_sb.MdiParent = this;
            qlkv_sb.Show();
        }

        private void btn_mnLichSanBong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_LichDat_SanBong qlld_sb = new frmQuanLy_LichDat_SanBong();
            qlld_sb.MdiParent = this;
            qlld_sb.Show();
        }

        private void btn_QuanLySanBong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_SanBong qlsb = new frmQuanLy_SanBong();
            qlsb.MdiParent = this;
            qlsb.Show();
        }

        private void btn_mnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_KhachHang qlkh = new frmQuanLy_KhachHang();
            qlkh.MdiParent = this;
            qlkh.Show();
        }

        private void btn_mnFWA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_FWA qlfwa = new frmQuanLy_FWA();
            qlfwa.MdiParent = this;
            qlfwa.Show();
        }

        private void btn_mnDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_DoanhThu _DoanhThu = new frmQuanLy_DoanhThu();
            _DoanhThu.MdiParent = this;
            _DoanhThu.Show();
        }

        private void btn_mnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLy_TaiKhoan frmQuanLy = new frmQuanLy_TaiKhoan(Username_Global);
            frmQuanLy.MdiParent = this;
            frmQuanLy.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }



        private void btnDangXuat1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dx_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dx_confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangXuat2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dx_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dx_confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnDangXuat3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dx_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dx_confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}