using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LichDat_SanBong
    {
        private static BUS_LichDat_SanBong instance;

        public static BUS_LichDat_SanBong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_LichDat_SanBong();
                }
                return instance;
            }
            private set
            {
                BUS_LichDat_SanBong.instance = value;
            }
        }

        private BUS_LichDat_SanBong() { }


        public DataTable Select()
        {
            return DAL_LichDat_SanBong.Instance.Select();
        }

        public string Insert_CoDinh(int ID_KVSB, int ID_KH, DateTime NgayDat_BatDau, DateTime NgayDat_KetThuc, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc, bool thu_2, bool thu_3, bool thu_4, bool thu_5, bool thu_6, bool thu_7, bool cn, string GhiChu)
        {
            return DAL_LichDat_SanBong.Instance.Insert_CoDinh(ID_KVSB, ID_KH, NgayDat_BatDau, NgayDat_KetThuc, KhungGio_BatDau, KhungGio_KetThuc, thu_2, thu_3, thu_4, thu_5, thu_6, thu_7, cn, GhiChu);
        }

        public string Insert_TheoNgay(int ID_KVSB, int ID_KH, DateTime NgayDat_BatDau, DateTime NgayDat_KetThuc, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc, string GhiChu)
        {
            return DAL_LichDat_SanBong.Instance.Insert_TheoNgay(ID_KVSB, ID_KH, NgayDat_BatDau, NgayDat_KetThuc, KhungGio_BatDau, KhungGio_KetThuc, GhiChu);
        }
    }
}
