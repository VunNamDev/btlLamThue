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
    public partial class frmThemGiaoVien : Form
    {
        CanBoGiaoVienBUL bulCB = new CanBoGiaoVienBUL();
        public frmThemGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
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
                bulCB.themCanBoGiaoVien(cb);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }

        private void frmThemGiaoVien_Load(object sender, EventArgs e)
        {
            loadCBLoaiTK();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        void loadCBLoaiTK()
        {
            string[] arr = new string[2];
            arr[0] = "gv";
            arr[1] = "admin";
            cbLoaiTaiKhoan.DataSource = arr;
        }
    }
}
