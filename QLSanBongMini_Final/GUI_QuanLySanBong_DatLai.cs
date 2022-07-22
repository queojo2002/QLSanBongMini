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
using DTO;

namespace QLSanBongMini_Final
{
    public partial class frmDatlai : DevExpress.XtraEditors.XtraForm
    {
        List<DTO_KhuVuc_SanBong> KVSB = new List<DTO_KhuVuc_SanBong>();
        List<DTO_KhachHang> KhachHang = new List<DTO_KhachHang>();
        private bool Check_ThemMoi_KhachHang = false;
        private int IDChiTietLDSB = -1;
        public frmDatlai()
        {
            InitializeComponent();
        }
        public frmDatlai(int ID)
        {
            InitializeComponent();
            IDChiTietLDSB = ID;
        }

        private void frmDatlai_Load(object sender, EventArgs e)
        {
            Add_KhachHang();
        }


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (Check_ThemMoi_KhachHang == false)
            {
                Check_ThemMoi_KhachHang = true;
                cbeTenKH.Properties.Items.Clear();
                cbeSDTKH.Properties.Items.Clear();
                KhachHang.Clear();
                cbeTenKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cbeSDTKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cbeTenKH.Text = "";
                cbeSDTKH.Text = "";
                btnDatLai.Enabled = false;
                btnThemKH.Text = "Xác nhận thêm mới";
            }
            else if (Check_ThemMoi_KhachHang == true)
            {
                if (cbeTenKH.Text != "" && cbeSDTKH.Text != "")
                {
                    if (BUS_KhachHang.Instance.Insert(cbeTenKH.Text, cbeSDTKH.Text) == true)
                    {
                        Check_ThemMoi_KhachHang = false;
                        cbeTenKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                        cbeSDTKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                        Add_KhachHang();
                        btnThemKH.Text = "Thêm mới khách hàng";
                        btnDatLai.Enabled = true;
                        XtraMessageBox.Show("Thêm mới khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm mới khách hàng Không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnDatLai.Enabled = true;
                        return;
                    }
                }
            }
        }
        public void Add_KhachHang()
        {
            DataTable Get_KH = BUS_KhachHang.Instance.Select();
            if (Get_KH != null)
            {
                KhachHang.Clear();
                cbeTenKH.Properties.Items.Clear();
                cbeSDTKH.Properties.Items.Clear();
                cbeTenKH.Text = "";
                cbeSDTKH.Text = "";
                foreach (DataRow row in Get_KH.Rows)
                {
                    KhachHang.Add(new DTO_KhachHang(row));
                }
                for (int i = 0; i < KhachHang.Count; i++)
                {
                    cbeTenKH.Properties.Items.Add(KhachHang.ElementAt(i).HoTen_GS);
                    cbeSDTKH.Properties.Items.Add(KhachHang.ElementAt(i).SDT_GS);
                }

            }
        }

        private void cbeTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbeSDTKH.SelectedIndex = cbeTenKH.SelectedIndex;
        }

        private void cbeSDTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbeTenKH.SelectedIndex = cbeSDTKH.SelectedIndex;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            int ID_KhachHang = int.Parse(KhachHang.ElementAt(cbeTenKH.SelectedIndex).ID_GS.ToString());
            DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn đặt lại sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (add_confirm == DialogResult.No)
            {
                return;
            }

            if (BUS_ChiTiet_LichDat_SanBong.Instance.Update(IDChiTietLDSB, ID_KhachHang, txtGhiChu.Text, 1) == true)
            {
                XtraMessageBox.Show("Đặt lại sân bóng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Đặt lại sân bóng không thành công ! \n\nLỗi: Không Xác Định !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}