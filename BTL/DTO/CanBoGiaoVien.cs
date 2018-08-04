using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CanBoGiaoVien
    {
        private string maCBGV;
        private string hoTen;
        private string diaChi;
        private string soDienThoai;
        private string taiKhoan;
        private string matKhau;
        private string loaiTaiKhoan;

        public CanBoGiaoVien()
        {
            
        }
        public CanBoGiaoVien(string maCBGV, string hoTen, string diaChi, string soDienThoai, string taiKhoan, string matKhau, string loaiTaiKhoan)
        {
            this.maCBGV = maCBGV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }

        public string MaCBGV
        {
            get
            {
                return maCBGV;
            }

            set
            {
                maCBGV = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string TaiKhoan
        {
            get
            {
                return taiKhoan;
            }

            set
            {
                taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string LoaiTaiKhoan
        {
            get
            {
                return loaiTaiKhoan;
            }

            set
            {
                loaiTaiKhoan = value;
            }
        }
    }
}
