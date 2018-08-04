using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace BTL
{
    public partial class frmSuaHocSinh : Form
    {
        LopBUL bulLop = new LopBUL();
        HoSoHocSinhBUL bulHS = new HoSoHocSinhBUL();
        public frmSuaHocSinh()
        {
            InitializeComponent();
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            try
            {

                HoSoHocSinh hs = new HoSoHocSinh();
                hs.MaHocSinh = txtMaHocSinh.Text;
                hs.HoTen = txtHoTen.Text;
                hs.NgaySinh = dtNgaySinh.Value.ToString("MM/dd/yyyy");
                hs.GioiTinh = cbGioiTinh.SelectedValue + "";
                hs.DiaChi = txtDiaChi.Text;
                hs.DiemVaoTruong = float.Parse(txtDiemVaoTruong.Text);
                hs.HoTenBoMe = txtHoTenBoMe.Text;
                hs.SoDienThoai = txtSoDienThoai.Text;
                hs.MaLop = cbLop.SelectedValue + "";
                // MessageBox.Show(hs.MaHocSinh + "   " + hs.HoTen + "   " + hs.NgaySinh + "   " + hs.GioiTinh + "   " + hs.DiaChi + hs.DiemVaoTruong + "   " + hs.HoTenBoMe + "   " + hs.MaLop);
                bulHS.suaHoSoHocSinh(hs);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmSuaHocSinh_Load(object sender, EventArgs e)
        {
            loadCBGioiTinh();
            loadCBLop();
        }
        void loadCBGioiTinh()
        {
            string[] arr = new string[2];
            arr[0] = "Nam";
            arr[1] = "Nữ";
            cbGioiTinh.DataSource = arr;
        }
        void loadCBLop()
        {
            cbLop.DataSource = bulLop.layTatLop();
            cbLop.DisplayMember = "tenLop";
            cbLop.ValueMember = "maLop";
        }

        private void txtMaHocSinh_TextChanged(object sender, EventArgs e)
        {
            foreach(HoSoHocSinh hs in bulHS.layTatHoSoHocSinh())
            {
                if (hs.MaHocSinh == txtMaHocSinh.Text)
                {
                    txtHoTen.Text = hs.HoTen;
                    dtNgaySinh.Text = hs.NgaySinh;
                    cbGioiTinh.Text =hs.GioiTinh;
                    txtDiaChi.Text =hs.DiaChi;
                    txtDiemVaoTruong.Text = hs.DiemVaoTruong+"";
                    txtHoTenBoMe.Text = hs.HoTenBoMe ;
                    txtSoDienThoai.Text =hs.SoDienThoai;
                    cbLop.SelectedValue =hs.MaLop;
                    break;
                }
                else
                {
                    txtHoTen.Text = "";
                    dtNgaySinh.Text = "";
                    txtDiaChi.Text = "";
                    txtDiemVaoTruong.Text = "";
                    txtHoTenBoMe.Text = "";
                    txtSoDienThoai.Text = "";
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Hủy thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
