using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
namespace BTL
{
    public partial class frmSuaGiaoVien : Form
    {
        CanBoGiaoVienBUL bulCB = new CanBoGiaoVienBUL();
        public frmSuaGiaoVien()
        {
            InitializeComponent();
        }

        private void btnSuaGiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                CanBoGiaoVien cb = new CanBoGiaoVien();
                cb.MaCBGV = txtMaCBGV.Text;
                cb.HoTen = txtHoTen.Text;
                cb.DiaChi = txtDiaChi.Text;
                cb.SoDienThoai = txtSoDienThoai.Text;
                cb.TaiKhoan = txtTaiKhoan.Text;
                cb.MatKhau = txtMatKhau.Text;
                cb.LoaiTaiKhoan = cbLoaiTaiKhoan.Text;
                bulCB.suaCanBoGiaoVien(cb);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMaCBGV_TextChanged(object sender, EventArgs e)
        {
            foreach(CanBoGiaoVien  cb in bulCB.layTatCBGV())
            {
                if (cb.MaCBGV == txtMaCBGV.Text)
                {
                    txtHoTen.Text = cb.HoTen;
                    txtDiaChi.Text = cb.DiaChi ;
                    txtSoDienThoai.Text =cb.SoDienThoai;
                    txtTaiKhoan.Text = cb.TaiKhoan;
                    txtMatKhau.Text = cb.MatKhau;
                    cbLoaiTaiKhoan.Text = cb.LoaiTaiKhoan;
                    break;
                }
                else
                {
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                }
            }
        }

        private void frmSuaGiaoVien_Load(object sender, EventArgs e)
        {
            loadCBLoaiTK();
        }
        void loadCBLoaiTK()
        {
            string[] arr = new string[2];
            arr[0] = "gv";
            arr[1] = "admin";
            cbLoaiTaiKhoan.DataSource = arr;
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
