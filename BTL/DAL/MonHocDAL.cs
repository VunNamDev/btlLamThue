using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class MonHocDAL
    {
        public List<MonHoc> layMonHoc()
        {
            List<MonHoc> arr = new List<MonHoc>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from MonHoc";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MonHoc x = new MonHoc(dr["maMon"] + "", dr["tenMon"] + "", float.Parse(dr["soTiet"] + ""));
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
        public List<MonHoc> layMonHocTheoDieuKien(string maMon)
        {
            List<MonHoc> arr = new List<MonHoc>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from MonHoc where maMon = @maMon";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maMon", maMon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MonHoc x = new MonHoc(dr["maMon"] + "", dr["tenMon"] + "", float.Parse(dr["soTiet"] + ""));
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }


        public void themMonHoc(MonHoc mh)
        {
            string sqlSelect = "insert into MonHoc values(@maMon ,@tenMon ,@soTiet)";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlSelect, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maMon", mh.MaMon);
            cmd.Parameters.AddWithValue("tenMon", mh.TenMon);
            cmd.Parameters.AddWithValue("soTiet", mh.SoTiet);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
            
        }
        public void suaMonHoc(MonHoc mh)
        {
            string sqlUpdate = "update MonHoc set  tenMon =@tenMon , soTiet =@soTiet where maMon =@maMon ";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maMon", mh.MaMon);
            cmd.Parameters.AddWithValue("tenMon", mh.TenMon);
            cmd.Parameters.AddWithValue("soTiet", mh.SoTiet);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaMonHoc(MonHoc mh)
        {
            string sqlUpdate = "delete from MonHoc where maMon=@maMon";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maMon", mh.MaMon);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
