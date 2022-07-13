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
    public partial class frmQuanLy_KhachHang_ChinhSua : DevExpress.XtraEditors.XtraForm
    {
        DataTable Get_List_KhachHang = null;
        private int ID_KhachHang = -1;
        public frmQuanLy_KhachHang_ChinhSua(int ID_KH)
        {
            InitializeComponent();
            Get_List_KhachHang = BUS_KhachHang.Instance.Select_By_ID(ID_KH);
        }

        public void Load_Form_KhachHang()
        {
            ID_KhachHang = -1;
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtFB.Text = "";
            numricSoLanDat.Value = 0;
            if (Get_List_KhachHang != null)
            {
                ID_KhachHang = int.Parse(Get_List_KhachHang.Rows[0]["ID"].ToString());
                txtTenKH.Text = Get_List_KhachHang.Rows[0]["HoTen"].ToString();
                txtSDT.Text = Get_List_KhachHang.Rows[0]["SDT"].ToString();
                txtFB.Text = Get_List_KhachHang.Rows[0]["FB"].ToString();
                numricSoLanDat.Value = int.Parse(Get_List_KhachHang.Rows[0]["SoLanDat"].ToString());
            }
        }
        private void frmQuanLy_KhachHang_ChinhSua_Load(object sender, EventArgs e)
        {
            Load_Form_KhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ID_KhachHang != -1)
            {
                if (txtTenKH.Text == "" || txtSDT.Text == "")
                {
                    XtraMessageBox.Show("Sửa khách hàng này không thành công !!! \n\n Error: Vui lòng nhập Họ tên và Số điện thoại của khách hàng...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult edit_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa khách hàng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (edit_confirm == DialogResult.Yes)
                {
                    if (BUS_KhachHang.Instance.Update(ID_KhachHang, txtTenKH.Text, txtSDT.Text, txtFB.Text, (int)numricSoLanDat.Value) == true)
                    {
                        XtraMessageBox.Show("Sửa khách hàng này thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }else
                    {
                        XtraMessageBox.Show("Sửa khách hàng này không thành công !!! \n\n Error: Không xác định...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            else
            {
                XtraMessageBox.Show("Sửa khách hàng này không thành công !!! \n\n Error: ID khách hàng có lỗi..." , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            Load_Form_KhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ID_KhachHang != -1)
            {
                DialogResult del_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (del_confirm == DialogResult.Yes)
                {
                    if (BUS_KhachHang.Instance.Delete_By_ID(ID_KhachHang) == true)
                    {
                        XtraMessageBox.Show("Xóa khách hàng này thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa khách hàng này không thành công !!! \n\n Error: Không xác định...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Xóa khách hàng này không thành công !!! \n\n Error: ID khách hàng có lỗi...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
        }
    }
}