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
    public partial class frmQuanLy_FWA_Chinhsua : DevExpress.XtraEditors.XtraForm
    {
        private int IDFWA_Global = -1;
        DataTable Get_FWA = null;
        private bool Check_Update = false;
        private int Check_Update_Image = -1;
        private byte[] byte_base64 = null;
        private string base64_save = null;

        public frmQuanLy_FWA_Chinhsua()
        {
            InitializeComponent();
        }

        public frmQuanLy_FWA_Chinhsua(int IDFWA)
        {
            InitializeComponent();
            IDFWA_Global = IDFWA;
            Get_FWA = BUS_FWA.Instance.Select_By_ID(IDFWA);
        }


        private void frmQuanLy_FWA_Chinhsua_Load(object sender, EventArgs e)
        {
            if (Get_FWA == null || Get_FWA.Rows.Count <= 0)
            {
                this.Close();
            }
            txtTen.Text = Get_FWA.Rows[0]["TenFWA"].ToString();
            numricGiaTien.Value = Decimal.Parse(Get_FWA.Rows[0]["GiaTien"].ToString());
            cbeLoaiFWA.SelectedIndex = int.Parse(Get_FWA.Rows[0]["IDLoaiFWA"].ToString()) - 1;
            pic_1.Image = Base64ToImage(Get_FWA.Rows[0]["image"].ToString());
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
                    Check_Update_Image = 1;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập Tên FWA !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa FWA này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (add_confirm == DialogResult.Yes)
                {
                    if (Check_Update_Image == 1)
                    {
                        Check_Update = BUS_FWA.Instance.Update(IDFWA_Global, IDLoaiFWA, txtTen.Text, (int)numricGiaTien.Value, base64_save);
                    }else
                    {
                        Check_Update = BUS_FWA.Instance.Update(IDFWA_Global, IDLoaiFWA, txtTen.Text, (int)numricGiaTien.Value);
                    }

                    if (Check_Update == true)
                    {
                        XtraMessageBox.Show("Sửa FWA thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi sửa FWA", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Có lỗi khi sửa FWA", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


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