using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_ChiTiet_LichDat_SanBong
    {
        private static DAL_ChiTiet_LichDat_SanBong instance;

        public static DAL_ChiTiet_LichDat_SanBong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTiet_LichDat_SanBong();
                }
                return instance;
            }
            private set
            {
                DAL_ChiTiet_LichDat_SanBong.instance = value;
            }
        }

        private DAL_ChiTiet_LichDat_SanBong() { }


        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[ChiTietLichDat_SanBong] ORDER BY KhungGio_BatDat ASC");
        }
        public DataTable Select(int IDChiTietLichDatSanBong)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[ChiTietLichDat_SanBong] Where ID = '" + IDChiTietLichDatSanBong + "' ORDER BY KhungGio_BatDat ASC");
        }
        public bool Insert(int ID_LDSB, int ID_KVSB, int ID_KH, DateTime NgayDat, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc, string GhiChu)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[ChiTietLichDat_SanBong] ([ID_LDSB],[ID_KVSB],[ID_KH],[NgayDat],[KhungGio_BatDat],[KhungGio_KetThuc],[GhiChu],[TrangThai]) VALUES ('"+ ID_LDSB + "','" + ID_KVSB + "','" + ID_KH + "','" + NgayDat.ToString("yyyy-MM-dd") + "','" + KhungGio_BatDau + "','" + KhungGio_KetThuc + "',N'" + GhiChu + "',1)") > 0 ? true : false;
        }

        public bool Update(int ID, int TrangThai)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("Update dbo.ChiTietLichDat_SanBong Set TrangThai = '" + TrangThai + "' Where ID = '" + ID + "'") > 0 ? true:false;
        }

        public bool Update(int ID, int IDKhachHang, string GhiChu, int TrangThai)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("Update dbo.ChiTietLichDat_SanBong Set TrangThai = '" + TrangThai + "', GhiChu = '"+GhiChu+"', ID_KH = '"+IDKhachHang+"' Where ID = '" + ID + "'") > 0 ? true : false;
        }

        public DataTable Search(int ID_KH, int ID_KVSB, DateTime NgayDat)
        {
            string SQL = "";
            if (ID_KH > -1 && ID_KVSB > -1 && NgayDat.Year.ToString() != "1")
            {
                SQL = "ID_KH = '" + ID_KH + "' AND ID_KVSB = '" + ID_KVSB + "' AND NgayDat = '" + NgayDat.ToString("yyyy-MM-dd") + "'";
            }else if (ID_KH > - 1 && ID_KVSB > -1 && NgayDat.Year.ToString() == "1")
            {
                SQL = "ID_KH = '" + ID_KH + "' AND ID_KVSB = '" + ID_KVSB + "'";
            }
            else if (ID_KH > -1 && ID_KVSB == -1 && NgayDat.Year.ToString() != "1")
            {
                SQL = "ID_KH = '" + ID_KH + "' AND NgayDat = '" + NgayDat.ToString("yyyy-MM-dd") + "'";
            }
            else if (ID_KH == -1 && ID_KVSB > -1 && NgayDat.Year.ToString() != "1")
            {
                SQL = "ID_KVSB = '" + ID_KVSB + "' AND NgayDat = '" + NgayDat.ToString("yyyy-MM-dd") + "'";
            }
            else if (ID_KH > -1 && ID_KVSB == -1 && NgayDat.Year.ToString() == "1")
            {
                SQL = "ID_KH = '" + ID_KH + "'";
            }
            else if (ID_KH == -1 && ID_KVSB > -1 && NgayDat.Year.ToString() == "1")
            {
                SQL = "ID_KVSB = '" + ID_KVSB + "'";
            }
            else if (ID_KH == -1 && ID_KVSB == -1 && NgayDat.Year.ToString() != "1")
            {
                SQL = "NgayDat = '" + NgayDat.ToString("yyyy-MM-dd") + "'";
            }

            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[ChiTietLichDat_SanBong] Where " + SQL + " ORDER BY KhungGio_BatDat ASC");



        }

    }
}
