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
    public class PhanCongGiangDayBUL
    {
        PhanCongGiangDayDAL dal = new PhanCongGiangDayDAL();
        public DataTable layTatPhanCongGiangDay()
        {
            return dal.layPhanCongGiangDayTheoTen();
        }
        public void ThemPhanCongGiangDay(PhanCongGiangDay pc)
        {
            dal.themPhanCongGiangDay(pc);
        }
        public DataTable layPhanCongGiangDayTheoTenCoDieuKienTheoGiaoVien(string maCBGV)
        {
            return dal.layPhanCongGiangDayTheoTenCoDieuKienTheoGiaoVien(maCBGV);
        }
        public DataTable layPhanCongGiangDayTheoTenCoDieuKienTheoLopHoc(string maLop)
        {
            return dal.layPhanCongGiangDayTheoTenCoDieuKienTheoLopHoc(maLop);
        }
        public DataTable layPhanCongGiangDayTheoTenCoDieuKienTheoMonHoc(string maMon)
        {
            return dal.layPhanCongGiangDayTheoTenCoDieuKienTheoMonHoc(maMon);
        }
    }
}
