using BUS;
using DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
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
        public int IDChiTietLichDatSanBong = -1;
        public int IDKVSB = -1;
        public int IDKH = -1;
        public int IDBill = -1;
        public DataTable Select_ChiTietLichDatSanBong = null;
        public DataTable Select_KhachHang = null;
        public DataTable Select_KVSB = null;
        public int TongTien_Global = 0;
        public int TienSan_Global = 0;


        public frmThanhToan()
        {
            InitializeComponent();
        }
        public frmThanhToan(int ID_ChiTietLichDatSanBong)
        {
            InitializeComponent();
            IDChiTietLichDatSanBong = ID_ChiTietLichDatSanBong;
            Select_ChiTietLichDatSanBong = BUS_ChiTiet_LichDat_SanBong.Instance.Select(IDChiTietLichDatSanBong);
            IDKH = int.Parse(Select_ChiTietLichDatSanBong.Rows[0]["ID_KH"].ToString());
            Select_KhachHang = BUS_KhachHang.Instance.Select_By_ID(IDKH);
            IDKVSB = int.Parse(Select_ChiTietLichDatSanBong.Rows[0]["ID_KVSB"].ToString());
            Select_KVSB = BUS_KhuVuc_SanBong.Instance.Select_By_ID(IDKVSB);
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            Load_FWA();
            if (Select_ChiTietLichDatSanBong == null || Select_KhachHang == null || Select_KVSB == null)
            {
                this.Close();
            }
            lblNguoidat.Text = "Người đặt sân bóng: " + Select_KhachHang.Rows[0]["HoTen"].ToString();
            lblSDTnguoidat.Text = "SĐT của người đặt sân bóng: " + Select_KhachHang.Rows[0]["SDT"].ToString();
            lblSoLanDat.Text = "Số lần khách hàng này đã đặt sân: " + Select_KhachHang.Rows[0]["SoLanDat"].ToString();

            lblKVSB.Text = "Khu vực sân bóng: " + Select_KVSB.Rows[0]["Ten"].ToString();
            lblKhungGio.Text = "Khung giờ: " + Select_ChiTietLichDatSanBong.Rows[0]["KhungGio_BatDat"].ToString() + " - " + Select_ChiTietLichDatSanBong.Rows[0]["KhungGio_KetThuc"].ToString();
            TienSan_Global = (int)((TimeSpan.Parse(Select_ChiTietLichDatSanBong.Rows[0]["KhungGio_KetThuc"].ToString()) - TimeSpan.Parse(Select_ChiTietLichDatSanBong.Rows[0]["KhungGio_BatDat"].ToString())).TotalMinutes / 60) * int.Parse(Select_KVSB.Rows[0]["GiaTien"].ToString());
            lblThoiLuong.Text = "Thời lượng: " + (TimeSpan.Parse(Select_ChiTietLichDatSanBong.Rows[0]["KhungGio_KetThuc"].ToString()) - TimeSpan.Parse(Select_ChiTietLichDatSanBong.Rows[0]["KhungGio_BatDat"].ToString())).TotalMinutes.ToString() + " phút - Giá: " + TienSan_Global.ToString("c0");
            
            Load_Check_Add_Bill();
            Load_Column();
            Load_Bill();
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
            button_add.Name = ID;
            button_add.Click += Click_ADD_FWA;
            button_add.Size = new System.Drawing.Size(165, 34);
            button_add.Text = "Thêm vào sân bóng";


           

            flpFWA.Controls.Add(Panel_Img_Add);
        }
        private void Click_ADD_FWA(object sender, EventArgs e)
        {
            SimpleButton IDFWA = (SimpleButton)sender;
            var grid_fwa = grid_view_fwa.MainView as GridView;
            DataTable Get_Bill = BUS_Bill.Instance.Select_By_ID(IDBill);
            if (Get_Bill == null) return;
            DataTable Get_FWA = BUS_FWA.Instance.Select_By_ID(int.Parse(IDFWA.Name.ToString()));
            if (Get_FWA == null) return;
            for (int i = 0; i < grid_fwa.RowCount; i++)
            {
                DataRowView Get = (DataRowView)(grid_fwa.GetRow(i));
                int Ma_FWA_Grid = int.Parse(Get["Mã FWA"].ToString());
                string Ten_FWA_Grid = Get["Tên FWA"].ToString();
                int SoLuong_Grid = int.Parse(Get["Số Lượng"].ToString());
                int GiaTien_Grid = int.Parse(Get["Giá Tiền"].ToString());
                if (Ten_FWA_Grid == Get_FWA.Rows[0]["TenFWA"].ToString())
                {
                    XtraMessageBox.Show("FWA Đã Tồn Tại Trong Sân Bóng Này !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            BUS_ChiTietHoaDon.Instance.Insert(IDBill, int.Parse(IDFWA.Name.ToString()), 1);
            Add_View_FWA(int.Parse(IDFWA.Name.ToString()), Get_FWA.Rows[0]["TenFWA"].ToString(), 1, int.Parse(Get_FWA.Rows[0]["GiaTien"].ToString()) * 1);
            Update_TongTien();
        }
        public void Load_Bill()
        {
            DataTable Get_Bill = BUS_Bill.Instance.Select_By_ID_CTLDSB(IDChiTietLichDatSanBong);
            if (Get_Bill == null) return;
            IDBill = int.Parse(Get_Bill.Rows[0]["ID"].ToString());
            DataTable Get_ChiTietBill = BUS_ChiTietHoaDon.Instance.Select_By_IDHoaDon(IDBill);
            if (Get_ChiTietBill != null)
            {
                for (int i = 0; i < Get_ChiTietBill.Rows.Count; i++)
                {
                    int IDFWA = int.Parse(Get_ChiTietBill.Rows[i]["IDFWA"].ToString());
                    DataTable Get_FWA = BUS_FWA.Instance.Select_By_ID(IDFWA);
                    string Ten_FWA = Get_FWA.Rows[0]["TenFWA"].ToString();
                    int So_Luong = int.Parse(Get_ChiTietBill.Rows[i]["SoLuong"].ToString());
                    int GiaTien = So_Luong * int.Parse(Get_FWA.Rows[0]["GiaTien"].ToString());
                    Add_View_FWA(IDFWA, Ten_FWA, So_Luong, GiaTien);
                }
            }
            Update_TongTien();

           

        }
        public void Add_View_FWA(int Ma_FWA, string Ten_FWA, int SoLuong, int GiaTien)
        {
            var grid_fwa = grid_view_fwa.MainView as GridView;

            #region
            RepositoryItemButtonEdit Button_Cong = new RepositoryItemButtonEdit();
            RepositoryItemButtonEdit Button_Tru = new RepositoryItemButtonEdit();
            RepositoryItemButtonEdit Button_Xoa = new RepositoryItemButtonEdit();
            Button_Cong.BeginInit();
            Button_Tru.BeginInit();
            Button_Xoa.BeginInit();
            grid_view_fwa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { Button_Cong });
            grid_view_fwa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { Button_Tru });
            grid_view_fwa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { Button_Xoa });
            grid_fwa.Columns["Cộng"].ColumnEdit = Button_Cong;
            grid_fwa.Columns["Trừ"].ColumnEdit = Button_Tru;
            grid_fwa.Columns["Xóa"].ColumnEdit = Button_Xoa;

            Button_Cong.AutoHeight = false;
            Button_Cong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            Button_Cong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            Button_Cong.ButtonClick += Click_Cong_FWA;
            Button_Tru.AutoHeight = false;

            Button_Tru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus) });
            Button_Tru.Click += Click_Tru_FWA;
            Button_Tru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;

            Button_Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            Button_Xoa.Click += Click_Xoa_FWA;
            Button_Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            #endregion




            grid_fwa.AddNewRow();
            grid_fwa.SetFocusedRowCellValue(grid_fwa.Columns["Mã FWA"], Ma_FWA);
            grid_fwa.SetFocusedRowCellValue(grid_fwa.Columns["Tên FWA"], Ten_FWA);
            grid_fwa.SetFocusedRowCellValue(grid_fwa.Columns["Số Lượng"], SoLuong);
            grid_fwa.SetFocusedRowCellValue(grid_fwa.Columns["Giá Tiền"], GiaTien);

            /*grid_fwa.SetFocusedRowCellValue(grid_fwa.Columns["Thao Tác"], buttonCell);*/

            grid_fwa.UpdateCurrentRow();
        }
        public void Load_Check_Add_Bill()
        {
            DataTable San_Da_Co_Bill_Chua = BUS_Bill.Instance.Select_By_ID_CTLDSB(IDChiTietLichDatSanBong);

            if (San_Da_Co_Bill_Chua == null || San_Da_Co_Bill_Chua.Rows.Count == 0)
            {
                if (BUS_Bill.Instance.Insert(IDChiTietLichDatSanBong, IDKH, DateTime.Now, 0, 0) == false)
                {
                    XtraMessageBox.Show("Có Lỗi !!!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
        }
        public void Load_Column()
        {
            if (gridView1.Columns.Count == 0)
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("Mã FWA", typeof(int));
                dt.Columns.Add("Tên FWA", typeof(string));
                dt.Columns.Add("Số Lượng", typeof(int));
                dt.Columns.Add("Giá Tiền", typeof(int));
                dt.Columns.Add("Cộng", typeof(string));
                dt.Columns.Add("Trừ", typeof(string));
                dt.Columns.Add("Xóa", typeof(string));
                grid_view_fwa.DataSource = dt;
            }
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

        public void Load_FWA(DataTable Get_FWA)
        {
            flpFWA.Controls.Clear();
            if (Get_FWA != null)
            {
                for (int i = 0; i < Get_FWA.Rows.Count; i++)
                {
                    Flow_Add_FWA(Get_FWA.Rows[i]["ID"].ToString(), Get_FWA.Rows[i]["TenFWA"].ToString() + "\r\n" + int.Parse(Get_FWA.Rows[i]["GiaTien"].ToString()).ToString("c0", CultureInfo.GetCultureInfo("vi-VN")), Base64ToImage(Get_FWA.Rows[i]["image"].ToString()));
                }
            }
        }
        private void Click_Cong_FWA(object sender, EventArgs e)
        {
            // Get thông tin FWA từ form
            var grid_fwa = grid_view_fwa.MainView as GridView;
            int[] Select_Row_Index = grid_fwa.GetSelectedRows();
            DataRowView Get_Row_Select = (DataRowView)(grid_fwa.GetRow(Select_Row_Index[0]));
            // end get

            // lấy thông tin từ database
            DataTable Get_FWA = BUS_FWA.Instance.Select_By_ID(int.Parse(Get_Row_Select["Mã FWA"].ToString()));
            if (Get_FWA == null) return;
            DataTable Get_Bill = BUS_Bill.Instance.Select_By_ID_CTLDSB(IDChiTietLichDatSanBong);
            if (Get_Bill == null) return;
            // end lấy thông tin



            // xử lý
            int IDFWA_Grid = int.Parse(Get_Row_Select["Mã FWA"].ToString());
            int SoLuong_Grid = int.Parse(Get_Row_Select["Số Lượng"].ToString()) + 1;
            int GiaTien_Grid = int.Parse(Get_Row_Select["Giá Tiền"].ToString());
            int GiaTien_SQL  = int.Parse(Get_FWA.Rows[0]["GiaTien"].ToString());
            grid_fwa.SetRowCellValue(Select_Row_Index[0], grid_fwa.Columns["Giá Tiền"], GiaTien_Grid + GiaTien_SQL);
            grid_fwa.SetRowCellValue(Select_Row_Index[0], grid_fwa.Columns["Số Lượng"], SoLuong_Grid);
            BUS_ChiTietHoaDon.Instance.Update_By_IDBill_IDFWA(int.Parse(Get_Bill.Rows[0]["ID"].ToString()), IDFWA_Grid, SoLuong_Grid);
            Update_TongTien();
            // end xử lý
        }
        private void Click_Tru_FWA(object sender, EventArgs e)
        {
            // Get thông tin FWA từ form
            var grid_fwa = grid_view_fwa.MainView as GridView;
            int[] Select_Row_Index = grid_fwa.GetSelectedRows();
            DataRowView Get_Row_Select = (DataRowView)(grid_fwa.GetRow(Select_Row_Index[0]));
            // end get

            // lấy thông tin từ database
            DataTable Get_FWA = BUS_FWA.Instance.Select_By_ID(int.Parse(Get_Row_Select["Mã FWA"].ToString()));
            if (Get_FWA == null) return;
            DataTable Get_Bill = BUS_Bill.Instance.Select_By_ID_CTLDSB(IDChiTietLichDatSanBong);
            if (Get_Bill == null) return;
            // end lấy thông tin



            // xử lý
            int IDFWA_Grid = int.Parse(Get_Row_Select["Mã FWA"].ToString());
            int SoLuong_Grid = int.Parse(Get_Row_Select["Số Lượng"].ToString()) - 1;
            int GiaTien_Grid = int.Parse(Get_Row_Select["Giá Tiền"].ToString());
            int GiaTien_SQL = int.Parse(Get_FWA.Rows[0]["GiaTien"].ToString());
            if (SoLuong_Grid <= 0 || GiaTien_Grid - GiaTien_SQL < 0)
            {

            }else
            {
                grid_fwa.SetRowCellValue(Select_Row_Index[0], grid_fwa.Columns["Giá Tiền"], GiaTien_Grid - GiaTien_SQL);
                grid_fwa.SetRowCellValue(Select_Row_Index[0], grid_fwa.Columns["Số Lượng"], SoLuong_Grid);
                BUS_ChiTietHoaDon.Instance.Update_By_IDBill_IDFWA(int.Parse(Get_Bill.Rows[0]["ID"].ToString()), IDFWA_Grid, SoLuong_Grid);
                Update_TongTien();
                
            }
            // end xử lý
        }
        private void Click_Xoa_FWA(object sender, EventArgs e)
        {
            // Get thông tin FWA từ form
            var grid_fwa = grid_view_fwa.MainView as GridView;
            int[] Select_Row_Index = grid_fwa.GetSelectedRows();
            DataRowView Get_Row_Select = (DataRowView)(grid_fwa.GetRow(Select_Row_Index[0]));
            // end get

            // lấy thông tin từ database
            DataTable Get_FWA = BUS_FWA.Instance.Select_By_ID(int.Parse(Get_Row_Select["Mã FWA"].ToString()));
            if (Get_FWA == null) return;
            DataTable Get_Bill = BUS_Bill.Instance.Select_By_ID_CTLDSB(IDChiTietLichDatSanBong);
            if (Get_Bill == null) return;
            // end lấy thông tin



            // xử lý
            int IDFWA_Grid = int.Parse(Get_Row_Select["Mã FWA"].ToString());
            DialogResult del_confirm = XtraMessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa FWA Này !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (del_confirm == DialogResult.Yes)
            {
                if (BUS_ChiTietHoaDon.Instance.Delete_By_IDBill_IDFWA(IDBill, IDFWA_Grid) == true)
                {
                    XtraMessageBox.Show("Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_fwa.DeleteSelectedRows();
                }
                else
                {
                    XtraMessageBox.Show("Xóa Không Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Update_TongTien();
            // end xử lý
        }
        public void Update_TongTien()
        {
            var grid_fwa = grid_view_fwa.MainView as GridView;
            grid_fwa.UpdateCurrentRow();
            int TongTien = 0;
            for (int i = 0; i < grid_fwa.RowCount; i++)
            {
                DataRowView Get = (DataRowView)(grid_fwa.GetRow(i));
                int GiaTien_Grid = int.Parse(Get["Giá Tiền"].ToString());
                TongTien += GiaTien_Grid;
            }
            TongTien += TienSan_Global;
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTien.Text = TongTien.ToString("c0", culture);
            TongTien_Global = TongTien;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat_confirm = XtraMessageBox.Show("Bạn Thật Sự Muốn Thoát Hả !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thoat_confirm == DialogResult.Yes)
            {
                this.Close();
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int IDLoaiFWA = -1;
            if (cbeLoaiFWA.Text == "Nước uống")
            {
                IDLoaiFWA = 2;
            }
            else if (cbeLoaiFWA.Text == "Thức ăn")
            {
                IDLoaiFWA = 3;
            }
            else if (cbeLoaiFWA.Text == "Phụ kiện")
            {
                IDLoaiFWA = 1;
            }

            if (IDLoaiFWA != -1)
            {
                Load_FWA(BUS_FWA.Instance.Select_By_IDLoaiFWA(IDLoaiFWA));
            }
        }

        private void btnXoaLoc_Click(object sender, EventArgs e)
        {
            Load_FWA();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (TongTien_Global == 0)
            {
                XtraMessageBox.Show("Có Lỗi ! Không Thể Thanh Toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult TT_confirm = XtraMessageBox.Show("Bạn Thật Sự Muốn Thanh Toán Sân Bóng Này ? \n\n Tổng tiền: " + TongTien_Global.ToString() + " \n\n Giảm giá: " + nudGiamGia.Value.ToString() + "%", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TT_confirm == DialogResult.No)
            {
                return;
            }

            if (BUS_Bill.Instance.Update_Status_Bill(IDBill, DateTime.Now, ((int)nudGiamGia.Value), TongTien_Global, 1))
            {
                if (BUS_ChiTiet_LichDat_SanBong.Instance.Update(IDChiTietLichDatSanBong, 3) == false)
                {
                    XtraMessageBox.Show("Thanh Toán Không Thành Công !!! ! \n\nError: Lỗi Không Xác Định !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }else
                {
                    InHoaDon();
                    XtraMessageBox.Show("Thanh Toán Thành Công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
                


        }

        public void InHoaDon()
        {
            List<DTO_HoaDon> hoadon = new List<DTO_HoaDon>();
            hoadon.Add(new DTO_HoaDon("Tiền sân", 1, ((int)nudGiamGia.Value), TienSan_Global));
            DataTable Get_Bill = BUS_Bill.Instance.Select_By_ID(IDBill);
            if (Get_Bill == null) return;
            var grid_fwa = grid_view_fwa.MainView as GridView;
            for (int i = 0; i < grid_fwa.RowCount; i++)
            {
                DataRowView Get = (DataRowView)(grid_fwa.GetRow(i));
                int IDFWA = int.Parse(Get["Mã FWA"].ToString());
                string Ten_FWA = Get["Tên FWA"].ToString();
                int SoLuong = int.Parse(Get["Số Lượng"].ToString());
                int GiaTien_Grid = int.Parse(Get["Giá Tiền"].ToString());
                DataTable Get_FWA = BUS_FWA.Instance.Select_By_ID(IDFWA);

                hoadon.Add(new DTO_HoaDon(Ten_FWA, SoLuong, ((int)nudGiamGia.Value), int.Parse(Get_FWA.Rows[0]["GiaTien"].ToString())));
            }
            frmPrint InHoaDon = new frmPrint(IDBill, DateTime.Parse(Get_Bill.Rows[0]["NgayXuatBill"].ToString()), Select_KhachHang.Rows[0]["HoTen"].ToString(), Select_KhachHang.Rows[0]["SDT"].ToString(), hoadon);
            InHoaDon.ShowDialog();
            this.Show();
        }
    }
}