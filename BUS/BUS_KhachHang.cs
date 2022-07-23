using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_KhachHang
    {
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KhachHang();
                }
                return instance;
            }
            private set
            {
                BUS_KhachHang.instance = value;
            }
        }

        private BUS_KhachHang() { }

        public DataTable Select()
        {
            return DAL_KhachHang.Instance.Select();
        }

        public DataTable Select_By_ID(int ID)
        {
            return DAL_KhachHang.Instance.Select_By_ID(ID);
        }
        public bool Insert(string HoTen, string SDT)
        {
            return DAL_KhachHang.Instance.Insert(HoTen, SDT);
        }
        public bool Insert(string HoTen, string SDT, string FB, int SoLanDat)
        {
            return DAL_KhachHang.Instance.Insert(HoTen, SDT, FB, SoLanDat);
        }
        public bool Update(int ID, string HoTen, string SDT, string FB, int SoLanDat)
        {
            return DAL_KhachHang.Instance.Update(ID, HoTen, SDT, FB, SoLanDat);
        }
        public bool Update_SoLanDat(int ID)
        {
            return DAL_KhachHang.Instance.Update_SoLanDat(ID);
        }
        public bool Delete_By_ID(int ID)
        {
            return DAL_KhachHang.Instance.Delete_By_ID(ID);
        }

    }
}
