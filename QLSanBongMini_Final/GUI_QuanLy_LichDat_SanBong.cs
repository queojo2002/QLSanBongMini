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
    public partial class frmQuanLy_LichDat_SanBong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_LichDat_SanBong()
        {
            InitializeComponent();
        }
        public void Load_DataSource()
        {
            DataTable Get_CTLDSB = BUS_ChiTiet_LichDat_SanBong.Instance.Select();
            if (Get_CTLDSB != null)
            {
                gcViewLDSB.DataSource = Get_CTLDSB;
                gcViewLDSB.Update();
                gcViewLDSB.Refresh();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmQuanLy_LichDat_SanBong_Them them = new frmQuanLy_LichDat_SanBong_Them();
            them.ShowDialog();
            Load_DataSource();
            this.Show();
        }

        private void frmQuanLy_LichDat_SanBong_Load(object sender, EventArgs e)
        {
            Load_DataSource();
        }
    }
}