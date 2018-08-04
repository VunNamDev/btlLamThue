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
    public class LopDAL
    {
        public List<Lop> layLop()
        {
            List<Lop> arr = new List<Lop>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from Lop";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lop x = new Lop(dr["maLop"] + "", dr["tenLop"] + "", dr["nienKhoa"] + "",int.Parse(dr["siSo"] + ""), dr["maCBGV"] + "");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;


        }

        public DataTable layLopCoTen()
        {
            KetNoiCSDL.moKetNoi();
            string get = "select maLop ,tenLop ,nienKhoa, siSo, hoTen from CanBoGiaoVien inner join Lop on CanBoGiaoVien.maCBGV=Lop.maCBGV";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }

        public List<Lop> layLopTheoDieuKien(string maLop)
        {
            List<Lop> arr = new List<Lop>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from Lop where maLop=@maLop";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", maLop);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lop x = new Lop(dr["maLop"] + "", dr["tenLop"] + "", dr["nienKhoa"] + "", int.Parse(dr["siSo"] + ""), dr["maCBGV"] + "");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;


        }

        public void themLop(Lop l)
        {
            string sqlSelect = "insert into Lop values(@maLop ,@tenLop ,@nienKhoa, @siSo, @maCBGV)";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlSelect, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", l.MaLop);
            cmd.Parameters.AddWithValue("tenLop", l.TenLop);
            cmd.Parameters.AddWithValue("nienKhoa", l.NienKhoa);
            cmd.Parameters.AddWithValue("siSo", l.SiSo);
            cmd.Parameters.AddWithValue("maCBGV", l.MaCBGV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();

        }
        public void suaLop(Lop l)
        {
            string sqlUpdate = "update Lop set  tenLop = @tenLop ,nienKhoa=@nienKhoa,siSo= @siSo,maCBGV= @maCBGV where maLop =@maLop ";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", l.MaLop);
            cmd.Parameters.AddWithValue("tenLop", l.TenLop);
            cmd.Parameters.AddWithValue("nienKhoa", l.NienKhoa);
            cmd.Parameters.AddWithValue("siSo", l.SiSo);
            cmd.Parameters.AddWithValue("maCBGV", l.MaCBGV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaLop(Lop l)
        {
            string sqlUpdate = "delete from Lop where maLop=@maLop";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLop", l.MaLop);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }

    }
}
