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
    public partial class frmXoaLopHoc : Form
    {
        LopBUL bulLop = new LopBUL();
        CanBoGiaoVienBUL bulCB = new CanBoGiaoVienBUL();
        public frmXoaLopHoc()
        {
            InitializeComponent();
        }
        void loadCB()
        {
            cbGiaoVien.DataSource = bulCB.layTatCBGV();
            cbGiaoVien.DisplayMember = "hoTen";
            cbGiaoVien.ValueMember = "maCBGV";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
         
        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Chắc chắn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Lop l = new Lop(txtMaLop.Text, txtTenLop.Text, txtNienKhoa.Text, int.Parse(txtSiSo.Text), cbGiaoVien.SelectedValue + "");
                    bulLop.xoaLop(l);
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmXoaLopHoc_Load(object sender, EventArgs e)
        {
            loadCB();
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            foreach (Lop l in bulLop.layTatLop())
            {
                if (l.MaLop == txtMaLop.Text)
                {
                
                    txtTenLop.Text = l.TenLop;
                    txtNienKhoa.Text = l.NienKhoa;
                    txtSiSo.Text = l.SiSo +"";
                    cbGiaoVien.SelectedValue = l.MaCBGV;
                    break;
                }
                else
                {
                    txtTenLop.Text = "";
                    txtNienKhoa.Text = "";
                    txtSiSo.Text = "";
                   
                }
            }
        }
    }
}
