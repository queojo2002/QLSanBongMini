using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_FWA_Them : DevExpress.XtraEditors.XtraForm
    {
        private byte[] byte_base64 = null;
        private string base64_save = null;
        public frmQuanLy_FWA_Them()
        {
            InitializeComponent();
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_1.Image = Image.FromFile(ofd.FileName);
                    byte_base64 = System.IO.File.ReadAllBytes(ofd.FileName);
                    base64_save = Convert.ToBase64String(byte_base64);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (pic_1.Image == null)
            {

            }
            else
            {
                if (txtTen.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên FWA !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int IDLoaiFWA = -1;
                    if (cbeLoaiFWA.SelectedItem.ToString() == "Phụ kiện")
                    {
                        IDLoaiFWA = 1;
                    }
                    else if (cbeLoaiFWA.SelectedItem.ToString() == "Nước uống")
                    {
                        IDLoaiFWA = 2;
                    }
                    else if (cbeLoaiFWA.SelectedItem.ToString() == "Thức ăn")
                    {
                        IDLoaiFWA = 3;
                    }

                    if (IDLoaiFWA != -1)
                    {
                        DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm FWA này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (add_confirm == DialogResult.Yes)
                        {
                            if (BUS.BUS_FWA.Instance.Insert(IDLoaiFWA, txtTen.Text, (int)numricGiaTien.Value, base64_save) == true)
                            {
                                XtraMessageBox.Show("Thêm FWA thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                return;
                            }
                            else
                            {
                                XtraMessageBox.Show("Có lỗi khi thêm FWA", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                return;
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi thêm FWA", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }


                }
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            numricGiaTien.Value = 0;
            pic_1.Image = null;
        }


        private void numricGiaTien_ValueChanged(object sender, EventArgs e)
        {
            panel_lbl_Giatien.Text = numricGiaTien.Value.ToString("c0", CultureInfo.GetCultureInfo("vi-VN"));
        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {
            panel_lbl_Tenphukien.Text = txtTen.Text;
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

    }
}