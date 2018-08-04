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
    public class DiemBUL
    {

        DiemDAL dal = new DiemDAL();
        public List<Diem> layTatDiem()
        {
            return dal.layDiem();
        }
        public DataTable layTatDiemCoTenHocSinh(string maLop,string maMon)
        {
            return dal.layDiemCoTenHocSinh(maLop,maMon);
        }
        public void suaDiem1(Diem d)
        {
            dal.suaDiem1(d);
        }
        public void suaDiem2(Diem d)
        {
            dal.suaDiem2(d);
        }
    }
}
