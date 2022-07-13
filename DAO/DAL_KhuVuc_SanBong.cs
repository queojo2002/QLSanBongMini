using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuVuc_SanBong
    {
        private static DAL_KhuVuc_SanBong instance;

        public static DAL_KhuVuc_SanBong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_KhuVuc_SanBong();
                }
                return instance;
            }
            private set
            {
                DAL_KhuVuc_SanBong.instance = value;
            }
        }

        private DAL_KhuVuc_SanBong() { }


        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[KhuVuc_SanBong]");
        }
        public DataTable Select_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[KhuVuc_SanBong] Where ID = '"+ID+"'");
        }
        public bool Insert(string Ten, int GiaTien, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[KhuVuc_SanBong]([Ten],[GiaTien],[KhungGio_BatDau],[KhungGio_KetThuc]) VALUES " +
                "(" +
                "N'"+Ten+ "','" + 
                GiaTien + "','" + 
                KhungGio_BatDau + "','" + 
                KhungGio_KetThuc + 
                "')") > 0 ? true : false;
        }

        public bool Update_By_ID(int ID, string Ten, int GiaTien)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("UPDATE [dbo].[KhuVuc_SanBong] Set [Ten] = N'"+ Ten + "', [GiaTien] = '"+ GiaTien + "' Where ID = '"+ID+"'") > 0 ?true:false;
        }

        public bool Delete_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("DELETE FROM [dbo].[KhuVuc_SanBong] WHERE ID = '" + ID +"'") > 0 ? true : false;
        }


    }
}
