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
    public partial class frmSuaDiem : Form
    {
        DiemBUL diemBUL = new DiemBUL();
        string maLop = "";
        string maMon = "";
        public frmSuaDiem(string maLop,string maMon)
        {
            InitializeComponent();
            this.maLop = maLop;
            this.maMon = maMon;
            DataTable workTable = diemBUL.layTatDiemCoTenHocSinh(maLop, maMon);
            workTable.Columns.Add("diemKy1Moi");
            workTable.Columns.Add("diemKy2Moi");
            dgvSuaDiem.DataSource = workTable;
        }

        private void frmSuaDiem_Load(object sender, EventArgs e)
        {
            dgvSuaDiem.Columns[0].ReadOnly = true;
            dgvSuaDiem.Columns[1].ReadOnly = true;
            dgvSuaDiem.Columns[2].ReadOnly = true;
            dgvSuaDiem.Columns[3].ReadOnly = true;
            dgvSuaDiem.Columns[4].ReadOnly = true;
            dgvSuaDiem.Columns[5].ReadOnly = true;
            dgvSuaDiem.Columns[0].HeaderText = "Mã học sinh";
            dgvSuaDiem.Columns[1].HeaderText = "Tên học sinh";
            dgvSuaDiem.Columns[2].HeaderText = "Mã môn";
            dgvSuaDiem.Columns[3].HeaderText = "Tên môn";
            dgvSuaDiem.Columns[4].HeaderText = "Điểm TB kỳ 1";
            dgvSuaDiem.Columns[5].HeaderText = "Điểm TB kỳ 2";
            dgvSuaDiem.Columns[6].HeaderText = "Điểm TB kỳ 1 mới";
            dgvSuaDiem.Columns[7].HeaderText = "Điểm TB kỳ 2 mới";
        }

        private void dgvSuaDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSuaDiem.Columns[e.ColumnIndex].ReadOnly = false;
            if (dgvSuaDiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                dgvSuaDiem.Columns[e.ColumnIndex].ReadOnly = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvSuaDiem.RowCount - 1; i++)
                {

                    if (dgvSuaDiem.Rows[i].Cells[6].Value.ToString() != "")
                    {
                        Diem d = new Diem(dgvSuaDiem.Rows[i].Cells[0].Value.ToString(), dgvSuaDiem.Rows[i].Cells[2].Value.ToString(), float.Parse(dgvSuaDiem.Rows[i].Cells[6].Value.ToString()), -1);
                        diemBUL.suaDiem1(d);
                    }
                    if (dgvSuaDiem.Rows[i].Cells[7].Value.ToString() != "")
                    {
                        Diem d = new Diem(dgvSuaDiem.Rows[i].Cells[0].Value.ToString(), dgvSuaDiem.Rows[i].Cells[2].Value.ToString(), -1, float.Parse(dgvSuaDiem.Rows[i].Cells[7].Value.ToString()));
                        diemBUL.suaDiem2(d);
                    }
                }
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
