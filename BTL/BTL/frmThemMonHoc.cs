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
    public partial class frmThemMonHoc : Form
    {
        MonHocBUL bulMH = new MonHocBUL();

        public frmThemMonHoc()
        {
            InitializeComponent();
        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {

        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            try
            {


                MonHoc mh = new MonHoc(txtMaMon.Text, txtTenMon.Text, float.Parse(txtSoTiet.Text));
                bulMH.themMonHoc(mh);
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
