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
using System.IO;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_KhachHang()
        {
            InitializeComponent();
            
        }


        public void GUI_ADD_KhachHang(object sender, EventArgs e)
        {
            frmQuanLy_KhachHang_Them add_khachhang = new frmQuanLy_KhachHang_Them();
            add_khachhang.ShowDialog();
            Load_KhachHang();
            this.Show();
        }


        public void GUI_XuLy_KhachHang(object sender, EventArgs e)
        {
            SimpleButton ID_KH = (SimpleButton)sender;
            frmQuanLy_KhachHang_ChinhSua mgu = new frmQuanLy_KhachHang_ChinhSua(int.Parse(ID_KH.Name));
            mgu.ShowDialog();
            Load_KhachHang();
            this.Show();
            
        }
        public void Load_KhachHang()
        {
            flow_fill.Controls.Clear();
            DataTable get_list_khachhang = BUS_KhachHang.Instance.Select();
            if (get_list_khachhang != null)
            {
                SimpleButton btn_add = new SimpleButton();
                btn_add.ImageOptions.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources\\AddUser_Logo.png")));
                btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
                btn_add.Size = new System.Drawing.Size(210, 210);
                btn_add.Text = "\r\n Thêm khách hàng";
                btn_add.Click += GUI_ADD_KhachHang;
                flow_fill.Controls.Add(btn_add);
                for (int i = 0; i < get_list_khachhang.Rows.Count; i++)
                {
                    SimpleButton button = new SimpleButton();
                    button.ImageOptions.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources\\User_Logo.png")));
                    button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
                    button.Name = get_list_khachhang.Rows[i]["ID"].ToString();
                    button.Size = new System.Drawing.Size(210, 210);
                    button.Text = "View Infomaion \r\n\r\nHọ Tên: " + get_list_khachhang.Rows[i]["HoTen"].ToString();
                    button.Click += GUI_XuLy_KhachHang;
                    flow_fill.Controls.Add(button); 
                }
            }
            



        }

        private void frmQuanLy_KhachHang_Load(object sender, EventArgs e)
        {
           
            Load_KhachHang();
        }
    }
}