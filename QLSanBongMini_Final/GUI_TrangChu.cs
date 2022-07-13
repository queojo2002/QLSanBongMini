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

namespace QLSanBongMini_Final
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
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
    }
}