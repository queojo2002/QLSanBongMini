using BUS;
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
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_FWA));

        public frmThanhToan()
        {
            InitializeComponent();
        }

        public void Load_FWA()
        {
            flpFWA.Controls.Clear();
            DataTable Get_FWA = BUS_FWA.Instance.Select();
            if (Get_FWA != null)
            {
                for (int i = 0; i < Get_FWA.Rows.Count; i++)
                {
                    Flow_Add_FWA(Get_FWA.Rows[i]["ID"].ToString(), Get_FWA.Rows[i]["TenFWA"].ToString(), int.Parse(Get_FWA.Rows[i]["GiaTien"].ToString()).ToString("c0", CultureInfo.GetCultureInfo("vi-VN")), Base64ToImage(Get_FWA.Rows[i]["image"].ToString()));
                }
            }
        }
        public void Flow_Add_FWA(string ID, string Ten, string GiaTien, Image IMG)
        {
            PanelControl Panel_Img_Add = new PanelControl();
            LabelControl PanelLBL_Ten = new LabelControl();
            LabelControl PanelLBL_GiaTien = new LabelControl();
            PictureBox Pic_Add = new PictureBox();
            Panel_Img_Add.SuspendLayout();

            Panel_Img_Add.Controls.Add(PanelLBL_Ten);
            Panel_Img_Add.Controls.Add(PanelLBL_GiaTien);
            Panel_Img_Add.Controls.Add(Pic_Add);
            Panel_Img_Add.Location = new System.Drawing.Point(265, 3);
            Panel_Img_Add.Name = ID;
            Panel_Img_Add.Size = new System.Drawing.Size(256, 256);
            // 
            // panel_lbl_Tenphukien
            // 
            PanelLBL_Ten.Appearance.BackColor = System.Drawing.Color.Transparent;
            PanelLBL_Ten.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PanelLBL_Ten.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            PanelLBL_Ten.Size = new System.Drawing.Size(252, 49);
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
            PanelLBL_GiaTien.ImageOptions.SvgImage = global::QLSanBongMini_Final.Properties.Resources.moneysvg;
            PanelLBL_GiaTien.Location = new System.Drawing.Point(2, 205);
            PanelLBL_GiaTien.Name = ID;
            PanelLBL_GiaTien.Size = new System.Drawing.Size(252, 49);
            PanelLBL_GiaTien.Text = GiaTien;


            // 
            // pic_1
            // 
            Pic_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            Pic_Add.Location = new System.Drawing.Point(2, 51);
            Pic_Add.Name = ID;
            Pic_Add.Size = new System.Drawing.Size(252, 154);
            Pic_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Pic_Add.TabStop = false;
            Pic_Add.Image = IMG;
            flpFWA.Controls.Add(Panel_Img_Add);
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

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            Load_FWA();
        }


    }
}