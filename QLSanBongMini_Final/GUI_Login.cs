using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = "";
            txt_MatKhau.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat_confirm = XtraMessageBox.Show("Bạn có chắc chắn là muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thoat_confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text != string.Empty && txt_MatKhau.Text != string.Empty)
            {
                bool Login = BUS_TaiKhoan.Instance.CheckLogin(txt_TenDangNhap.Text, txt_MatKhau.Text);
                if (Login == true)
                {
                    frmTrangChu home_show = new frmTrangChu(txt_TenDangNhap.Text);
                    this.Hide();
                    home_show.ShowDialog();
                    this.Show();
                }
                else
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (BUS_DB.Instance.Check_Connect() == false)
            {
                XtraMessageBox.Show("Kết nối SQL không thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
    }
}