using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem
    {
        private string maHocSinh;
        private string maMonHoc;
        private float diemTBKy1;
        private float diemTBKy2;
        public Diem()
        {
           
        }
        public Diem(string maHocSinh, string maMonHoc, float diemTBKy1, float diemTBKy2)
        {
            this.maHocSinh = maHocSinh;
            this.maMonHoc = maMonHoc;
            this.diemTBKy1 = diemTBKy1;
            this.diemTBKy2 = diemTBKy2;
        }

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

        public string MaMonHoc
        {
            get
            {
                return maMonHoc;
            }

            set
            {
                maMonHoc = value;
            }
        }

        public float DiemTBKy1
        {
            get
            {
                return diemTBKy1;
            }

            set
            {
                diemTBKy1 = value;
            }
        }

        public float DiemTBKy2
        {
            get
            {
                return diemTBKy2;
            }

            set
            {
                diemTBKy2 = value;
            }
        }
    }
}
