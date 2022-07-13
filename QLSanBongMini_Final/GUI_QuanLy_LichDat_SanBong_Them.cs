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
    public partial class frmQuanLy_LichDat_SanBong_Them : DevExpress.XtraEditors.XtraForm
    {
        List<DTO_KhuVuc_SanBong> KVSB = new List<DTO_KhuVuc_SanBong>();
        List<DTO_KhachHang> KhachHang = new List<DTO_KhachHang>();
        private bool Check_ThemMoi_KhachHang = false;
        public frmQuanLy_LichDat_SanBong_Them()
        {
            InitializeComponent();
        }

        private void frmQuanLy_LichDat_SanBong_Them_Load(object sender, EventArgs e)
        {
            Add_TenKVSB();
            Add_KhachHang();
        }

        public void Add_TenKVSB()
        {
            DataTable Get_KVSB = BUS_KhuVuc_SanBong.Instance.Select();
            if (Get_KVSB == null)
            {
                XtraMessageBox.Show("Vui Lòng Thêm Khu Vực Sân Bóng Để Tiếp Tục", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KVSB.Clear();
            cbeTenKVSB.Properties.Items.Clear();
            foreach (DataRow row in Get_KVSB.Rows)
            {
                KVSB.Add(new DTO_KhuVuc_SanBong(row));
            }
            for (int i = 0; i < KVSB.Count; i++)
            {
                cbeTenKVSB.Properties.Items.Add(KVSB.ElementAt(i).Ten_GS);
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

        private void cbeTenKVSB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tseKhungGioBatDau.EditValue = KVSB.ElementAt(cbeTenKVSB.SelectedIndex).KhungGio_BatDau_GS;
            tseKhungGioKetThuc.EditValue = KVSB.ElementAt(cbeTenKVSB.SelectedIndex).KhungGio_KetThuc_GS;
        }

        private void cbeTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbeSDTKH.SelectedIndex = cbeTenKH.SelectedIndex;
        }

        private void cbeSDTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbeTenKH.SelectedIndex = cbeSDTKH.SelectedIndex;
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
                btnThemKH.Text = "Xác nhận thêm mới";
            }else if (Check_ThemMoi_KhachHang == true)
            {
                if (cbeTenKH.Text != "" && cbeSDTKH.Text != "")
                {
                    if (BUS_KhachHang.Instance.Insert(cbeTenKH.Text,cbeSDTKH.Text) == true)
                    {
                        Check_ThemMoi_KhachHang = false;
                        cbeTenKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                        cbeSDTKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                        Add_KhachHang();
                        btnThemKH.Text = "Thêm mới khách hàng";
                        XtraMessageBox.Show("Thêm mới khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm mới khách hàng Không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbeTenKH.SelectedIndex == -1 || cbeSDTKH.SelectedIndex == -1 || cbeTenKVSB.SelectedIndex == -1) return;
            int ID_KhachHang = int.Parse(KhachHang.ElementAt(cbeTenKH.SelectedIndex).ID_GS.ToString());
            int ID_KVSB = int.Parse(KVSB.ElementAt(cbeTenKVSB.SelectedIndex).ID_GS.ToString());
            string GhiChu = txtGhiChu.Text;
            DateTime NgayDat_BatDau = deTuNgay.DateTime;
            DateTime NgayDat_KetThuc = deDenNgay.DateTime;
            TimeSpan KhungGio_Tu = tseTu.TimeSpan;
            TimeSpan KhungGio_Den = tseDen.TimeSpan;
            DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm lịch đặt sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (add_confirm == DialogResult.No)
            {
                return;
            }
            if (check_thu_2.Checked == false && check_thu_3.Checked == false && check_thu_4.Checked == false && check_thu_5.Checked == false && check_thu_6.Checked == false && check_thu_7.Checked == false && check_chu_nhat.Checked == false)
            {
                string Add_TheoNgay = BUS_LichDat_SanBong.Instance.Insert_TheoNgay(ID_KVSB, ID_KhachHang, NgayDat_BatDau, NgayDat_KetThuc, KhungGio_Tu, KhungGio_Den, GhiChu);
                if (Add_TheoNgay == "Thêm Lịch Đặt Sân Bóng Thành Công")
                {
                    XtraMessageBox.Show("Thêm lịch đặt sân bóng thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }else
                {
                    XtraMessageBox.Show(Add_TheoNgay, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  
                }
            }
            else
            {
                string Add_CoDinh = BUS_LichDat_SanBong.Instance.Insert_CoDinh(ID_KVSB, ID_KhachHang, NgayDat_BatDau, NgayDat_KetThuc, KhungGio_Tu, KhungGio_Den, check_thu_2.Checked, check_thu_3.Checked, check_thu_4.Checked, check_thu_5.Checked, check_thu_6.Checked, check_thu_7.Checked, check_chu_nhat.Checked, GhiChu);
                if (Add_CoDinh == "Thêm Lịch Đặt Sân Bóng Thành Công")
                {
                    XtraMessageBox.Show("Thêm lịch đặt sân bóng thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    XtraMessageBox.Show(Add_CoDinh, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult add_confirm = XtraMessageBox.Show("Bạn có chắc chắn muốn Hủy thêm lịch đặt sân bóng này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (add_confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}