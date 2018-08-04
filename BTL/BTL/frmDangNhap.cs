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
            frmMain.gv = false;
            frmMain.admin = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            foreach(CanBoGiaoVien cb in bulCBGV.layTatCBGV())
            {
                if(cb.TaiKhoan == txtTaiKhoan.Text && cb.MatKhau == txtMatKhau.Text)
                {
                    if (cb.LoaiTaiKhoan == "gv")
                    {

                        frmMain.gv = true;
                        frmMain frm = new frmMain();
                        frm.Show();
                        Visible = false;
                       
                        
                    }
                    if (cb.LoaiTaiKhoan == "admin")
                    {

                        frmMain.admin = true;
                        frmMain frm = new frmMain();
                        frm.Show();
                        Visible = false;

                    }

                }
            }
        }
    }
}
