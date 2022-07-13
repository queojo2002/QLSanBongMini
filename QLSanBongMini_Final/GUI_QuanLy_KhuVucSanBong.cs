using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmQuanLy_KV_SanBong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLy_KV_SanBong()
        {
            InitializeComponent();
        }

        public void Load_DataSource()
        {
            DataTable Get_KVSB = BUS_KhuVuc_SanBong.Instance.Select();
            if (Get_KVSB != null)
            {
                gcViewKVSB.DataSource = Get_KVSB;
                gcViewKVSB.Update();
                gcViewKVSB.Refresh();
            }         
        }
        private void frmQuanLy_SanBong_Load(object sender, EventArgs e)
        {
            Load_DataSource();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmQuanLy_KV_SanBong_Them them_kvsb = new frmQuanLy_KV_SanBong_Them();
            them_kvsb.ShowDialog();
            Load_DataSource();
            this.Show();
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            int[] selRows = ((GridView)gcViewKVSB.MainView).GetSelectedRows();
            if (selRows.Length > 0)
            {
                DataRowView selRow = (DataRowView)(((GridView)gcViewKVSB.MainView).GetRow(selRows[0]));
                frmQuanLy_KV_SanBong_ChinhSua sua_kvsb = new frmQuanLy_KV_SanBong_ChinhSua(int.Parse(selRow["ID"].ToString()));
                sua_kvsb.ShowDialog();
                Load_DataSource();
                this.Show();
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gcViewKVSB.MainView).GetSelectedRows();
            if (selRows.Length > 0)
            {
                DialogResult delete_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa khu vực sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete_confirm == DialogResult.Yes)
                {
                    DataRowView selRow = (DataRowView)(((GridView)gcViewKVSB.MainView).GetRow(selRows[0]));
                    if (BUS_KhuVuc_SanBong.Instance.Delete_By_ID(int.Parse(selRow["ID"].ToString())) == true)
                    {
                        XtraMessageBox.Show("Xóa khu vực sân bóng thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataSource();
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi Xóa !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Load_DataSource();
                    }
                }
            }
        }
    }
}