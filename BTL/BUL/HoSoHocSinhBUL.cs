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
    public class HoSoHocSinhBUL
    {
        HoSoHocSinhDAL dal = new HoSoHocSinhDAL();
        public List<HoSoHocSinh> layTatHoSoHocSinh()
        {
            return dal.layHoSoHocSinh();
        }
        public DataTable layTatHoSoHocSinhCoTenLop()
        {
            return dal.layHoSoHocSinhCoTenLop();
        }
        public DataTable layTatHoSoHocSinhCoTenLopTheoDieuKien(string maHocSinh)
        {
            return dal.layHoSoHocSinhCoTenLopTheoDieuKien(maHocSinh);
        }
        public void themHoSoHocSinh(HoSoHocSinh hs)
        {
            dal.themHoSoHocSinh(hs);
        }
        public void suaHoSoHocSinh(HoSoHocSinh hs)
        {
            dal.suaHoSoHocSinh(hs);
        }
        public void xoaHoSoHocSinh(HoSoHocSinh hs)
        {
            dal.xoaHoSoHocSinh(hs);
        }
    }
}
