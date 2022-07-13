using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhuVuc_SanBong
    {
        private int ID;
        private string Ten;
        private int GiaTien;
        private TimeSpan KhungGio_BatDau;
        private TimeSpan KhungGio_KetThuc;

        public DTO_KhuVuc_SanBong(int iD, string ten, int giaTien, TimeSpan khungGio_BatDau, TimeSpan khungGio_KetThuc)
        {
            ID = iD;
            Ten = ten;
            GiaTien = giaTien;
            KhungGio_BatDau = khungGio_BatDau;
            KhungGio_KetThuc = khungGio_KetThuc;
        }

        public DTO_KhuVuc_SanBong(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            Ten = row["Ten"].ToString();
            GiaTien = int.Parse(row["GiaTien"].ToString());
            KhungGio_BatDau = TimeSpan.Parse(row["KhungGio_BatDau"].ToString());
            KhungGio_KetThuc = TimeSpan.Parse(row["KhungGio_KetThuc"].ToString());
        }

        public int ID_GS { get => ID; set => ID = value; }
        public string Ten_GS { get => Ten; set => Ten = value; }
        public int GiaTien_GS { get => GiaTien; set => GiaTien = value; }
        public TimeSpan KhungGio_BatDau_GS { get => KhungGio_BatDau; set => KhungGio_BatDau = value; }
        public TimeSpan KhungGio_KetThuc_GS { get => KhungGio_KetThuc; set => KhungGio_KetThuc = value; }
    }
}
