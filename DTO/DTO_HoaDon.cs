using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string Ten_FWA;
        private int SoLuong;
        private int GiamGia;
        private int GiaTien;

        public DTO_HoaDon(string ten_FWA, int soLuong, int giamGia, int giaTien)
        {
            Ten_FWA = ten_FWA;
            SoLuong = soLuong;
            GiamGia = giamGia;
            GiaTien = giaTien;
        }

        public string Ten_FWA_GS { get => Ten_FWA; set => Ten_FWA = value; }
        public int SoLuong_GS { get => SoLuong; set => SoLuong = value; }
        public int GiamGia_GS { get => GiamGia; set => GiamGia = value; }
        public int GiaTien_GS { get => GiaTien; set => GiaTien = value; }


        public int TongTien_HD
        {
            get
            {
                if (GiamGia > 0)
                {
                    return (int)((SoLuong * GiaTien) - ((SoLuong * GiaTien) * (((double)GiamGia) / 100)));
                }
                else
                {
                    return (int)(SoLuong * GiaTien);
                }
            }
        }

        public int TongTien_TruocKhiGiamGia
        {
            get
            {
                return (int)(SoLuong * GiaTien);
            }
        }
    }
}
