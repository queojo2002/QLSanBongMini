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
            DataTable doanhthu = BUS_Bill.Instance.Select_Xem_DoanhThu();
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
                    string Ten_KVSB = doanhthu.Rows[i]["Ten"].ToString();
                    string HoTen = doanhthu.Rows[i]["HoTen"].ToString();
                    string SDT = doanhthu.Rows[i]["SDT"].ToString();
                    DateTime NgayXuatBill = DateTime.Parse(doanhthu.Rows[i]["NgayLapBill"].ToString());
                    DateTime NgayLapBill = DateTime.Parse(doanhthu.Rows[i]["NgayXuatBill"].ToString());
                    int ThanhTien = int.Parse(doanhthu.Rows[i]["ThanhTien"].ToString());
                    int GiamGia = int.Parse(doanhthu.Rows[i]["GiamGia"].ToString());
                    TongDoanhThu_GiamGia += (int)(ThanhTien - (ThanhTien * (((double)GiamGia) / 100)));
                    TongDoanhThu += ThanhTien;
                    Add_Row_DoanhThu(Ten_KVSB, HoTen, SDT, NgayLapBill, NgayXuatBill, ThanhTien, GiamGia);
                }
            }
            lblTongDoanhThu.Text = "Tổng doanh thu trước khi áp dụng giảm giá: " + TongDoanhThu.ToString("c0", CultureInfo.GetCultureInfo("vi-VN")) + "\n\n Tổng doanh thu sau khi áp dụng giảm giá: " + TongDoanhThu_GiamGia.ToString("c0", CultureInfo.GetCultureInfo("vi-VN"));
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
                    string Ten_KVSB = doanhthu.Rows[i]["Ten"].ToString();
                    string HoTen = doanhthu.Rows[i]["HoTen"].ToString();
                    string SDT = doanhthu.Rows[i]["SDT"].ToString();
                    DateTime NgayXuatBill = DateTime.Parse(doanhthu.Rows[i]["NgayLapBill"].ToString());
                    DateTime NgayLapBill = DateTime.Parse(doanhthu.Rows[i]["NgayXuatBill"].ToString());
                    int ThanhTien = int.Parse(doanhthu.Rows[i]["ThanhTien"].ToString());
                    int GiamGia = int.Parse(doanhthu.Rows[i]["GiamGia"].ToString());
                    TongDoanhThu_GiamGia += (int)(ThanhTien - (ThanhTien * (((double)GiamGia) / 100)));
                    TongDoanhThu += ThanhTien;
                    Add_Row_DoanhThu(Ten_KVSB, HoTen, SDT, NgayLapBill, NgayXuatBill, ThanhTien, GiamGia);
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
                dt.Columns.Add("Khu vực sân bóng", typeof(string));
                dt.Columns.Add("Tên khách hàng", typeof(string));
                dt.Columns.Add("SĐT khách hàng", typeof(string));
                dt.Columns.Add("Ngày lập hóa đơn", typeof(DateTime));
                dt.Columns.Add("Ngày xuất hóa đơn", typeof(DateTime));
                dt.Columns.Add("Thành tiền", typeof(int));
                dt.Columns.Add("Giảm giá", typeof(int));
                gridC_view_doanhthu.DataSource = dt;
            }
        }
        public void Add_Row_DoanhThu(string Ten_KVSB, string HoTen, string SDT, DateTime NgayLapBill, DateTime NgayXuatBill, int ThanhTien, int GiamGia)
        {
            var Grid_DoanhThu = gridC_view_doanhthu.MainView as GridView;
            Grid_DoanhThu.UpdateCurrentRow();
            Grid_DoanhThu.AddNewRow();
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Khu vực sân bóng"], Ten_KVSB);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Tên khách hàng"], HoTen);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["SĐT khách hàng"], SDT);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Ngày lập hóa đơn"], NgayLapBill);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Ngày xuất hóa đơn"], NgayXuatBill);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Thành tiền"], ThanhTien);
            Grid_DoanhThu.SetFocusedRowCellValue(Grid_DoanhThu.Columns["Giảm giá"], GiamGia);
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            InDoanhThu();
        }

        public void InDoanhThu()
        {
            List<DTO_DoanhThu> doanhthu = new List<DTO_DoanhThu>();
            var grid_dt = gridC_view_doanhthu.MainView as GridView;
            for (int i = 0; i < grid_dt.RowCount; i++)
            {
                DataRowView Get = (DataRowView)(grid_dt.GetRow(i));
                string Ten_KVSB = Get["Khu vực sân bóng"].ToString();
                string HoTen = Get["Tên khách hàng"].ToString();
                string SDT = Get["SĐT khách hàng"].ToString();
                DateTime NgayXuatBill = DateTime.Parse(Get["Ngày xuất hóa đơn"].ToString());
                DateTime NgayLapBill = DateTime.Parse(Get["Ngày lập hóa đơn"].ToString());
                int ThanhTien = int.Parse(Get["Thành tiền"].ToString());
                int GiamGia = int.Parse(Get["Giảm giá"].ToString());

                doanhthu.Add(new DTO_DoanhThu(Ten_KVSB, HoTen, SDT, NgayXuatBill, NgayLapBill, ThanhTien, GiamGia));
            }
            frmPrint InDoanhThu = new frmPrint("Báo cáo doanh thu", doanhthu);
            InDoanhThu.ShowDialog();
            this.Show();
        }
    }
}