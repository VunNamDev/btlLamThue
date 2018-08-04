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
    public class DiemDAL
    {
        public List<Diem> layDiem()
        {
            List<Diem> arr = new List<Diem>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from Diem";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Diem x = new Diem(dr["maHocSinh"] + "", dr["maMon"] + "",float.Parse( dr["diemTBKy1"] + ""),float.Parse( dr["diemTBky2"] + ""));
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;


        }
        public DataTable layDiemCoTenHocSinh(string maLop, string maMon)
        {
            KetNoiCSDL.moKetNoi();
            string get = "select Diem.maHocSinh, hoTen, Diem.maMon, tenMon, diemTBKy1, diemTBKy2 from Diem inner join HoSoHocSinh on HoSoHocSinh.maHocSinh = Diem.maHocSinh inner join MonHoc on Diem.maMon = MonHoc.maMon inner join Lop on Lop.maLop = HoSoHocSinh.maLop where Lop.maLop = @maLop and MonHoc.maMon = @maMon";

            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", maLop);
            cmd.Parameters.AddWithValue("maMon", maMon);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }
        public void suaDiem1(Diem d)
        {
            string sqlUpdate = "update Diem set  diemTBKy1 = @diemTBKy1 where maHocSinh =@maHocSinh and maMon=@maMon ";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("diemTBKy1", d.DiemTBKy1);
            cmd.Parameters.AddWithValue("maHocSinh", d.MaHocSinh);
            cmd.Parameters.AddWithValue("maMon", d.MaMonHoc);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void suaDiem2(Diem d)
        {
            string sqlUpdate = "update Diem set  diemTBKy2 = @diemTBKy2 where maHocSinh =@maHocSinh and maMon=@maMon ";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("diemTBKy2", d.DiemTBKy2);
            cmd.Parameters.AddWithValue("maHocSinh", d.MaHocSinh);
            cmd.Parameters.AddWithValue("maMon", d.MaMonHoc);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
