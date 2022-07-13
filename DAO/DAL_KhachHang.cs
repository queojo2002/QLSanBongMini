using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_KhachHang();
                }
                return instance;
            }
            private set
            {
                DAL_KhachHang.instance = value;
            }
        }

        private DAL_KhachHang() { }


        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[KhachHang]");
        }
        public DataTable Select_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[KhachHang] Where ID = '"+ID+"'");
        }
        public bool Insert(string HoTen, string SDT)
        {
            if (this.Select() != null)
            {
                for (int i = 0; i < this.Select().Rows.Count;i++)
                {
                    if (this.Select().Rows[i]["SDT"].Equals(SDT))
                    {
                        return false;
                    }
                }
            }
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[KhachHang]([HoTen],[SDT]) VALUES " +
              "(" +
              "N'" + HoTen + "','" +
              SDT +
              "')") > 0 ? true : false;
        }
        public bool Insert(string HoTen, string SDT, string FB, int SoLanDat)
        {
            if (this.Select() != null)
            {
                for (int i = 0; i < this.Select().Rows.Count; i++)
                {
                    if (this.Select().Rows[i]["SDT"].Equals(SDT))
                    {
                        return false;
                    }
                }
            }
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[KhachHang] ([HoTen],[SDT],[FB],[SoLanDat]) VALUES ('"+ HoTen + "','" + SDT + "','" + FB  + "','" + SoLanDat + "')") > 0 ? true : false;
        }


        public bool Update(int ID, string HoTen, string SDT, string FB, int SoLanDat)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("UPDATE [dbo].[KhachHang] SET [HoTen] = N'"+HoTen+ "',[SDT] = '" + SDT + "',[FB] = N'" + FB + "',[SoLanDat] = '" + SoLanDat + "' WHERE ID = '"+ID+"' ") > 0 ?true:false;
        }

        public bool Delete_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("DELETE FROM [dbo].[KhachHang] WHERE ID = '"+ID+"' ") > 0 ? true : false;
        }
    }
}
