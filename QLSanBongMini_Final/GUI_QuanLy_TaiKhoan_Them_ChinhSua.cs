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
    public partial class frmQuanLy_TaiKhoan_Them_ChinhSua : DevExpress.XtraEditors.XtraForm
    {
        public bool ChinhSua = false;
        public frmQuanLy_TaiKhoan_Them_ChinhSua()
        {
            InitializeComponent();
        }

        public frmQuanLy_TaiKhoan_Them_ChinhSua(string Username, string Check)
        {
            InitializeComponent();
            if (Check == "ChinhSua")
            {
                DataTable get_tk = BUS_TaiKhoan.Instance.Select_By_Username(Username);
                if (get_tk.Rows.Count <= 0 || get_tk == null) return;

                txtUsername.Text = get_tk.Rows[0]["Username"].ToString();
                txtPassword.Text = get_tk.Rows[0]["Password"].ToString();
                txtDisplayName.Text = get_tk.Rows[0]["DisplayName"].ToString();
                if (get_tk.Rows[0]["UserType"].ToString() == "ADMIN")
                {
                    cbeChucVu.SelectedIndex = 2;
                }
                else if (get_tk.Rows[0]["UserType"].ToString() == "NguoiQuanLy")
                {
                    cbeChucVu.SelectedIndex = 1;
                }
                else if (get_tk.Rows[0]["UserType"].ToString() == "NhanVien")
                {
                    cbeChucVu.SelectedIndex = 0;
                }
                btnADD.Enabled = false;
                btnEDIT.Enabled = true;
                ChinhSua = true;
            }
            else
            {
                btnADD.Enabled = true;
                btnEDIT.Enabled = false;
            }

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (ChinhSua == false)
            {
                DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm tài khoản ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (add_confirm == DialogResult.Yes)
                {
                    if (BUS_TaiKhoan.Instance.Insert(txtUsername.Text, txtPassword.Text, txtDisplayName.Text, cbeChucVu.Text) == true)
                    {
                        XtraMessageBox.Show("Thêm tài khoản thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi thêm tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa tài khoản này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (add_confirm == DialogResult.Yes)
            {
                if (BUS_TaiKhoan.Instance.Update_By_UserName(txtUsername.Text, txtPassword.Text, txtDisplayName.Text, cbeChucVu.Text) == true)
                {
                    XtraMessageBox.Show("Sửa tài khoản thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi khi sửa tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
        }
    }
}