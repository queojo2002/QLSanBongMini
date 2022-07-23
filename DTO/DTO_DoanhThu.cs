using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoanhThu
    {
        private string Ten_KVSB;
        private string HoTen;
        private string SDT;
        private DateTime NgayXuatBill;
        private DateTime NgayLapBill;
        private int ThanhTien;
        private int GiamGia;

        public DTO_DoanhThu(string ten_KVSB, string hoTen, string sDT, DateTime ngayXuatBill, DateTime ngayLapBill, int thanhTien, int giamGia)
        {
            Ten_KVSB = ten_KVSB;
            HoTen = hoTen;
            SDT = sDT;
            NgayXuatBill = ngayXuatBill;
            NgayLapBill = ngayLapBill;
            ThanhTien = thanhTien;
            GiamGia = giamGia;
        }

        public string Ten_KVSB_GS { get => Ten_KVSB; set => Ten_KVSB = value; }
        public string HoTen_GS { get => HoTen; set => HoTen = value; }
        public string SDT_GS { get => SDT; set => SDT = value; }
        public DateTime NgayXuatBill_GS { get => NgayXuatBill; set => NgayXuatBill = value; }
        public DateTime NgayLapBill_GS { get => NgayLapBill; set => NgayLapBill = value; }
        public int ThanhTien_GS { get => ThanhTien; set => ThanhTien = value; }
        public int GiamGia_GS { get => GiamGia; set => GiamGia = value; }


        public int TongTien_HD
        {
            get
            {
                if (GiamGia > 0)
                {
                    return (int)(ThanhTien - (ThanhTien * (((double)GiamGia) / 100)));
                }
                else
                {
                    return (int)ThanhTien;
                }
            }
        }

        public int TongTien_TruocKhiGiamGia
        {
            get
            {
                return (int)(ThanhTien);
            }
        }

    }
}
