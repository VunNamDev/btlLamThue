using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        private string maLop;
        private string tenLop;
        private string nienKhoa;
        private int siSo;
        private string maCBGV;

        public Lop()
        {
          
        }
        public Lop(string maLop, string tenLop, string nienKhoa, int siSo, string maCBGV)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.nienKhoa = nienKhoa;
            this.siSo = siSo;
            this.maCBGV = maCBGV;
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

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
            }
        }

        public string NienKhoa
        {
            get
            {
                return nienKhoa;
            }

            set
            {
                nienKhoa = value;
            }
        }

        public int SiSo
        {
            get
            {
                return siSo;
            }

            set
            {
                siSo = value;
            }
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
    }
}
