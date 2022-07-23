using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_TaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public string Username_Global = null;
        public frmQuanLy_TaiKhoan()
        {
            InitializeComponent();
        }
        public frmQuanLy_TaiKhoan(string username)
        {
            InitializeComponent();
            Username_Global = username;

        }
        public void Click_Add_TaiKhoan(object sender, EventArgs e)
        {
            frmQuanLy_TaiKhoan_Them_ChinhSua taiKhoan_Them_ChinhSua = new frmQuanLy_TaiKhoan_Them_ChinhSua("", "ThemMoi");
            taiKhoan_Them_ChinhSua.ShowDialog();
            Load_TaiKhoan();
            this.Show();
        }


        public void Click_ChinhSua_TaiKhoan(object sender, EventArgs e)
        {
            SimpleButton Username = (SimpleButton)sender;
            frmQuanLy_TaiKhoan_Them_ChinhSua taiKhoan_Them_ChinhSua = new frmQuanLy_TaiKhoan_Them_ChinhSua(Username.Name, "ChinhSua");
            taiKhoan_Them_ChinhSua.ShowDialog();
            Load_TaiKhoan();
            this.Show();

        }

        public void Load_TaiKhoan()
        {
            flow_fill.Controls.Clear();
            DataTable get_list_taikhoan = BUS_TaiKhoan.Instance.Select();
            if (get_list_taikhoan != null)
            {
                SimpleButton btn_add = new SimpleButton();
                btn_add.ImageOptions.Image = QLSanBongMini_Final.Properties.Resources.ADD_TaiKhoan;
                btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
                btn_add.Size = new System.Drawing.Size(210, 210);
                btn_add.Text = "\r\n Thêm khách hàng";
                btn_add.Click += Click_Add_TaiKhoan;
                flow_fill.Controls.Add(btn_add);
                for (int i = 0; i < get_list_taikhoan.Rows.Count; i++)
                {
                    if (get_list_taikhoan.Rows[i]["Username"].ToString() == Username_Global) continue;
                    SimpleButton button = new SimpleButton();
                    button.ImageOptions.Image = QLSanBongMini_Final.Properties.Resources.user;
                    button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
                    button.Name = get_list_taikhoan.Rows[i]["Username"].ToString();
                    button.Size = new System.Drawing.Size(210, 210);
                    button.Text = "Chức vụ: " + get_list_taikhoan.Rows[i]["UserType"].ToString() + " \r\n\r\n Tên hiển thị: " + get_list_taikhoan.Rows[i]["DisplayName"].ToString();
                    button.Click += Click_ChinhSua_TaiKhoan;
                    flow_fill.Controls.Add(button);
                }
            }




        }

        private void frmQuanLy_TaiKhoan_Load(object sender, EventArgs e)
        {
            Load_TaiKhoan();
        }
    }
}