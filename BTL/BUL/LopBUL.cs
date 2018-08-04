using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class LopBUL
    {
        LopDAL dal = new LopDAL();
        public List<Lop> layTatLop()
        {
            return dal.layLop();
        }
        public List<Lop> layTatLopTheoDieuKien(string maLop)
        {
            return dal.layLopTheoDieuKien(maLop);
        }
        public void themLop(Lop l)
        {
            dal.themLop(l);
        }
        public void suaLop(Lop l)
        {
            dal.suaLop(l);
        }
        public void xoaLop(Lop l)
        {
            dal.xoaLop(l);
        }
    }


}
