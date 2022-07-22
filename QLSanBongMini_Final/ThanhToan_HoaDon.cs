using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DTO;
using System.Globalization;
using System.Threading;

namespace QLSanBongMini_Final
{
    public partial class ThanhToan_HoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public ThanhToan_HoaDon()
        {
            InitializeComponent();
        }
        public void Set_Para(int IDBill, DateTime NgayXuatBill, string TenNguoiDat, string SDTNguoiDat, List<DTO_HoaDon> Data_HoaDon)
        {
            this.IDBill.Value = IDBill;
            this.NgayXuatHoaDon.Value = NgayXuatBill.ToString();
            this.TenNguoiDat.Value = TenNguoiDat;
            this.SDTNguoiDat.Value = SDTNguoiDat;
            CultureInfo cultureInfo = new CultureInfo("vi-Vn");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            objectDataSource1.DataSource = Data_HoaDon;
        }

    }
}
