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

        public bool Insert(int IDLoaiFWA, string TenFWA, int GiaTien, string img)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[FWA] ([IDLoaiFWA],[TenFWA],[GiaTien],[image]) VALUES ('"+IDLoaiFWA+ "','" + TenFWA + "','" + GiaTien + "',CONVERT(varchar(max), '" + img + "', 0))") > 0 ? true:false;
        }

    }
}
