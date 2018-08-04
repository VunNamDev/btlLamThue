using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class PhanCongGiangDayDAL
    {
      /*  public List<PhanCongGiangDay> layMonHoc()
        {
            List<PhanCongGiangDay> arr = new List<PhanCongGiangDay>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from PhanCongGiangDay";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PhanCongGiangDay x = new PhanCongGiangDay(dr["maLop"] + "", dr["maMon"] + "", dr["maCBGV"] + "", ((DateTime)dr["ngayPhanCong"]).ToString("dd/MM/yyyy"));
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }*/
        public DataTable layPhanCongGiangDayTheoTen()
        {
            KetNoiCSDL.moKetNoi();
            string get = "select tenLop ,tenMon ,hoTen, ngayPhanCong from PhanCongGiangDay inner join MonHoc on PhanCongGiangDay.maMon=MonHoc.maMon inner join CanBoGiaoVien on CanBoGiaoVien.maCBGV = PhanCongGiangDay.maCBGV inner join Lop on Lop.maLop = PhanCongGiangDay.maLop";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }
        public DataTable layPhanCongGiangDayTheoTenCoDieuKienTheoMonHoc(string maMon)
        {
            KetNoiCSDL.moKetNoi();
            string get = "select tenLop ,tenMon ,hoTen, ngayPhanCong from PhanCongGiangDay inner join MonHoc on PhanCongGiangDay.maMon=MonHoc.maMon inner join CanBoGiaoVien on CanBoGiaoVien.maCBGV = PhanCongGiangDay.maCBGV inner join Lop on Lop.maLop = PhanCongGiangDay.maLop where PhanCongGiangDay.maMon = @maMon";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maMon", maMon);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }
        public DataTable layPhanCongGiangDayTheoTenCoDieuKienTheoGiaoVien(string maCBGV)
        {
            KetNoiCSDL.moKetNoi();
            string get = "select tenLop ,tenMon ,hoTen, ngayPhanCong from PhanCongGiangDay inner join MonHoc on PhanCongGiangDay.maMon=MonHoc.maMon inner join CanBoGiaoVien on CanBoGiaoVien.maCBGV = PhanCongGiangDay.maCBGV inner join Lop on Lop.maLop = PhanCongGiangDay.maLop where PhanCongGiangDay.maCBGV = @maCBGV";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maCBGV", maCBGV);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }
        public DataTable layPhanCongGiangDayTheoTenCoDieuKienTheoLopHoc(string maLop)
        {
            KetNoiCSDL.moKetNoi();
            string get = "select tenLop ,tenMon ,hoTen, ngayPhanCong from PhanCongGiangDay inner join MonHoc on PhanCongGiangDay.maMon=MonHoc.maMon inner join CanBoGiaoVien on CanBoGiaoVien.maCBGV = PhanCongGiangDay.maCBGV inner join Lop on Lop.maLop = PhanCongGiangDay.maLop where PhanCongGiangDay.maLop = @maLop";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", maLop);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }
        public void themPhanCongGiangDay(PhanCongGiangDay pc)
        {

            KetNoiCSDL.moKetNoi();
            string add = "insert into PhanCongGiangDay values (@maLop , @maMon , @maCBGV , @ngayPhanCong) ";

            SqlCommand cmd = new SqlCommand(add, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", pc.MaLop);
            cmd.Parameters.AddWithValue("maMon",pc.MaMon);
            cmd.Parameters.AddWithValue("maCBGV", pc.MaCBGV);
            cmd.Parameters.AddWithValue("ngayPhanCong", pc.NgayPhanCong);
           
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
