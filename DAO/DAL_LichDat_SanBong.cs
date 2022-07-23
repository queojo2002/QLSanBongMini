using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class DAL_LichDat_SanBong
    {
        private static DAL_LichDat_SanBong instance;

        public static DAL_LichDat_SanBong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_LichDat_SanBong();
                }
                return instance;
            }
            private set
            {
                DAL_LichDat_SanBong.instance = value;
            }
        }

        private DAL_LichDat_SanBong() { }


        public DataTable Select()
        {
            return DAL_DB.Instance.ThuThi_Query("Select * From [dbo].[LichDat_SanBong]");
        }


        public DataTable Select_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_Query("SELECT LichDat_SanBong.ID, KhuVuc_SanBong.Ten, KhachHang.HoTen, KhachHang.SDT, LichDat_SanBong.NgayDat_BatDau, LichDat_SanBong.NgayDat_KetThuc, LichDat_SanBong.KhungGioDat_BatDau, LichDat_SanBong.KhungGioDat_KetThuc FROM LichDat_SanBong INNER JOIN KhuVuc_SanBong ON LichDat_SanBong.ID_KVSB = KhuVuc_SanBong.ID INNER JOIN KhachHang ON LichDat_SanBong.ID_KH = KhachHang.ID WHERE(LichDat_SanBong.ID = '"+ID+"')");
        }


        public bool Delete_By_ID(int ID)
        {
            return DAL_DB.Instance.ThuThi_NonQuery("DELETE FROM [dbo].[LichDat_SanBong] WHERE ID = '" + ID + "'") > 0 ? true : false;

        }

















        #region


        public string Insert_CoDinh(int ID_KVSB, int ID_KH, DateTime NgayDat_BatDau, DateTime NgayDat_KetThuc, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc, bool Thu_2, bool Thu_3, bool Thu_4, bool Thu_5, bool Thu_6, bool Thu_7, bool CN, string GhiChu)
        {
            DataTable Get_KVSB = DAL_KhuVuc_SanBong.Instance.Select_By_ID(ID_KVSB);
            if (Get_KVSB == null) return "Lấy khu vực sân bóng không thành công";
            if (Check_KhungGio_KVSB_NguoiDung(KhungGio_BatDau, KhungGio_KetThuc, TimeSpan.Parse(Get_KVSB.Rows[0]["KhungGio_BatDau"].ToString()), TimeSpan.Parse(Get_KVSB.Rows[0]["KhungGio_KetThuc"].ToString())) == false)
            {
                return "Khung Giờ Bạn Nhập Vào Phải Trùng Với Khùng Giờ Của Khu Vực Sân Bóng";
            }
            else if (NgayDat_BatDau.Date > NgayDat_KetThuc)
            {
                return "Ngày Đặt Bắt Đầu phải bé hơn hoặc bằng Ngày Đặt Kết Thúc";
            }
            else if (KhungGio_BatDau > KhungGio_KetThuc)
            {
                return "Khung Giờ Bắt Đầu phải bé hơn hoặc bằng Khung Giờ Kết Thúc";
            }else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Monday" && Thu_2 == false))
            {
                return "Vui Lòng Tích Vào Thứ 2 !";
            }
            else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Tuesday" && Thu_3 == false))
            {
                return "Vui Lòng Tích Vào Thứ 3 !";
            }
            else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Wednesday" && Thu_4 == false))
            {
                return "Vui Lòng Tích Vào Thứ 4 !";
            }
            else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Thursday" && Thu_5 == false))
            {
                return "Vui Lòng Tích Vào Thứ 5 !";
            }
            else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Friday" && Thu_6 == false))
            {
                return "Vui Lòng Tích Vào Thứ 6 !";
            }
            else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Saturday" && Thu_7 == false))
            {
                return "Vui Lòng Tích Vào Thứ 7 !";
            }
            else if ((NgayDat_BatDau.DayOfWeek.ToString() == "Sunday" && CN == false))
            {
                return "Vui Lòng Tích Vào Chủ Nhật !";
            }
            else if ((NgayDat_KetThuc - NgayDat_BatDau).TotalDays <= 6)
            {
                return "Ngày Đặt Phải Cách Nhau Ít Nhất 1 Tuần !";
            }
            else
            {
                DataTable Get_CT_LD_SB = DAL_ChiTiet_LichDat_SanBong.Instance.Select();
                if (Get_CT_LD_SB != null)
                {

                    for (int i = 0; i < Get_CT_LD_SB.Rows.Count; i++)
                    {
                        int ID_KVSB_SQL = int.Parse(Get_CT_LD_SB.Rows[i]["ID_KVSB"].ToString());
                        DateTime NgayDat = DateTime.Parse(Get_CT_LD_SB.Rows[i]["NgayDat"].ToString());
                        TimeSpan KhungGio_BatDau_CTLDSB = TimeSpan.Parse(Get_CT_LD_SB.Rows[i]["KhungGio_BatDat"].ToString());
                        TimeSpan KhungGio_KetThuc_CTLDSB = TimeSpan.Parse(Get_CT_LD_SB.Rows[i]["KhungGio_KetThuc"].ToString());

                        if (ID_KVSB_SQL == ID_KVSB)
                        {
                            for (DateTime start_days = NgayDat_BatDau; start_days <= NgayDat_KetThuc; start_days = start_days.AddDays(1))
                            {
                                if (
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (Thu_2 == true)) ||
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (Thu_3 == true)) ||
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (Thu_4 == true)) ||
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (Thu_5 == true)) ||
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (Thu_6 == true)) ||
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (Thu_7 == true)) ||
                                    (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy") && (start_days.DayOfWeek == NgayDat.DayOfWeek) && (CN == true))
                                    )
                                {
                                    if (Check_KhungGio_DatSan(KhungGio_BatDau_CTLDSB, KhungGio_KetThuc_CTLDSB, KhungGio_BatDau, KhungGio_KetThuc) != "OK")
                                    {
                                        return NgayDat.Date.ToString("dd-MM-yyyy") + ": trùng lịch";
                                    }
                                }
                            }
                        }
                    }
                }
            }


            

            if (DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[LichDat_SanBong] " + "([ID_KVSB],[ID_KH],[NgayDat_BatDau],[NgayDat_KetThuc],[KhungGioDat_BatDau],[KhungGioDat_KetThuc]) " + "VALUES " + "('" + ID_KVSB + "','" + ID_KH + "','" + NgayDat_BatDau.ToString("yyyy-MM-dd") + "','" + NgayDat_KetThuc.ToString("yyyy-MM-dd") + "','" + KhungGio_BatDau + "','" + KhungGio_KetThuc + "')") > 0)
            {
                DataTable Get_ID_MAX = DAL_DB.Instance.ThuThi_Query("SELECT max(ID) FROM dbo.LichDat_SanBong");
                if (Get_ID_MAX == null) return "Error: Có lỗi khi thêm sân bóng !!!";
                int ID_LDSB = int.Parse(Get_ID_MAX.Rows[0].ItemArray[0].ToString());

                for (DateTime start_days = NgayDat_BatDau; start_days <= NgayDat_KetThuc; start_days = start_days.AddDays(1))
                {
                    if (((start_days.DayOfWeek.ToString() == "Monday") && (Thu_2 == true)) ||
                        ((start_days.DayOfWeek.ToString() == "Tuesday") && (Thu_3 == true)) ||
                        ((start_days.DayOfWeek.ToString() == "Wednesday") && (Thu_4 == true)) ||
                        ((start_days.DayOfWeek.ToString() == "Thursday") && (Thu_5 == true)) ||
                        ((start_days.DayOfWeek.ToString() == "Friday") && (Thu_6 == true)) ||
                        ((start_days.DayOfWeek.ToString() == "Saturday") && (Thu_7 == true)) ||
                        ((start_days.DayOfWeek.ToString() == "Sunday") && (CN == true)))
                    {
                        if (DAL_ChiTiet_LichDat_SanBong.Instance.Insert(ID_LDSB, ID_KVSB, ID_KH, start_days.Date, KhungGio_BatDau, KhungGio_KetThuc, GhiChu) == false)
                        {
                            return "Error: Có lỗi khi thêm sân bóng !!!";
                        }

                    }
                }
                return "Thêm Lịch Đặt Sân Bóng Thành Công";
            }
            else
            {
                return "Không thể thêm";
            }



        }


        public string Insert_TheoNgay(int ID_KVSB, int ID_KH, DateTime NgayDat_BatDau, DateTime NgayDat_KetThuc, TimeSpan KhungGio_BatDau, TimeSpan KhungGio_KetThuc, string GhiChu)
        {
            DataTable Get_KVSB = DAL_KhuVuc_SanBong.Instance.Select_By_ID(ID_KVSB);
            if (Get_KVSB == null) return "Lấy khu vực sân bóng không thành công";
            if (Check_KhungGio_KVSB_NguoiDung(KhungGio_BatDau, KhungGio_KetThuc, TimeSpan.Parse(Get_KVSB.Rows[0]["KhungGio_BatDau"].ToString()), TimeSpan.Parse(Get_KVSB.Rows[0]["KhungGio_KetThuc"].ToString())) == false)
            {
                return "Khung Giờ Bạn Nhập Vào Phải Trùng Với Khùng Giờ Của Khu Vực Sân Bóng";
            }else if (NgayDat_BatDau.Date > NgayDat_KetThuc)
            {
                return "Ngày Đặt Bắt Đầu phải bé hơn hoặc bằng Ngày Đặt Kết Thúc";
            }else if (KhungGio_BatDau > KhungGio_KetThuc)
            {
                return "Khung Giờ Bắt Đầu phải bé hơn hoặc bằng Khung Giờ Kết Thúc";
            }else {
                DataTable Get_CT_LD_SB = DAL_ChiTiet_LichDat_SanBong.Instance.Select();
                if (Get_CT_LD_SB != null)
                {
                    for (int i = 0; i < Get_CT_LD_SB.Rows.Count; i++)
                    {
                        int ID_KVSB_SQL = int.Parse(Get_CT_LD_SB.Rows[i]["ID_KVSB"].ToString());
                        DateTime NgayDat = DateTime.Parse(Get_CT_LD_SB.Rows[i]["NgayDat"].ToString());
                        TimeSpan KhungGio_BatDau_CTLDSB = TimeSpan.Parse(Get_CT_LD_SB.Rows[i]["KhungGio_BatDat"].ToString());
                        TimeSpan KhungGio_KetThuc_CTLDSB = TimeSpan.Parse(Get_CT_LD_SB.Rows[i]["KhungGio_KetThuc"].ToString());

                        if (ID_KVSB_SQL == ID_KVSB)
                        {
                            for (DateTime start_days = NgayDat_BatDau; start_days <= NgayDat_KetThuc; start_days = start_days.AddDays(1))
                            {
                                if (start_days.Date.ToString("dd-MM-yyyy") == NgayDat.Date.ToString("dd-MM-yyyy"))
                                {
                                    if (Check_KhungGio_DatSan(KhungGio_BatDau_CTLDSB, KhungGio_KetThuc_CTLDSB, KhungGio_BatDau, KhungGio_KetThuc) != "OK")
                                    {
                                        return NgayDat.Date.ToString("dd-MM-yyyy") + ": trùng lịch";
                                    }
                                }
                            }
                        }
                    }



                }


            }


            if (DAL_DB.Instance.ThuThi_NonQuery("INSERT INTO [dbo].[LichDat_SanBong] " +"([ID_KVSB],[ID_KH],[NgayDat_BatDau],[NgayDat_KetThuc],[KhungGioDat_BatDau],[KhungGioDat_KetThuc]) " +"VALUES " +"('" +ID_KVSB + "','" +ID_KH + "','" +NgayDat_BatDau.ToString("yyyy-MM-dd") + "','" +NgayDat_KetThuc.ToString("yyyy-MM-dd") + "','" +KhungGio_BatDau + "','" +KhungGio_KetThuc + "')") > 0)
            {
                DataTable Get_ID_MAX = DAL_DB.Instance.ThuThi_Query("SELECT max(ID) FROM dbo.LichDat_SanBong");
                if (Get_ID_MAX == null) return "Error: Có lỗi khi thêm sân bóng !!!";
                int ID_LDSB = int.Parse(Get_ID_MAX.Rows[0].ItemArray[0].ToString());

                for (DateTime start_days = NgayDat_BatDau; start_days <= NgayDat_KetThuc; start_days = start_days.AddDays(1))
                {
                    if (DAL_ChiTiet_LichDat_SanBong.Instance.Insert(ID_LDSB, ID_KVSB, ID_KH, start_days.Date, KhungGio_BatDau, KhungGio_KetThuc, GhiChu) == false)
                    {
                        return "Error: Có lỗi khi thêm sân bóng !!!";
                    }
                }
                return "Thêm Lịch Đặt Sân Bóng Thành Công";
            }
            else
            {
                return "Không thể thêm";
            }
        }


        public bool Check_KhungGio_KVSB_NguoiDung(TimeSpan KhungGio_BatDau_NguoiDung, TimeSpan KhungGio_KetThuc_NguoiDung, TimeSpan KhungGio_BatDau_SQL, TimeSpan KhungGio_KetThuc_SQL)
        {
            if ((KhungGio_BatDau_NguoiDung >= KhungGio_BatDau_SQL && KhungGio_BatDau_NguoiDung <= KhungGio_KetThuc_SQL) && (KhungGio_KetThuc_NguoiDung >= KhungGio_BatDau_SQL && KhungGio_KetThuc_NguoiDung <= KhungGio_KetThuc_SQL))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Check_KhungGio_DatSan(TimeSpan Time_Dat_BatDau, TimeSpan Time_Dat_KetThuc, TimeSpan Time_Dat_BatDau_1, TimeSpan Time_Dat_KetThuc_1)
        {

            TimeSpan Time_Add_Minu = TimeSpan.FromMinutes(1);
            if (Time_Dat_BatDau_1 < Time_Dat_KetThuc_1 && Time_Dat_BatDau < Time_Dat_KetThuc)
            {
                if (Time_Dat_KetThuc == Time_Dat_BatDau_1)
                {
                    return "OK";
                }
                else if (Time_Dat_BatDau == Time_Dat_KetThuc_1)
                {
                    return "OK";
                }
                else
                {
                    short Check_Trung = 0;
                    for (TimeSpan i = Time_Dat_BatDau; i <= Time_Dat_KetThuc; i = i.Add(Time_Add_Minu))
                    {
                        short flag = 0;
                        for (TimeSpan j = Time_Dat_BatDau_1; j <= Time_Dat_KetThuc_1; j = j.Add(Time_Add_Minu))
                        {
                            if ((i.Hours == j.Hours) && (i.Minutes == j.Minutes))
                            {
                                flag = 1;
                                break;
                            }

                        }
                        if (flag == 1)
                        {
                            Check_Trung = 1;
                            break;
                        }
                    }
                    if (Check_Trung == 0)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Trùng";
                    }
                }
            }
            else if (Time_Dat_BatDau_1 > Time_Dat_KetThuc_1)
            {
                return "Giờ Bắt Đầu Phải Bé Hơn Giờ Kết Thúc !";
            }
            else
            {
                return "Error";
            }
        }


        #endregion // xử lý lịch đặt

    }
}
