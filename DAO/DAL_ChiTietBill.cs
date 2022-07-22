using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietBill
    {
        private static DAL_ChiTietBill instance;

        public static DAL_ChiTietBill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTietBill();
                }
                return instance;
            }
            private set
            {
                DAL_ChiTietBill.instance = value;
            }
        }

        private DAL_ChiTietBill() { }

        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[ChiTietHoaDon]");
        }

        public DataTable Select_By_IDHoaDon(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[ChiTietHoaDon] Where IDHoaDon = '"+ID+"' ");
        }

        public DataTable Select_By_IDFWA(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[ChiTietHoaDon] Where IDFWA = '" + ID + "' ");
        }
        public bool Insert(int IDBill, int IDFWA, int SoLuong)
        {
            int insert_CTHD = DAL_DB.Instance.ThuThi_NonQuery(
               "INSERT INTO [dbo].[ChiTietHoaDon] ([IDHoaDon],[IDFWA],[SoLuong]) " +
               "VALUES " +
                                       "('" + IDBill + "', N'" + IDFWA + "', '" + SoLuong + "')");
            if (insert_CTHD > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update_By_IDBill_IDFWA(int IDBill, int IDFWA, int SoLuong)
        {
            int update_CTB = DAL_DB.Instance.ThuThi_NonQuery("Update dbo.ChiTietHoaDon Set SoLuong = '" + SoLuong + "' Where IDHoaDon = '" + IDBill + "' And IDFWA = '" + IDFWA + "'");
            if (update_CTB > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete_By_IDBill_IDFWA(int IDBill, int IDFWA)
        {

            if (DAL_DB.Instance.ThuThi_NonQuery("Delete From dbo.ChiTietHoaDon Where IDHoaDon = '" + IDBill + "' AND IDFWA = '" + IDFWA + "'") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
