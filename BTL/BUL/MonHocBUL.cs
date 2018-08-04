using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class MonHocBUL
    {
        MonHocDAL dal = new MonHocDAL();
        public List<MonHoc> layTatMonHoc()
        {
            return dal.layMonHoc();
        }
        public List<MonHoc> layTatMonHocTheoDieuKien(string maMon)
        {
            return dal.layMonHocTheoDieuKien(maMon);
        }
        public void themMonHoc(MonHoc mh)
        {
            dal.themMonHoc(mh);
        }
        public void suaMonHoc(MonHoc mh)
        {
            dal.suaMonHoc(mh);
        }
        public void xoaMonHoc(MonHoc mh)
        {
            dal.xoaMonHoc(mh);
        }
    }
}
