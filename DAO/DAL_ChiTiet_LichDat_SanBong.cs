using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool Insert(int ID_LDSB, int ID_KVSB, int ID_KH, DateTime NgayDat, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc, string GhiChu)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[ChiTietLichDat_SanBong] ([ID_LDSB],[ID_KVSB],[ID_KH],[NgayDat],[KhungGio_BatDat],[KhungGio_KetThuc],[GhiChu],[TrangThai]) VALUES ('"+ ID_LDSB + "','" + ID_KVSB + "','" + ID_KH + "','" + NgayDat + "','" + KhungGio_BatDau + "','" + KhungGio_KetThuc + "',N'" + GhiChu + "',1)") > 0 ? true : false;
        }

        public bool Update(int ID, int TrangThai)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("Update dbo.ChiTietLichDat_SanBong Set TrangThai = '" + TrangThai + "' Where ID = '" + ID + "'") > 0 ? true:false;
        }
    }
}
