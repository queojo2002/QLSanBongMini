using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_ChiTiet_LichDat_SanBong
    {
        private static BUS_ChiTiet_LichDat_SanBong instance;

        public static BUS_ChiTiet_LichDat_SanBong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTiet_LichDat_SanBong();
                }
                return instance;
            }
            private set
            {
                BUS_ChiTiet_LichDat_SanBong.instance = value;
            }
        }

        private BUS_ChiTiet_LichDat_SanBong() { }

        public DataTable Select()
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Select();
        }
        public DataTable Select(int ID)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Select(ID);
        }
        public DataTable Select_By_IDLDSB(int ID_LDSB)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Select_By_IDLDSB(ID_LDSB);
        }
        public bool Update(int ID, int TrangThai)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Update(ID, TrangThai);
        }
        public bool Update(int ID, int IDKhachHang, string GhiChu, int TrangThai)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Update(ID, IDKhachHang, GhiChu, TrangThai);
        }

        public DataTable Search(int ID_KH, int ID_KVSB, DateTime NgayDat)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Search(ID_KH, ID_KVSB, NgayDat);
        }
        public bool Delete_By_IDLDSB(int ID_LDSB)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Delete_By_IDLDSB(ID_LDSB);
        }
    }
}
