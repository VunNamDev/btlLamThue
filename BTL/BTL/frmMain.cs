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
    public partial class frmMain : Form
    {
        bool isFormActive = true;
        public static bool gv = false;
        public static bool admin = false;
        MonHocBUL monHocBUL = new MonHocBUL();
        CanBoGiaoVienBUL canBoGiaoVienBUL = new BUL.CanBoGiaoVienBUL();
        DiemBUL diemBUL = new DiemBUL();
        HoSoHocSinhBUL hoSoHocSinhBUL = new HoSoHocSinhBUL();
        LopBUL lopBUL = new LopBUL();
        PhanCongGiangDayBUL phanCongGiangDayBUL = new PhanCongGiangDayBUL();


        CanBoGiaoVienBUL bulCBGV = new CanBoGiaoVienBUL();
        public frmMain()
        {
            InitializeComponent();
        }
       
    
        private void frmMain_Load(object sender, EventArgs e)
        {
            

            hienCanBoGiaoVien();
            hienDiem();
            hienHoSoHocSinh();
            hienLop();
            hienMonHoc();
            hienLichPhanCong();
            hienCBTenMon();
            hienCBTenLop();
          

            lanDau();
            //MessageBox.Show(admin.ToString());
            // MessageBox.Show(gv.ToString());
        }
        void reloadDGV()
        {
            hienMonHoc();
            hienLop();
            hienHoSoHocSinh();
            hienCanBoGiaoVien();
            hienDiem();
        }
        void lanDau()
        {

            lbLop.Text = "";
            lbMaLop.Text = "";
            lbMaMon.Text = "";
            lbMon.Text = "";
        }
        void hienCBTenMon_PhanCong()
        {
            cbMonHoc.DataSource = monHocBUL.layTatMonHoc();
            cbMonHoc.DisplayMember = "tenMon";
            cbMonHoc.ValueMember = "maMon";
        }
        void hienCBGiaoVien()
        {
            cbGiaoVien.DataSource = canBoGiaoVienBUL.layTatCBGV();
            cbGiaoVien.DisplayMember = "hoTen";
            cbGiaoVien.ValueMember = "maCBGV";
        }
        void hienCBLop()
        {
            cbLop.DataSource = lopBUL.layTatLop();
            cbLop.DisplayMember = "tenLop";
            cbLop.ValueMember = "maLop";
        }
        void hienMonHoc()
        {
            dgvMonHoc.DataSource = monHocBUL.layTatMonHoc();
            dgvMonHoc.Columns[0].HeaderText = "Mã môn";
            dgvMonHoc.Columns[1].HeaderText = "Tên môn";
            dgvMonHoc.Columns[2].HeaderText = "Số tiết học";
        }
        void hienLop() {
            dgvLop.DataSource = lopBUL.layTatLop();
            dgvLop.Columns[0].HeaderText = "Mã lớp";
            dgvLop.Columns[1].HeaderText = "Tên lớp";
            dgvLop.Columns[2].HeaderText = "Niên khoá";
            dgvLop.Columns[3].HeaderText = "Sĩ số";
            dgvLop.Columns[4].HeaderText = "GV chủ nhiệm";
        }
        void hienHoSoHocSinh()
        {
            dgvHocSinh.DataSource = hoSoHocSinhBUL.layTatHoSoHocSinhCoTenLop();
            dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
            dgvHocSinh.Columns[1].HeaderText = "Họ tên";
            dgvHocSinh.Columns[2].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns[3].HeaderText = "Giới tính";
            dgvHocSinh.Columns[4].HeaderText = "Địa chỉ";
            dgvHocSinh.Columns[5].HeaderText = "Điểm vào trường";
            dgvHocSinh.Columns[6].HeaderText = "Họ tên bố mẹ";
            dgvHocSinh.Columns[7].HeaderText = "Số điện thoại";
            dgvHocSinh.Columns[8].HeaderText = "Tên lớp";
        }
        void hienCBTenMon()
        {
            cbTenMon.DataSource = monHocBUL.layTatMonHoc();
            cbTenMon.DisplayMember = "tenMon";
            cbTenMon.ValueMember = "maMon";
        }
        void hienCBTenLop()
        {
            cbTenLop.DataSource = lopBUL.layTatLop();
            cbTenLop.DisplayMember = "tenLop";
            cbTenLop.ValueMember = "maLop";
        }
        
        void hienCanBoGiaoVien()
        {
            dgvCanBoGiaoVien.DataSource = canBoGiaoVienBUL.layTatCBGV();
        }
        void hienDiem()
        {
            dgvDiem.DataSource = diemBUL.layTatDiemCoTenHocSinh(lbMaLop.Text,lbMaMon.Text);
        }
        void hienLichPhanCong()
        {
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = true;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = false;
            hienCBGiaoVien();
            hienCBLop();
            hienCBTenMon_PhanCong();
            dtNgay.Value = DateTime.Today;
            dgvLichPhanCong.DataSource = phanCongGiangDayBUL.layTatPhanCongGiangDay();

            string[] arr = new string[3];
            arr[0] = "Mã lớp";
            arr[1] = "Mã môn";
            arr[2] = "Mã giáo viên";
            cbLoai.DataSource = arr;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelEx4_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            hienMonHoc();
            tabMonHoc.Visible = true;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = false;
        }

     

 

    
        private void btnDanhSachHocSinh_Click(object sender, EventArgs e)
        {
     
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = true;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = false;
        }

        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
          
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = true;
            tabLop.Visible = false;
        }

        private void btnXemLichPhanCng_Click(object sender, EventArgs e)
        {
            hienLichPhanCong();
          
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            hienDiem();
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = true;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = false;
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            hienHoSoHocSinh();
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = true;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = false;
        }

        private void btnCanBoGiaoVien_Click(object sender, EventArgs e)
        {
            hienCanBoGiaoVien();
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = true;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = false;
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            hienLop();
            tabMonHoc.Visible = false;
            tabHocSinh.Visible = false;
            tabCanBoGiaoVien.Visible = false;
            tabDiem.Visible = false;
            tabLichPhanCong.Visible = false;
            tabDanhSachHocSinh.Visible = false;
            tabDanhSachGiaoVien.Visible = false;
            tabLop.Visible = true;
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTenLop.SelectedIndex != -1)
            {
                //MessageBox.Show( cbTenLop.Text.ToString());
                lbLop.Text = cbTenLop.Text;
                lbMaLop.Text = cbTenLop.SelectedValue.ToString();


            }
        }

        private void cbTenLop_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMon.Text = cbTenMon.Text;
            lbMaMon.Text = cbTenMon.SelectedValue.ToString();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                PhanCongGiangDay pc = new PhanCongGiangDay();
                pc.MaCBGV = cbGiaoVien.SelectedValue.ToString();
                pc.MaLop = cbLop.SelectedValue.ToString();
                pc.MaMon = cbMonHoc.SelectedValue.ToString();
                pc.NgayPhanCong = dtNgay.Value.ToString("MM/dd/yyyy");
                //MessageBox.Show(cbGiaoVien.SelectedValue.ToString() + "  " + cbLop.SelectedValue.ToString() + "   " + cbMonHoc.SelectedValue.ToString() + "   " + dtNgay.Text);
                phanCongGiangDayBUL.ThemPhanCongGiangDay(pc);
                hienLichPhanCong();
                MessageBox.Show("Phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Phân công lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnThemMonhoc_Click(object sender, EventArgs e)
        {
            frmThemMonHoc frm = new frmThemMonHoc();
            frm.ShowDialog();
        }

        private void btnSuaMonHoc_Click(object sender, EventArgs e)
        {
            frmSuaMonHoc frm = new frmSuaMonHoc();
            frm.ShowDialog();
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            frmXoaMonHoc frm = new frmXoaMonHoc();
            frm.ShowDialog();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            frmThemLop frm = new frmThemLop();
            frm.ShowDialog();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            frmSuaLop frm = new frmSuaLop();
            frm.ShowDialog();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            frmXoaLopHoc frm = new frmXoaLopHoc();
            frm.ShowDialog();
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            frmThemHocSinh frm = new frmThemHocSinh();
            frm.ShowDialog();
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            frmSuaHocSinh frm = new frmSuaHocSinh();
            frm.ShowDialog();
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            frmXoaHocSinh frm = new frmXoaHocSinh();
            frm.ShowDialog();
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            frmThemGiaoVien frm = new frmThemGiaoVien();
            frm.ShowDialog();
        }

        private void btnSuaGiaoVien_Click(object sender, EventArgs e)
        {
            frmSuaGiaoVien frm = new frmSuaGiaoVien();
            frm.ShowDialog();
        }

        private void btnXoaGiaoVien_Click(object sender, EventArgs e)
        {
            frmXoaGiaoVien frm = new frmXoaGiaoVien();
            frm.ShowDialog();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            frmNhapDiem frm = new frmNhapDiem(lbMaLop.Text, lbMaMon.Text);
            frm.ShowDialog();
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            frmSuaDiem frm = new frmSuaDiem(lbMaLop.Text, lbMaMon.Text);
            frm.ShowDialog();
        }

        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            isFormActive = false;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                reloadDGV();
                isFormActive = false;
            }
        }

        private void txtMonHoc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTimMonHoc_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = monHocBUL.layTatMonHocTheoDieuKien(txtMonHoc.Text);
        }

        private void btnTimHocSinh_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = hoSoHocSinhBUL.layTatHoSoHocSinhCoTenLopTheoDieuKien(txtHocSinh.Text);
        }

        private void btnTimCanBoGiaoVien_Click(object sender, EventArgs e)
        {
            dgvCanBoGiaoVien.DataSource = canBoGiaoVienBUL.layTatCBGVTheoDieuKien(txtCanBoGiaoVien.Text);
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = lopBUL.layTatLopTheoDieuKien(txtLop.Text);
        }

        private void btnTimLichPhanCong_Click(object sender, EventArgs e)
        {
            if(cbLoai.Text=="Mã môn")
            {
               

                dgvLichPhanCong.DataSource = phanCongGiangDayBUL.layPhanCongGiangDayTheoTenCoDieuKienTheoMonHoc(txtLichPhanCong.Text);
            }
            if (cbLoai.Text == "Mã lớp")
            {
              
                dgvLichPhanCong.DataSource = phanCongGiangDayBUL.layPhanCongGiangDayTheoTenCoDieuKienTheoLopHoc(txtLichPhanCong.Text);
            }
            if (cbLoai.Text == "Mã giáo viên")
            {
               

                dgvLichPhanCong.DataSource = phanCongGiangDayBUL.layPhanCongGiangDayTheoTenCoDieuKienTheoGiaoVien(txtLichPhanCong.Text);
            }
        }
    }
}
