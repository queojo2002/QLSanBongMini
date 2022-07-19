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
                    Flow_Add_FWA(Get_FWA.Rows[i]["ID"].ToString(), Get_FWA.Rows[i]["TenFWA"].ToString() + "\r\n" + int.Parse(Get_FWA.Rows[i]["GiaTien"].ToString()).ToString("c0", CultureInfo.GetCultureInfo("vi-VN")), Base64ToImage(Get_FWA.Rows[i]["image"].ToString()));
                }
            }
        }
        public void Flow_Add_FWA(string ID, string Text, Image IMG)
        {
            PanelControl Panel_Img_Add = new PanelControl();
            LabelControl PanelLBL_Ten = new LabelControl();
            SimpleButton button_add = new SimpleButton();
            PictureBox Pic_Add = new PictureBox();
            Panel_Img_Add.SuspendLayout();


            // 
            // panelFWAChildren
            // 
            Panel_Img_Add.Controls.Add(button_add);
            Panel_Img_Add.Controls.Add(PanelLBL_Ten);
            Panel_Img_Add.Controls.Add(Pic_Add);
            Panel_Img_Add.Location = new System.Drawing.Point(3, 3);
            Panel_Img_Add.Size = new System.Drawing.Size(169, 207);
            // 
            // lblten
            // 
            PanelLBL_Ten.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PanelLBL_Ten.Appearance.Options.UseFont = true;
            PanelLBL_Ten.Appearance.Options.UseTextOptions = true;
            PanelLBL_Ten.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PanelLBL_Ten.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            PanelLBL_Ten.Dock = System.Windows.Forms.DockStyle.Top;
            PanelLBL_Ten.Location = new System.Drawing.Point(2, 2);
            PanelLBL_Ten.Size = new System.Drawing.Size(165, 62);
            PanelLBL_Ten.Text = Text;
            // 
            // picFWA
            // 
            Pic_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            Pic_Add.Image = IMG;
            Pic_Add.Location = new System.Drawing.Point(2, 64);
            Pic_Add.Size = new System.Drawing.Size(165, 107);
            Pic_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnAddFWA
            // 
            button_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            button_add.ImageOptions.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources\\add_icon_1.png")));
            button_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            button_add.Location = new System.Drawing.Point(2, 171);
            button_add.Name = "btnAddFWA";
            button_add.Size = new System.Drawing.Size(165, 34);
            button_add.Text = "Thêm vào sân bóng";


           

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