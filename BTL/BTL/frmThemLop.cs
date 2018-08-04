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
    public partial class frmThemLop : Form
    {
        LopBUL bulLop = new LopBUL();
        CanBoGiaoVienBUL bulCB = new CanBoGiaoVienBUL();
        public frmThemLop()
        {
            InitializeComponent();
        }

        private void frmThemLop_Load(object sender, EventArgs e)
        {
            loadCB();
        }
        void loadCB()
        {
            cbGiaoVien.DataSource = bulCB.layTatCBGV();
            cbGiaoVien.DisplayMember = "hoTen";
            cbGiaoVien.ValueMember = "maCBGV";
        }

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                Lop l = new Lop(txtMaLop.Text, txtTenLop.Text, txtNienKhoa.Text, int.Parse(txtSiSo.Text), cbGiaoVien.SelectedValue + "");
                bulLop.themLop(l);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
