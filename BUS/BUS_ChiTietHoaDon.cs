using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        private static BUS_ChiTietHoaDon instance;

        public static BUS_ChiTietHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietHoaDon();
                }
                return instance;
            }
            private set
            {
                BUS_ChiTietHoaDon.instance = value;
            }
        }

        private BUS_ChiTietHoaDon() { }

        public DataTable Select()
        {
            return DAL_ChiTietBill.Instance.Select();
        }

        public DataTable Select_By_IDHoaDon(int ID)
        {
            return DAL_ChiTietBill.Instance.Select_By_IDHoaDon(ID);
        }

        public DataTable Select_By_IDFWA(int ID)
        {
            return DAL_ChiTietBill.Instance.Select_By_IDFWA(ID);
        }

        public bool Insert(int IDBill, int IDFWA, int SoLuong)
        {
            return DAL_ChiTietBill.Instance.Insert(IDBill, IDFWA, SoLuong);
        }

        public bool Update_By_IDBill_IDFWA(int IDBill, int IDFWA, int SoLuong)
        {
            return DAL_ChiTietBill.Instance.Update_By_IDBill_IDFWA(IDBill, IDFWA, SoLuong);
        }
        public bool Delete_By_IDBill_IDFWA(int IDBill, int IDFWA)
        {
            return DAL_ChiTietBill.Instance.Delete_By_IDBill_IDFWA(IDBill, IDFWA);
        }
    }
}
