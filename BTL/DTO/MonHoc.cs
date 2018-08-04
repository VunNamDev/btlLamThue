using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        private string maMon;
        private string tenMon;
        private float soTiet;
        public MonHoc()
        {
            
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

        public string TenMon
        {
            get
            {
                return tenMon;
            }

            set
            {
                tenMon = value;
            }
        }

        public float SoTiet
        {
            get
            {
                return soTiet;
            }

            set
            {
                soTiet = value;
            }
        }

        public MonHoc(string maMon, string tenMon, float soTiet)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.SoTiet = soTiet;
        }
    }
}
