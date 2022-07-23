using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_TaiKhoan();
                }
                return instance;
            }
            private set
            {
                DAL_TaiKhoan.instance = value;
            }
        }

        private DAL_TaiKhoan() { }

        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[Account]");

        }
        public DataTable Select_By_Username(string Username)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[Account] where Username = '" + Username + "'");

        }
        public bool Update_By_UserName(string Username, string Password, string Displayname, string Chucvu)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("UPDATE [dbo].[Account] SET [Password] = '" + Password + "' ,[DisplayName] = N'" + Displayname + "' ,[UserType] = '" + Chucvu + "' WHERE Username = '" + Username + "' ") > 0 ? true : false;
        }

        public bool Insert(string Username, string Password, string Displayname, string Chucvu)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[Account]([Username],[Password],[DisplayName],[UserType]) VALUES ('" + Username + "','" + Password + "',N'" + Displayname + "','" + Chucvu + "')") > 0 ? true : false;
        }

        public bool CheckLogin(string UserName_Login, string PassWord_Login)
        {
            DataTable account_get = this.Select();
            for (int i = 0; i < account_get.Rows.Count; i++)
            {
                if (account_get.Rows[i]["Username"].ToString() == UserName_Login && account_get.Rows[i]["Password"].ToString() == PassWord_Login)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
