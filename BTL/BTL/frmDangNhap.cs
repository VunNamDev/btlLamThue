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
    public partial class frmDangNhap : Form
    {
        CanBoGiaoVienBUL bulCBGV = new CanBoGiaoVienBUL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool check = false;
            
            foreach (CanBoGiaoVien cb in bulCBGV.layTatCBGV())
            {
                if(cb.TaiKhoan == txtTaiKhoan.Text && cb.MatKhau == txtMatKhau.Text)
                {
                    check = true;
                    frmMain frm = new frmMain(cb);                                         
                    frm.Show();
                    Visible = false;
                    break;
                }
            }
            if(!check)
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
