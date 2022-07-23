using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_FWA
    {
        private static DAL_FWA instance;

        public static DAL_FWA Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_FWA();
                }
                return instance;
            }
            private set
            {
                DAL_FWA.instance = value;
            }
        }

        private DAL_FWA() { }


        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[FWA]");
        }
        public DataTable Select_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[FWA] Where ID = '"+ID+"'");
        }
        public DataTable Select_By_IDLoaiFWA(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[FWA] Where IDLoaiFWA = '" + ID + "'");
        }
        public bool Insert(int IDLoaiFWA, string TenFWA, int GiaTien, string img)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[FWA] ([IDLoaiFWA],[TenFWA],[GiaTien],[image]) VALUES ('" + IDLoaiFWA + "',N'" + TenFWA + "','" + GiaTien + "',CONVERT(varchar(max), '" + img + "', 0))") > 0 ? true : false;
        }

        public bool Update(int IDFWA, int IDLoaiFWA, string TenFWA, int GiaTien, string img)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("UPDATE [dbo].[FWA] SET [IDLoaiFWA] = '"+IDLoaiFWA+ "' ,[TenFWA] = N'" + TenFWA + "' ,[GiaTien] = '" + GiaTien + "' ,[image] = CONVERT(varchar(max), '" + img + "', 0) WHERE ID = '" + IDFWA +"'") > 0 ? true : false;
        }
        public bool Update(int IDFWA, int IDLoaiFWA, string TenFWA, int GiaTien)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("UPDATE [dbo].[FWA] SET [IDLoaiFWA] = '" + IDLoaiFWA + "' ,[TenFWA] = N'" + TenFWA + "' ,[GiaTien] = '" + GiaTien + "'  WHERE ID = '" + IDFWA + "'") > 0 ? true : false;
        }
        public bool Delete(int IDFWA)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("DELETE FROM [dbo].[FWA] WHERE ID = '" + IDFWA + "'") > 0 ? true : false;
        }

    }
}
