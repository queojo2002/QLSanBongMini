using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuVuc_SanBong
    {
        private static BUS_KhuVuc_SanBong instance;

        public static BUS_KhuVuc_SanBong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KhuVuc_SanBong();
                }
                return instance;
            }
            private set
            {
                BUS_KhuVuc_SanBong.instance = value;
            }
        }

        private BUS_KhuVuc_SanBong() { }

        public DataTable Select()
        {
            return DAL_KhuVuc_SanBong.Instance.Select();
        }
        public DataTable Select_By_ID(int ID)
        {
            return DAL_KhuVuc_SanBong.Instance.Select_By_ID(ID);
        }
        public bool Insert(string Ten, int GiaTien, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc)
        {
            return DAL_KhuVuc_SanBong.Instance.Insert(Ten, GiaTien, KhungGio_BatDau, KhungGio_KetThuc);
        }
        public bool Update_By_ID(int ID, string Ten, int GiaTien)
        {
            return DAL_KhuVuc_SanBong.Instance.Update_By_ID(ID, Ten, GiaTien);
        }

        public bool Delete_By_ID(int ID)
        {
            return DAL_KhuVuc_SanBong.Instance.Delete_By_ID(ID);
        }

    }
}
