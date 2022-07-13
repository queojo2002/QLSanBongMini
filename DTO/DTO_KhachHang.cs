using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private int ID;
        private string HoTen;
        private string SDT;
        private string FB;
        private int SoLanDat;
        private string Loai_KH;

        public DTO_KhachHang(int iD, string hoTen, string sDT, string fB, int soLanDat, string loai_KH)
        {
            ID = iD;
            HoTen = hoTen;
            SDT = sDT;
            FB = fB;
            SoLanDat = soLanDat;
            Loai_KH = loai_KH;
        }
        public DTO_KhachHang(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            HoTen = row["HoTen"].ToString();
            SDT = row["SDT"].ToString();
            FB = row["FB"].ToString();
            SoLanDat = int.Parse(row["SoLanDat"].ToString());
            Loai_KH = row["Loai_KH"].ToString();
        }


        public int ID_GS { get => ID; set => ID = value; }
        public string HoTen_GS { get => HoTen; set => HoTen = value; }
        public string SDT_GS { get => SDT; set => SDT = value; }
        public string FB_GS { get => FB; set => FB = value; }
        public int SoLanDat_GS { get => SoLanDat; set => SoLanDat = value; }
        public string Loai_KH_GS { get => Loai_KH; set => Loai_KH = value; }
    }
}
