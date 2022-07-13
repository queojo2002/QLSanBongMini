using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LichDat_SanBong
    {
        private int IdKvsb;
        private int IdKhachHang;
        DateTime NgayDatBatDau;
        DateTime NgayDatKetThuc;
        TimeSpan KhungGio_BatDau;
        TimeSpan KhungGio_KetThuc;

        public DTO_LichDat_SanBong(int idKvsb, int idKhachHang, DateTime ngayDatBatDau, DateTime ngayDatKetThuc, TimeSpan khungGio_BatDau, TimeSpan khungGio_KetThuc)
        {
            IdKvsb = idKvsb;
            IdKhachHang = idKhachHang;
            NgayDatBatDau = ngayDatBatDau;
            NgayDatKetThuc = ngayDatKetThuc;
            KhungGio_BatDau = khungGio_BatDau;
            KhungGio_KetThuc = khungGio_KetThuc;
        }

        public bool Check_KhungGio_KVSB(TimeSpan KhungGio_BatDau_2, TimeSpan KhungGio_KetThuc_2)
        {
            if ((this.KhungGio_BatDau >= KhungGio_BatDau_2 && this.KhungGio_BatDau <= KhungGio_KetThuc_2) && (this.KhungGio_KetThuc >= KhungGio_BatDau_2 && this.KhungGio_KetThuc <= KhungGio_KetThuc_2))
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool Check_LichDat_SanBong(DateTime NgayDat_CT_LDSB, TimeSpan KhungGio_BatDau_CT_LDSB, TimeSpan KhungGio_KetThuc_CT_LDSB)
        {
            for (DateTime start_days = this.NgayDatBatDau; start_days <= this.NgayDatKetThuc; start_days = start_days.AddDays(1))
            {
                if (start_days.Date.ToString("dd-MM-yyyy") == NgayDat_CT_LDSB.Date.ToString("dd-MM-yyyy"))
                {
                    if (Check_KhungGio_KVSB(KhungGio_BatDau_CT_LDSB, KhungGio_KetThuc_CT_LDSB) == true) 
                    {
                        // nếu như Khung Giờ  trong Database ChiTiet_LichDat_SanBong mà trùng với Khung giờ Mà người dùng nhập vào thì sẽ bị trùng lịch
                        return false;
                    }
                }
            }
            return true;
        }



        public int ID_Kvsb_GS { get => IdKvsb; set => IdKvsb = value; }
        public int ID_KhachHang_GS { get => IdKhachHang; set => IdKhachHang = value; }
        public DateTime NgayDat_BatDau_GS { get => NgayDatBatDau; set => NgayDatBatDau = value; }
        public DateTime NgayDat_KetThuc_GS { get => NgayDatKetThuc; set => NgayDatKetThuc = value; }
        public TimeSpan KhungGio_BatDau_GS { get => KhungGio_BatDau; set => KhungGio_BatDau = value; }
        public TimeSpan KhungGio_KetThuc_GS { get => KhungGio_KetThuc; set => KhungGio_KetThuc = value; }
    }
}
