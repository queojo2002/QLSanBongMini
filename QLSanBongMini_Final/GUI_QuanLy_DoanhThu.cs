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
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid;
using DTO;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_DoanhThu : DevExpress.XtraEditors.XtraForm
    {
        List<DTO_KhuVuc_SanBong> KVSB = new List<DTO_KhuVuc_SanBong>();
        private int TongDoanhThu = 0;
        private int TongDoanhThu_GiamGia = 0;

        public frmQuanLy_DoanhThu()
        {
            InitializeComponent();
        }




        private void frmQuanLy_DoanhThu_Load(object sender, EventArgs e)
        {
            Add_Column_DoanhThu();
            Load_Data_DoanhThu();
        }
        private void btnTailai_Click(object sender, EventArgs e)
        {
            Reload();
            DE_TuNgay.Text = "";
            DE_DenNgay.Text = "";
            Load_Data_DoanhThu();
        }


        public void Reload()
        {
            gridC_view_doanhthu.DataSource = null;
            gridView1.Columns.Clear();
            TongDoanhThu = 0;
            TongDoanhThu_GiamGia = 0;
            Add_Column_DoanhThu();
        }
       
        public void Load_Data_DoanhThu()
        {
            DataTable doanhthu = BUS_Bill.Instance.Select();
            if (doanhthu == null || doanhthu.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Hiện tại chưa có doanh thu !!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            for(int i = 0; i < doanhthu.Rows.Count; i++)
            {
                if (doanhthu.Rows[i]["TrangThai"].ToString() != "0")
                {
                    int IDCTLDSB = int.Parse(doanhthu.Rows[i]["IDCTLDSB"].ToString());
                    int IDKhachHang = int.Parse(doanhthu.Rows[i]["IDKhachHang"].ToString());
                    DateTime NgayLapBill = DateTime.Parse(doanhthu.Rows[i]["NgayLapBill"].ToString());
                    DateTime NgayXuatBill = DateTime.Parse(doanhthu.Rows[i]["NgayXuatBill"].ToString());
                    int ThanhTien = int.Parse(doanhthu.Rows[i]["ThanhTien"].ToString());
                    int GiamGia = int.Parse(doanhthu.Rows[i]["GiamGia"].ToString());
                    TongDoanhThu_GiamGia += (int)(ThanhTien - (ThanhTien * (((double)GiamGia) / 100)));
                    TongDoanhThu += ThanhTien;
                Add_Row_DoanhThu(IDCTLDSB, IDKhachHang, NgayLapBill, NgayXuatBill, ThanhTien, GiamGia, "Đã thanh toán");
                }
            }
            lblTongDoanhThu.Text = "Tổng doanh thu trước khi áp dụng giảm giá: : " + TongDoanhThu.ToString("c0", CultureInfo.GetCultureInfo("vi-VN")) + "\n\n Tổng doanh thu sau khi áp dụng giảm giá: " + TongDoanhThu_GiamGia.ToString("c0", CultureInfo.GetCultureInfo("vi-VN"));
        }
        public void Load_Data_DoanhThu(DataTable doanhthu)
        {
            if (doanhthu == null || doanhthu.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Hiện tại chưa có doanh thu !!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            for (int i = 0; i < doanhthu.Rows.Count; i++)
            {
                if (doanhthu.Rows[i]["TrangThai"].ToString() != "0")
                {
                    int IDCTLDSB = int.Parse(doanhthu.Rows[i]["IDCTLDSB"].ToString());
                    int IDKhachHang = int.Parse(doanhthu.Rows[i]["IDKhachHang"].ToString());
                    DateTime NgayLapBill = DateTime.Parse(doanhthu.Rows[i]["NgayLapBill"].ToString());
                    DateTime NgayXuatBill = DateTime.Parse(doanhthu.Rows[i]["NgayXuatBill"].ToString());
                    int ThanhTien = int.Parse(doanhthu.Rows[i]["ThanhTien"].ToString());
                    int GiamGia = int.Parse(doanhthu.Rows[i]["GiamGia"].ToString());
                    TongDoanhThu_GiamGia += (int)(ThanhTien - (ThanhTien * (((double)GiamGia) / 100)));
                    TongDoanhThu += ThanhTien;
                    Add_Row_DoanhThu(IDCTLDSB, IDKhachHang, NgayLapBill, NgayXuatBill, ThanhTien, GiamGia, "Đã thanh toán");
                }
            }
            lblTongDoanhThu.Text = "Tổng doanh thu trước khi áp dụng giảm giá: : " + TongDoanhThu.ToString("c0", CultureInfo.GetCultureInfo("vi-VN")) + "\n\n Tổng doanh thu sau khi áp dụng giảm giá: " + TongDoanhThu_GiamGia.ToString("c0", CultureInfo.GetCultureInfo("vi-VN"));
        }

        public void Add_Column_DoanhThu()
        {
            if (gridView1.Columns.Count == 0)
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("ID Chi Tiết Lịch Đặt Sân Bóng", typeof(int));
                dt.Columns.Add("ID Khách Hàng", typeof(int));
                dt.Columns.Add("Ngày Lập Bill", typeof(DateTime));
                dt.Columns.Add("Ngày Xuất Bill", typeof(DateTime));
                dt.Columns.Add("Thành Tiền", typeof(int));
                dt.Columns.Add("Giảm Giá", typeof(int));
                dt.Columns.Add("Trạng Thái", typeof(string));
                gridC_view_doanhthu.DataSource = dt;
            }
        }
        public void Add_Row_DoanhThu(int IDCTLDSB, int IDKhachHang, DateTime NgayLapBill, DateTime NgayXuatBill, int ThanhTien, int GiamGia, string TrangThai)
        {
            var Grid_DoanhThu = gridC_view_doanhthu.MainView as GridView;
            Grid_DoanhThu.UpdateCurrentRow();
            Grid_DoanhThu.AddNewRow();
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["ID Chi Tiết Lịch Đặt Sân Bóng"], IDCTLDSB);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["ID Khách Hàng"], IDKhachHang);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Ngày Lập Bill"], NgayLapBill);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Ngày Xuất Bill"], NgayXuatBill);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Thành Tiền"], ThanhTien);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Giảm Giá"], GiamGia);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Trạng Thái"], TrangThai);
            Grid_DoanhThu.UpdateCurrentRow();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {


            if (DE_TuNgay.Text != string.Empty && DE_DenNgay.Text != string.Empty)
            {
                Reload();
                Load_Data_DoanhThu(BUS_Bill.Instance.Select_Xem_DoanhThu(DE_TuNgay.DateTime, DE_DenNgay.DateTime));
            }    

            

        }
    }
}