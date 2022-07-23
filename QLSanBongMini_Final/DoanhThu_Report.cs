using DevExpress.XtraReports.UI;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;

namespace QLSanBongMini_Final
{
    public partial class DoanhThu_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public DoanhThu_Report()
        {
            InitializeComponent();
        }

        public void Set_Para(string Text_DoanhThu, List<DTO_DoanhThu> Data_DoanhThu)
        {
            this.DoanhThu_Text.Value = Text_DoanhThu;
            CultureInfo cultureInfo = new CultureInfo("vi-Vn");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            objectDataSource1.DataSource = Data_DoanhThu;
        }

    }
}
