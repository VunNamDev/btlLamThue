using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoSoHocSinh
    {
        private string maHocSinh;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private float diemVaoTruong;
        private string hoTenBoMe;
        private string soDienThoai;
        private string maLop;

        public string MaHocSinh
        {
            get
            {
                return maHocSinh;
            }

            set
            {
                maHocSinh = value;
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

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
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

        public float DiemVaoTruong
        {
            get
            {
                return diemVaoTruong;
            }

            set
            {
                diemVaoTruong = value;
            }
        }

        public string HoTenBoMe
        {
            get
            {
                return hoTenBoMe;
            }

            set
            {
                hoTenBoMe = value;
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

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

        public HoSoHocSinh(string maHocSinh, string hoTen, string ngaySinh, string gioiTinh, string diaChi, float diemVaoTruong, string hoTenBoMe, string soDienThoai, string maLop)
        {
            this.MaHocSinh = maHocSinh;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.DiemVaoTruong = diemVaoTruong;
            this.HoTenBoMe = hoTenBoMe;
            this.SoDienThoai = soDienThoai;
            this.MaLop = maLop;

        }
         public HoSoHocSinh()
        {
           
        }
    }
}
