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
using BUS;
using System.Globalization;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_FWA : DevExpress.XtraEditors.XtraForm
    {
        private byte[] byte_base64 = null;
        private string base64_save = null;
        public frmQuanLy_FWA()
        {
            InitializeComponent();
        }

        private void frmQuanLy_FWA_Load(object sender, EventArgs e)
        {
            Load_FWA();
        }
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            numricGiaTien.Value = 0;
            pic_1.Image = null;
        }


        public void Load_FWA()
        {
            flow_ShowFWA.Controls.Clear();
            DataTable Get_FWA = BUS_FWA.Instance.Select();
            if (Get_FWA != null)
            {
                for (int i = 0; i < Get_FWA.Rows.Count; i++)
                {
                    Flow_Add_FWA(Get_FWA.Rows[i]["ID"].ToString(), Get_FWA.Rows[i]["TenFWA"].ToString(), int.Parse(Get_FWA.Rows[i]["GiaTien"].ToString()).ToString("c0", CultureInfo.GetCultureInfo("vi-VN")), Base64ToImage(Get_FWA.Rows[i]["image"].ToString()));
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (pic_1.Image == null)
            {

            }else
            {
                if (txtTen.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Tên FWA !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else
                {
                    int IDLoaiFWA = -1;
                    if (cbeLoaiFWA.SelectedItem.ToString() == "Phụ kiện")
                    {
                        IDLoaiFWA = 1;
                    }else if(cbeLoaiFWA.SelectedItem.ToString() == "Nước uống")
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
                                Load_FWA();
                                return;
                            }else
                            {
                                XtraMessageBox.Show("Có lỗi khi thêm FWA", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Load_FWA();
                                return;
                            }
                        } 
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi thêm FWA", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Load_FWA();
                        return;
                    }


                }
            }
            
        }
 
        private void pic_1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_1.Image = Image.FromFile(ofd.FileName);
                    byte_base64 = System.IO.File.ReadAllBytes(ofd.FileName);
                    base64_save = Convert.ToBase64String(byte_base64);
                }
            }
        }

        private void txtTen_EditValueChanged_1(object sender, EventArgs e)
        {
            panel_lbl_Tenphukien.Text = txtTen.Text;
        }

        private void numricGiaTien_ValueChanged(object sender, EventArgs e)
        {
            panel_lbl_Giatien.Text = numricGiaTien.Value.ToString("c0", CultureInfo.GetCultureInfo("vi-VN"));
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

        public void Flow_Add_FWA(string ID, string Ten, string GiaTien, Image IMG)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_FWA));
            PanelControl Panel_Img_Add = new PanelControl();
            LabelControl PanelLBL_Ten = new LabelControl();
            LabelControl PanelLBL_GiaTien = new LabelControl();
            PictureBox Pic_Add = new PictureBox();
            Panel_Img_Add.SuspendLayout();

            Panel_Img_Add.Controls.Add(PanelLBL_Ten);
            Panel_Img_Add.Controls.Add(PanelLBL_GiaTien);
            Panel_Img_Add.Controls.Add(Pic_Add);
            Panel_Img_Add.Location = new System.Drawing.Point(205, 130);
            Panel_Img_Add.Name = ID;
            Panel_Img_Add.Size = new System.Drawing.Size(256, 349);
            // 
            // panel_lbl_Tenphukien
            // 
            PanelLBL_Ten.Appearance.BackColor = System.Drawing.Color.Transparent;
            PanelLBL_Ten.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PanelLBL_Ten.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            PanelLBL_Ten.Appearance.Options.UseBackColor = true;
            PanelLBL_Ten.Appearance.Options.UseFont = true;
            PanelLBL_Ten.Appearance.Options.UseForeColor = true;
            PanelLBL_Ten.Appearance.Options.UseTextOptions = true;
            PanelLBL_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            PanelLBL_Ten.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PanelLBL_Ten.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            PanelLBL_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            PanelLBL_Ten.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            PanelLBL_Ten.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            PanelLBL_Ten.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("panel_lbl_Tenphukien.ImageOptions.SvgImage")));
            PanelLBL_Ten.Location = new System.Drawing.Point(2, 2);
            PanelLBL_Ten.Name = ID;
            PanelLBL_Ten.Size = new System.Drawing.Size(252, 42);
            PanelLBL_Ten.Text = Ten;
            // 
            // panel_lbl_Giatien
            // 
            PanelLBL_GiaTien.Appearance.BackColor = System.Drawing.Color.Transparent;
            PanelLBL_GiaTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PanelLBL_GiaTien.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            PanelLBL_GiaTien.Appearance.Options.UseBackColor = true;
            PanelLBL_GiaTien.Appearance.Options.UseFont = true;
            PanelLBL_GiaTien.Appearance.Options.UseForeColor = true;
            PanelLBL_GiaTien.Appearance.Options.UseTextOptions = true;
            PanelLBL_GiaTien.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PanelLBL_GiaTien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            PanelLBL_GiaTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelLBL_GiaTien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            PanelLBL_GiaTien.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            PanelLBL_GiaTien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("panel_lbl_Giatien.ImageOptions.SvgImage")));
            PanelLBL_GiaTien.Location = new System.Drawing.Point(2, 299);
            PanelLBL_GiaTien.Name = ID;
            PanelLBL_GiaTien.Size = new System.Drawing.Size(252, 48);
            PanelLBL_GiaTien.Text = GiaTien;

            this.panel_lbl_Giatien.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel_lbl_Giatien.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_lbl_Giatien.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_lbl_Giatien.Appearance.Options.UseBackColor = true;
            this.panel_lbl_Giatien.Appearance.Options.UseFont = true;
            this.panel_lbl_Giatien.Appearance.Options.UseForeColor = true;
            this.panel_lbl_Giatien.Appearance.Options.UseTextOptions = true;
            this.panel_lbl_Giatien.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.panel_lbl_Giatien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.panel_lbl_Giatien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_lbl_Giatien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.panel_lbl_Giatien.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel_lbl_Giatien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("panel_lbl_Giatien.ImageOptions.SvgImage")));
            this.panel_lbl_Giatien.Location = new System.Drawing.Point(2, 299);
            this.panel_lbl_Giatien.Name = "panel_lbl_Giatien";
            this.panel_lbl_Giatien.Size = new System.Drawing.Size(252, 48);
            this.panel_lbl_Giatien.TabIndex = 2;
            this.panel_lbl_Giatien.Text = "Giá Tiền";


            // 
            // pic_1
            // 
            Pic_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            Pic_Add.Location = new System.Drawing.Point(2, 44);
            Pic_Add.Name = ID;
            Pic_Add.Size = new System.Drawing.Size(252, 250);
            Pic_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Pic_Add.TabStop = false;
            Pic_Add.Image = IMG;
            flow_ShowFWA.Controls.Add(Panel_Img_Add);
        }

    }
}