using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongGiangDay
    {
        private string maLop;
        private string maMon;
        private string maCBGV;
        private string ngayPhanCong;

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

        public string MaMon
        {
            get
            {
                return maMon;
            }

            set
            {
                maMon = value;
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

        public string NgayPhanCong
        {
            get
            {
                return ngayPhanCong;
            }

            set
            {
                ngayPhanCong = value;
            }
        }
        public PhanCongGiangDay()
        {
            
        }
        public PhanCongGiangDay(string maLop, string maMon, string maCBGV, string ngayPhanCong)
        {
            this.MaLop = maLop;
            this.MaMon = maMon;
            this.MaCBGV = maCBGV;
            this.NgayPhanCong = ngayPhanCong;
        }
    }
}
