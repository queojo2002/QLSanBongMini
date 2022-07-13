using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_KV_SanBong_Them : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_KV_SanBong_Them()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTen_KVSB.Text = "";
            nudGiaTien_KVSB.Value = 0;
            teGioBatDau.EditValue = "00:00:00";
            teGioKetThuc.EditValue = "00:00:00";
            txtTen_KVSB.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Ten = txtTen_KVSB.Text;
            int GiaTien = ((int)nudGiaTien_KVSB.Value);
            TimeSpan KhungGio_BatDau = TimeSpan.Parse(teGioBatDau.Text);
            TimeSpan KhungGio_KetThuc = TimeSpan.Parse(teGioKetThuc.Text);
            if (Ten == "")
            {
                XtraMessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (KhungGio_KetThuc < KhungGio_BatDau)
            {
                XtraMessageBox.Show("Khung giờ kết thúc phải lớn hơn hoặc bằng khung giờ bắt đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm khu vực sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (add_confirm == DialogResult.Yes)
            {
                if (BUS_KhuVuc_SanBong.Instance.Insert(Ten, GiaTien, KhungGio_BatDau, KhungGio_KetThuc) == true)
                {
                    XtraMessageBox.Show("Thêm khu vực sân bóng thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

                




        }
    }
}