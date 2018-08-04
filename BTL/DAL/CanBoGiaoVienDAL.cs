using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class CanBoGiaoVienDAL
    {
        public List<CanBoGiaoVien> layCBGV()
        {
            List<CanBoGiaoVien> arr = new List<CanBoGiaoVien>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from CanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CanBoGiaoVien x = new CanBoGiaoVien(dr["maCBGV"] + "", dr["hoTen"] + "", dr["diaChi"] + "",
                    dr["soDienThoai"] + "", dr["taiKhoan"] + "", dr["matKhau"] + "",
                    dr["loaiTaiKhoan"] + "");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
          
            
        }
        public List<CanBoGiaoVien> layCBGVTheoDieuKien(string maCBGV)
        {
            List<CanBoGiaoVien> arr = new List<CanBoGiaoVien>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from CanBoGiaoVien where maCBGV=@maCBGV";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maCBGV", maCBGV);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CanBoGiaoVien x = new CanBoGiaoVien(dr["maCBGV"] + "", dr["hoTen"] + "", dr["diaChi"] + "",
                    dr["soDienThoai"] + "", dr["taiKhoan"] + "", dr["matKhau"] + "",
                    dr["loaiTaiKhoan"] + "");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;


        }
        public void themCanBoGiaoVien(CanBoGiaoVien cb)
        {
            string sqlSelect = "insert into CanBoGiaoVien values(@maCBGV ,@hoTen ,@diaChi, @soDienThoai, @taiKhoan, @matKhau, @loaiTaiKhoan)";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlSelect, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maCBGV",cb.MaCBGV );
            cmd.Parameters.AddWithValue("hoTen", cb.HoTen);
            cmd.Parameters.AddWithValue("diaChi",cb.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", cb.SoDienThoai);
            cmd.Parameters.AddWithValue("taiKhoan", cb.TaiKhoan);
            cmd.Parameters.AddWithValue("matKhau", cb.MatKhau);
            cmd.Parameters.AddWithValue("loaiTaiKhoan", cb.LoaiTaiKhoan);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();

        }
        public void suaCanBoGiaoVien(CanBoGiaoVien cb)
        {
            string sqlUpdate = "update CanBoGiaoVien set  hoTen = @hoTen ,diaChi=@diaChi,soDienThoai= @soDienThoai,taiKhoan= @taiKhoan ,matKhau= @matKhau ,loaiTaiKhoan= @loaiTaiKhoan where maCBGV =@maCBGV ";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maCBGV", cb.MaCBGV);
            cmd.Parameters.AddWithValue("hoTen", cb.HoTen);
            cmd.Parameters.AddWithValue("diaChi", cb.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", cb.SoDienThoai);
            cmd.Parameters.AddWithValue("taiKhoan", cb.TaiKhoan);
            cmd.Parameters.AddWithValue("matKhau", cb.MatKhau);
            cmd.Parameters.AddWithValue("loaiTaiKhoan", cb.LoaiTaiKhoan);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaCanBoGiaoVien(CanBoGiaoVien cb)
        {
            string sqlUpdate = "delete from CanBoGiaoVien where maCBGV=@maCBGV";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maCBGV", cb.MaCBGV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
