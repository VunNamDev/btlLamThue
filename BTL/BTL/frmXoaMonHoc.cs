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
    public partial class frmXoaMonHoc : Form
    {

        MonHocBUL bulMH = new MonHocBUL();
        public frmXoaMonHoc()
        {
            InitializeComponent();
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Chắc chắn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MonHoc mh = new MonHoc(txtMaMon.Text, txtTenMon.Text, float.Parse(txtSoTiet.Text));
                    bulMH.xoaMonHoc(mh);
                    MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {
            foreach (MonHoc mh in bulMH.layTatMonHoc())
            {
                if (mh.MaMon == txtMaMon.Text)
                {
                    txtTenMon.Text = mh.TenMon;
                    txtSoTiet.Text = mh.SoTiet + "";
                    break;
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
