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
    public partial class frmQuanLy_KV_SanBong_ChinhSua : DevExpress.XtraEditors.XtraForm
    {
        private int ID = -1;
        public frmQuanLy_KV_SanBong_ChinhSua(int ID_KVSB)
        {
            InitializeComponent();
            ID = ID_KVSB;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            string Ten = txtTen_KVSB.Text;
            int GiaTien = (int)nudGiaTien_KVSB.Value;
            DialogResult edit_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa khu vực sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (edit_confirm == DialogResult.Yes)
            {
                if (BUS_KhuVuc_SanBong.Instance.Update_By_ID(ID, Ten, GiaTien) == true)
                {
                    XtraMessageBox.Show("Sửa khu vực sân bóng thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }else
                {
                    XtraMessageBox.Show("Có lỗi khi sửa !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void frmQuanLy_SanBong_ChinhSua_Load(object sender, EventArgs e)
        {
            
            if (ID < 0)
            {
                XtraMessageBox.Show("ID Khu vực sân bóng không chính xác !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                
                DataTable Select_By_ID = BUS_KhuVuc_SanBong.Instance.Select_By_ID(ID);
                if (Select_By_ID == null)
                {
                    XtraMessageBox.Show("Không có khu vực sân bóng này !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else
                {
                    txtIDKVSB.Text = Select_By_ID.Rows[0]["ID"].ToString();
                    txtTen_KVSB.Text = Select_By_ID.Rows[0]["Ten"].ToString();
                    nudGiaTien_KVSB.Value = decimal.Parse(Select_By_ID.Rows[0]["GiaTien"].ToString());
                    
                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult canel_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn Hủy Sửa khu vực sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (canel_confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}