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
using DevExpress.XtraGrid.Views.Grid;

namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_LichDat_SanBong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_LichDat_SanBong()
        {
            InitializeComponent();
        }

        public void Load_Column()
        {
            if (gridView1.Columns.Count == 0)
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Khu vực sân bóng", typeof(string));
                dt.Columns.Add("Tên khách hàng đặt", typeof(string));
                dt.Columns.Add("SĐT khách hàng đặt", typeof(string));
                dt.Columns.Add("Ngày đặt bắt đầu", typeof(DateTime));
                dt.Columns.Add("Ngày đặt kết thúc", typeof(DateTime));
                dt.Columns.Add("Khung giờ bắt đầu", typeof(TimeSpan));
                dt.Columns.Add("Khung giờ kết thúc", typeof(TimeSpan));
                gcViewLDSB.DataSource = dt;
            }
        }
        public void Add_Row(int ID, string Ten_KVSB, string Ten_NguoiDat, string SDT_NguoiDat, DateTime NgayDat_BatDau, DateTime NgayDat_KetThuc, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc)
        {
            var grid_view_ldsb = gcViewLDSB.MainView as GridView;
            grid_view_ldsb.AddNewRow();
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["ID"], ID);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["Khu vực sân bóng"], Ten_KVSB);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["Tên khách hàng đặt"], Ten_NguoiDat);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["SĐT khách hàng đặt"], SDT_NguoiDat);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["Ngày đặt bắt đầu"], NgayDat_BatDau);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["Ngày đặt kết thúc"], NgayDat_KetThuc);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["Khung giờ bắt đầu"], KhungGio_BatDau);
            grid_view_ldsb.SetFocusedRowCellValue(grid_view_ldsb.Columns["Khung giờ kết thúc"], KhungGio_KetThuc);
            grid_view_ldsb.UpdateCurrentRow();
        }
        public void Load_Data()
        {
            DataTable Get_LDSB = BUS_LichDat_SanBong.Instance.Select();
            if (Get_LDSB == null || Get_LDSB.Rows.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < Get_LDSB.Rows.Count;i++)
            {
                DataTable Get_LDSB_By_ID = BUS_LichDat_SanBong.Instance.Select_By_ID(int.Parse(Get_LDSB.Rows[i]["ID"].ToString()));
                if (Get_LDSB_By_ID == null || Get_LDSB_By_ID.Rows.Count <= 0) continue;
                int ID = int.Parse(Get_LDSB_By_ID.Rows[0]["ID"].ToString());
                string Ten_KVSB = Get_LDSB_By_ID.Rows[0]["Ten"].ToString();
                string Ten_NguoiDat = Get_LDSB_By_ID.Rows[0]["HoTen"].ToString();
                string SDT_NguoiDat = Get_LDSB_By_ID.Rows[0]["SDT"].ToString();
                DateTime NgayDat_BatDau = DateTime.Parse(Get_LDSB_By_ID.Rows[0]["NgayDat_BatDau"].ToString());
                DateTime NgayDat_KetThuc = DateTime.Parse(Get_LDSB_By_ID.Rows[0]["NgayDat_KetThuc"].ToString());
                TimeSpan KhungGio_BatDau = TimeSpan.Parse(Get_LDSB_By_ID.Rows[0]["KhungGioDat_BatDau"].ToString());
                TimeSpan KhungGio_KetThuc = TimeSpan.Parse(Get_LDSB_By_ID.Rows[0]["KhungGioDat_KetThuc"].ToString());
                Add_Row(ID, Ten_KVSB, Ten_NguoiDat, SDT_NguoiDat, NgayDat_BatDau, NgayDat_KetThuc, KhungGio_BatDau, KhungGio_KetThuc);
            }
        }

        public void Reload()
        {
            gcViewLDSB.DataSource = null;
            gridView1.Columns.Clear();
            Load_Column();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmQuanLy_LichDat_SanBong_Them them = new frmQuanLy_LichDat_SanBong_Them();
            them.ShowDialog();
            Reload();
            Load_Data();
            this.Show();
        }

        private void frmQuanLy_LichDat_SanBong_Load(object sender, EventArgs e)
        {
            Load_Column();
            Load_Data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gcViewLDSB.MainView).GetSelectedRows();
            if (selRows.Length > 0)
            {
                DialogResult delete_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa lịch đặt sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete_confirm == DialogResult.Yes)
                {
                    DataRowView selRow = (DataRowView)(((GridView)gcViewLDSB.MainView).GetRow(selRows[0]));
                    if (BUS_LichDat_SanBong.Instance.Delete_By_ID(int.Parse(selRow["ID"].ToString())) == true && BUS_ChiTiet_LichDat_SanBong.Instance.Delete_By_IDLDSB(int.Parse(selRow["ID"].ToString())))
                    {
                        Reload();
                        Load_Data();
                        XtraMessageBox.Show("Xóa khu vực sân bóng thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Reload();
                        Load_Data();
                        XtraMessageBox.Show("Có lỗi khi Xóa !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gcViewLDSB.MainView).GetSelectedRows();
            if (selRows.Length > 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)gcViewLDSB.MainView).GetRow(selRows[0]));
                int ID = int.Parse(selRow["ID"].ToString());
                frmQuanLy_LichDat_SanBong_XemChiTiet xemChiTiet = new frmQuanLy_LichDat_SanBong_XemChiTiet(ID);
                xemChiTiet.ShowDialog();
                this.Show();



            }
        }


    }
}