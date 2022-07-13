﻿using DevExpress.XtraEditors;
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
using System.Threading;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_SanBong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_SanBong()
        {
            InitializeComponent();
            timer1.Tick += update_status_realtime_Tick;
            timer1.Interval = 3000;
            timer1.Start();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-vn");
        }

      

        public void Load_SanBong()
        {
            flow_1.Controls.Clear();
            DataTable Get_ChiTiet_LichDat_SanBong = BUS_ChiTiet_LichDat_SanBong.Instance.Select();
            if (Get_ChiTiet_LichDat_SanBong != null)
            {
                for (int i = 0; i < Get_ChiTiet_LichDat_SanBong.Rows.Count; i++)
                {
                    int ID = int.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["ID"].ToString());
                    int ID_KVSB = int.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["ID_KVSB"].ToString());
                    DataTable Get_KVSB = BUS_KhuVuc_SanBong.Instance.Select_By_ID(ID_KVSB);
                    if (Get_KVSB == null) continue;
                    string Ten_ChiTiet_LichDat_SanBong = Get_KVSB.Rows[0]["Ten"].ToString();
                    string KhungGio_BatDau = Get_ChiTiet_LichDat_SanBong.Rows[i]["KhungGio_BatDat"].ToString();
                    string KhungGio_KetThuc = Get_ChiTiet_LichDat_SanBong.Rows[i]["KhungGio_KetThuc"].ToString();
                    DateTime NgayDat = DateTime.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["NgayDat"].ToString());
                    int TrangThai = int.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["TrangThai"].ToString());
                    if (NgayDat.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                    {
                        if (TrangThai == 1) // Đã Đặt
                        {
                            GUI_ADDFLOW_SanBong("Hủy Sân", "Xử Lý Sân Bóng", ID, Ten_ChiTiet_LichDat_SanBong, KhungGio_BatDau, KhungGio_KetThuc, "Đã Đặt !", Color.Red, true, false);
                        }
                        else if (TrangThai == 2) // Đang Đá
                        {
                            GUI_ADDFLOW_SanBong("Hủy Sân", "Xử Lý Sân Bóng", ID, Ten_ChiTiet_LichDat_SanBong, KhungGio_BatDau, KhungGio_KetThuc, "Đang Đá !", Color.Green, false, true);
                        }
                        else if (TrangThai == 3) // Đã Thanh Toán
                        {
                            GUI_ADDFLOW_SanBong("Hủy Sân", "Xem Lại", ID, Ten_ChiTiet_LichDat_SanBong, KhungGio_BatDau, KhungGio_KetThuc, "Đã Thanh Toán !", Color.Blue, false, true);
                        }
                        else if (TrangThai == 4) // Vui Lòng Thanh Toán !
                        {
                            GUI_ADDFLOW_SanBong("Hủy Sân", "Xử Lý Sân Bóng", ID, Ten_ChiTiet_LichDat_SanBong, KhungGio_BatDau, KhungGio_KetThuc, "Vui Lòng Thanh Toán !", Color.Black, false, true);
                        }
                        else if (TrangThai == 5) // Đã Quá Giờ !
                        {
                            GUI_ADDFLOW_SanBong("Hủy Sân", "Xử Lý Sân Bóng", ID, Ten_ChiTiet_LichDat_SanBong, KhungGio_BatDau, KhungGio_KetThuc, "Đã Quá Giờ !", Color.Brown, false, true);
                        }
                        else if (TrangThai == 0) // Hủy Sân
                        {
                            GUI_ADDFLOW_SanBong("Hủy Sân", "Đặt Lại", ID, Ten_ChiTiet_LichDat_SanBong, KhungGio_BatDau, KhungGio_KetThuc, "Đã Hủy Sân !", Color.Gray, false, true);
                        }
                    }
                }
            }
            
        }

        private void update_status_realtime_Tick(object sender, EventArgs e)
        {
            short Flag_Check_Reload_Form = 0;
            DataTable Get_ChiTiet_LichDat_SanBong = BUS_ChiTiet_LichDat_SanBong.Instance.Select();
            if (Get_ChiTiet_LichDat_SanBong != null)
            {
                for (int i = 0; i < Get_ChiTiet_LichDat_SanBong.Rows.Count; i++)
                {
                    int ID = int.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["ID"].ToString());
                    string KhungGio_BatDau = Get_ChiTiet_LichDat_SanBong.Rows[i]["KhungGio_BatDat"].ToString();
                    string KhungGio_KetThuc = Get_ChiTiet_LichDat_SanBong.Rows[i]["KhungGio_KetThuc"].ToString();
                    DateTime NgayDat = DateTime.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["NgayDat"].ToString());
                    int TrangThai = int.Parse(Get_ChiTiet_LichDat_SanBong.Rows[i]["TrangThai"].ToString());
                    if (TrangThai == 1 && NgayDat.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                    {
                        if (TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString()) >= TimeSpan.Parse(KhungGio_BatDau) && TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString()) <= TimeSpan.Parse(KhungGio_KetThuc))
                        {
                            BUS_ChiTiet_LichDat_SanBong.Instance.Update(ID, 2);
                            Flag_Check_Reload_Form = 1;
                        }
                        else if (TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString()) > TimeSpan.Parse(KhungGio_BatDau) && TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString()) > TimeSpan.Parse(KhungGio_KetThuc))
                        {
                            BUS_ChiTiet_LichDat_SanBong.Instance.Update(ID, 4);
                            Flag_Check_Reload_Form = 1;
                        }
                    }
                    else if (TrangThai == 2 && NgayDat.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                    {
                        if (TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString()) >= TimeSpan.Parse(KhungGio_KetThuc))
                        {
                            BUS_ChiTiet_LichDat_SanBong.Instance.Update(ID, 4);
                            Flag_Check_Reload_Form = 1;
                        }
                    }
                    else if ((TrangThai == 1 || TrangThai == 2) && (NgayDat < DateTime.Now))
                    {
                        BUS_ChiTiet_LichDat_SanBong.Instance.Update(ID, 5);
                        Flag_Check_Reload_Form = 1;
                    }

                }
                if (Flag_Check_Reload_Form == 1) Load_SanBong();

            }
            
            

        }

        public void GUI_ADDFLOW_SanBong(string Text_BTN_ChuyenTrangThai, string Text_BTN_XuLy, int ID_ChiTiet_LichDat_SanBong, string Ten_ChiTiet_LichDat_SanBong, string KhungGio_BatDau, string KhungGio_KetThuc, string TrangThai, Color Color_Change, bool Button_ChuyenTrangThai = true, bool Button_XuLy = true)
        {
            PanelControl panel_1 = new PanelControl();
            LabelControl ten_san = new LabelControl();
            LabelControl trang_thai = new LabelControl();
            LabelControl khunggio = new LabelControl();
            SimpleButton btn_xuly = new SimpleButton();
            SimpleButton btn_xuly_1 = new SimpleButton();
            PictureBox pic_add = new PictureBox();
            panel_1.Controls.Add(ten_san);
            panel_1.Controls.Add(trang_thai);
            panel_1.Controls.Add(khunggio);
            panel_1.Controls.Add(btn_xuly);
            panel_1.Controls.Add(btn_xuly_1);
            panel_1.Controls.Add(pic_add);
            panel_1.Margin = new Padding(30, 30, 15, 3);
            panel_1.Size = new System.Drawing.Size(325, 219);

            ten_san.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ten_san.Appearance.Options.UseFont = true;
            ten_san.Appearance.Options.UseTextOptions = true;
            ten_san.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ten_san.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            ten_san.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            ten_san.Location = new System.Drawing.Point(0, 31);
            ten_san.Size = new System.Drawing.Size(325, 35);
            ten_san.Text = "Tên Loại Sân: " + Ten_ChiTiet_LichDat_SanBong;

            trang_thai.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trang_thai.Appearance.Options.UseFont = true;
            trang_thai.Appearance.Options.UseTextOptions = true;
            trang_thai.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trang_thai.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            trang_thai.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            trang_thai.Location = new System.Drawing.Point(0, 150);
            trang_thai.BackColor = Color_Change;
            trang_thai.Size = new System.Drawing.Size(325, 35);
            trang_thai.Text = "Trạng Thái: " + TrangThai;

            khunggio.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            khunggio.Appearance.Options.UseFont = true;
            khunggio.Appearance.Options.UseTextOptions = true;
            khunggio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            khunggio.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            khunggio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            khunggio.Location = new System.Drawing.Point(0, 0);
            khunggio.Size = new System.Drawing.Size(325, 35);
            khunggio.Text = "Khung Giờ: " + KhungGio_BatDau + " - " + KhungGio_KetThuc;

            btn_xuly.Enabled = Button_XuLy;
            btn_xuly.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_xuly.Appearance.Options.UseFont = true;
            btn_xuly.Location = new System.Drawing.Point(160, 184);
            btn_xuly.Name = ID_ChiTiet_LichDat_SanBong.ToString();
            btn_xuly.Size = new System.Drawing.Size(163, 35);
            btn_xuly.Text = Text_BTN_XuLy;
            //btn_xuly.Click += GUI_BTN_XuLy;


            btn_xuly_1.Enabled = Button_ChuyenTrangThai;
            btn_xuly_1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_xuly_1.Appearance.Options.UseFont = true;
            btn_xuly_1.Location = new System.Drawing.Point(0, 184);
            btn_xuly_1.Name = ID_ChiTiet_LichDat_SanBong.ToString();
            btn_xuly_1.Size = new System.Drawing.Size(160, 35);
            btn_xuly_1.Text = Text_BTN_ChuyenTrangThai;
            //btn_xuly_1.Click += GUI_BTN_ChuyenTrangThai;

            pic_add.Dock = System.Windows.Forms.DockStyle.Fill;
            pic_add.Image = Image.FromFile(Application.StartupPath + @"\Resource\sanbong.png");
            pic_add.Location = new System.Drawing.Point(2, 2);
            pic_add.Size = new System.Drawing.Size(325, 215);
            pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_add.TabStop = false;
            flow_1.Controls.Add(panel_1);
        }

        public string CheckTrung_TimeSpan(TimeSpan Time_Dat_BatDau, TimeSpan Time_Dat_KetThuc, TimeSpan Time_Dat_BatDau_1, TimeSpan Time_Dat_KetThuc_1) // Check xem time ở người dùng nhập có nằm trong time ở sql hay khum - OK là kh trùng
        {
            if (Time_Dat_BatDau_1 >= Time_Dat_BatDau && Time_Dat_BatDau_1 <= Time_Dat_KetThuc && Time_Dat_KetThuc_1 >= Time_Dat_BatDau && Time_Dat_KetThuc_1 <= Time_Dat_KetThuc)
            {
                return "OK";
            }
            else
            {
                return "Trùng";
            }
        }


        private void frmQuanLy_SanBong_Load(object sender, EventArgs e)
        {
            Load_SanBong();
        }
    }
}