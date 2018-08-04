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
    public partial class frmNhapDiem : Form
    {
        DiemBUL diemBUL = new DiemBUL();
        string maLop = "";
        string maMon = "";
        public frmNhapDiem(string maLop, string maMon)
        {
            InitializeComponent();
            this.maLop = maLop;
            this.maMon = maMon;
            DataTable workTable = diemBUL.layTatDiemCoTenHocSinh(maLop, maMon);
            dgvNhapDiem.DataSource = workTable;
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            dgvNhapDiem.Columns[0].HeaderText = "Mã học sinh";
            dgvNhapDiem.Columns[1].HeaderText = "Tên học sinh";
            dgvNhapDiem.Columns[2].HeaderText = "Mã môn";
            dgvNhapDiem.Columns[3].HeaderText = "Tên môn";
            dgvNhapDiem.Columns[4].HeaderText = "Điểm TB kỳ 1";
            dgvNhapDiem.Columns[5].HeaderText = "Điểm TB kỳ 2";
        
        }

        private void dgvNhapDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhapDiem.Columns[e.ColumnIndex].ReadOnly = false;
            if (dgvNhapDiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                dgvNhapDiem.Columns[e.ColumnIndex].ReadOnly = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvNhapDiem.RowCount - 1; i++)
                {

                    if (dgvNhapDiem.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        Diem d = new Diem(dgvNhapDiem.Rows[i].Cells[0].Value.ToString(), dgvNhapDiem.Rows[i].Cells[2].Value.ToString(), float.Parse(dgvNhapDiem.Rows[i].Cells[4].Value.ToString()), -1);
                        diemBUL.suaDiem1(d);
                    }
                    if (dgvNhapDiem.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        Diem d = new Diem(dgvNhapDiem.Rows[i].Cells[0].Value.ToString(), dgvNhapDiem.Rows[i].Cells[2].Value.ToString(), -1, float.Parse(dgvNhapDiem.Rows[i].Cells[5].Value.ToString()));
                        diemBUL.suaDiem2(d);
                    }
                }
                MessageBox.Show("Nhập điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Nhập điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
