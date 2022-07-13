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
using BUS;
namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_KhachHang_Them : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_KhachHang_Them()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtFB.Text = "";
            numricSoLanDat.Value = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSDT.Text == "")
            {
                XtraMessageBox.Show("Thêm khách hàng này không thành công !!! \n\n Error: Vui lòng nhập Họ tên và Số điện thoại của khách hàng...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm khách hàng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (add_confirm == DialogResult.Yes)
            {
                if (BUS_KhachHang.Instance.Insert(txtTenKH.Text, txtSDT.Text, txtFB.Text, (int)numricSoLanDat.Value) == true)
                {
                    XtraMessageBox.Show("Thêm khách hàng này thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Thêm khách hàng này không thành công !!! \n\n Error: Không xác định...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}