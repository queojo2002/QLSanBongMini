using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBongMini_Final
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public frmPrint(int IDBill, DateTime NgayXuatBill, string TenNguoiDat, string SDTNguoiDat, List<DTO_HoaDon> HoaDon)
        {
            InitializeComponent();
            ThanhToan_HoaDon a = new ThanhToan_HoaDon();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in a.Parameters)
            {
                p.Visible = false;
            }
            a.Set_Para(IDBill, NgayXuatBill, TenNguoiDat, SDTNguoiDat, HoaDon);

            documentViewer1.DocumentSource = a;
            a.CreateDocument();
        }
        public frmPrint(string Text_DoanhThu, List<DTO_DoanhThu> DoanhThu)
        {
            InitializeComponent();
            DoanhThu_Report a = new DoanhThu_Report();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in a.Parameters)
            {
                p.Visible = false;
            }
            a.Set_Para(Text_DoanhThu, DoanhThu);
            documentViewer1.DocumentSource = a;
            a.CreateDocument();
        }


    }
}