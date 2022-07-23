using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QLSanBongMini_Final
{
    public partial class frmQuanLy_LichDat_SanBong_XemChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_LichDat_SanBong_XemChiTiet()
        {
            InitializeComponent();
        }

        public frmQuanLy_LichDat_SanBong_XemChiTiet(int ID_LDSB)
        {
            InitializeComponent();
            if (ID_LDSB.ToString() != string.Empty)
            {
                DataTable Get_CTLDSB = BUS_ChiTiet_LichDat_SanBong.Instance.Select_By_IDLDSB(ID_LDSB);
                grid_view_chitietlichdat.DataSource = Get_CTLDSB;
            }
        }
        private void frmQuanLy_LichDat_SanBong_XemChiTiet_Load(object sender, EventArgs e)
        {

        }
    }
}