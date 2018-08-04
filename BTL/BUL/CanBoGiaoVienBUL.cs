using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUL
{
    public class CanBoGiaoVienBUL
    {
        CanBoGiaoVienDAL dal = new CanBoGiaoVienDAL();
        public List<CanBoGiaoVien> layTatCBGV()
        {
            return dal.layCBGV();
        }
        public List<CanBoGiaoVien> layTatCBGVTheoDieuKien(string maCBGV)
        {
            return dal.layCBGVTheoDieuKien(maCBGV);
        }
        public void themCanBoGiaoVien(CanBoGiaoVien cb)
        {
            dal.themCanBoGiaoVien(cb);
        }
        public void suaCanBoGiaoVien(CanBoGiaoVien cb)
        {
            dal.suaCanBoGiaoVien(cb);
        }
        public void xoaCanBoGiaoVien(CanBoGiaoVien cb)
        {
            dal.xoaCanBoGiaoVien(cb);
        }
    }
}
