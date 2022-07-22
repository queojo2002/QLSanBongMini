using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Bill
    {
        private static BUS_Bill instance;

        public static BUS_Bill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Bill();
                }
                return instance;
            }
            private set
            {
                BUS_Bill.instance = value;
            }
        }

        private BUS_Bill() { }
        public DataTable Select()
        {
            return DAL_Bill.Instance.Select();
        }

        public DataTable Select_By_ID(int ID)
        {
            return DAL_Bill.Instance.Select_By_ID(ID);
        }

        public DataTable Select_By_ID_CTLDSB(int ID)
        {
            return DAL_Bill.Instance.Select_By_ID_CTLDSB(ID);
        }

        public DataTable Select_Xem_DoanhThu(DateTime TuNgay, DateTime DenNgay)
        {
            return DAL_Bill.Instance.Select_Xem_DoanhThu(TuNgay, DenNgay);
        }
        public bool Insert(int IDCTLDSB, int IDKhachHang, DateTime NgayLap_Bill, int ThanhTien, int TrangThai)
        {
            return DAL_Bill.Instance.Insert(IDCTLDSB, IDKhachHang, NgayLap_Bill, ThanhTien, TrangThai);
        }
        public bool Update_Status_Bill(int IDBill, DateTime NgayXuatBill, int GiamGia, int ThanhTien, int TrangThai)
        {
            return DAL_Bill.Instance.Update_Status_Bill(IDBill, NgayXuatBill, GiamGia, ThanhTien, TrangThai);
        }
    }
}
