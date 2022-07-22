using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Bill
    {
        private static DAL_Bill instance;

        public static DAL_Bill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Bill();
                }
                return instance;
            }
            private set
            {
                DAL_Bill.instance = value;
            }
        }

        private DAL_Bill() { }

        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[HoaDon]");
        }

        public DataTable Select_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[HoaDon] Where ID = '"+ID+"'");
        }

        public DataTable Select_By_ID_CTLDSB(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[HoaDon] Where IDCTLDSB = '" + ID + "'");
        }

        public DataTable Select_Xem_DoanhThu(DateTime TuNgay, DateTime DenNgay)
        {
            return DAL_DB.Instance.ThuThi_Query("SELECT HoaDon.* FROM HoaDon WHERE (TrangThai = 1) AND (CONVERT(date, NgayXuatBill) >= '" + TuNgay.ToString("yyyy-MM-dd") + "') AND (CONVERT(date, NgayXuatBill) <= '" + DenNgay.ToString("yyyy-MM-dd") + "')");
        }
        public bool Insert(int IDCTLDSB, int IDKhachHang, DateTime NgayLap_Bill, int ThanhTien, int TrangThai)
        {
            int insert_bill = DAL_DB.Instance.ThuThi_NonQuery(
                "INSERT INTO [dbo].[HoaDon] ([IDCTLDSB],[IDKhachHang],[NgayLapBill],[ThanhTien],[GiamGia],[TrangThai]) " +
                "VALUES " +
                                        "('" + IDCTLDSB + "', '" + IDKhachHang + "', '" + NgayLap_Bill.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + ThanhTien + "', '0', '" + TrangThai + "')");
            if (insert_bill > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update_Status_Bill(int IDBill, DateTime NgayXuatBill, int GiamGia, int ThanhTien, int TrangThai)
        {
            int update_stt_bill = DAL_DB.Instance.ThuThi_NonQuery("Update dbo.HoaDon Set GiamGia = " + GiamGia + ", NgayXuatBill = N'" + NgayXuatBill.ToString("yyyy-MM-dd hh:mm:ss") + "', ThanhTien = '" + ThanhTien + "', TrangThai = '" + TrangThai + "' Where ID = '" + IDBill + "'");
            if (update_stt_bill > 0)
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
