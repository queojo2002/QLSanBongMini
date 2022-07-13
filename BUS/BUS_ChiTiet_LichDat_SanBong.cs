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
        public bool Update(int ID, int TrangThai)
        {
            return DAL_ChiTiet_LichDat_SanBong.Instance.Update(ID, TrangThai);
        }

    }
}
