using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        private static BUS_TaiKhoan instance;

        public static BUS_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_TaiKhoan();
                }
                return instance;
            }
            private set
            {
                BUS_TaiKhoan.instance = value;
            }
        }

        private BUS_TaiKhoan() { }

        public DataTable Select()
        {
            return DAL_TaiKhoan.Instance.Select();

        }
        public DataTable Select_By_Username(string UserName)
        {
            return DAL_TaiKhoan.Instance.Select_By_Username(UserName);
        }
        public bool Update_By_UserName(string Username, string Password, string Displayname, string Chucvu)
        {
            return DAL_TaiKhoan.Instance.Update_By_UserName(Username, Password, Displayname, Chucvu);
        }

        public bool Insert(string Username, string Password, string Displayname, string Chucvu)
        {
            return DAL_TaiKhoan.Instance.Insert(Username, Password, Displayname, Chucvu);
        }
        public bool CheckLogin(string UserName_Login, string PassWord_Login)
        {
            return DAL_TaiKhoan.Instance.CheckLogin(UserName_Login, PassWord_Login);
        }
    }
}
