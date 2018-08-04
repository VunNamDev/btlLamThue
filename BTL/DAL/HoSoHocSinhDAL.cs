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
    public class HoSoHocSinhDAL
    {
        public List<HoSoHocSinh> layHoSoHocSinh()
        {
            List<HoSoHocSinh> arr = new List<HoSoHocSinh>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from HoSoHocSinh";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoSoHocSinh x = new HoSoHocSinh(dr["maHocSinh"] + "", dr["hoTen"] + "",dr["ngaySinh"] + "", dr["gioiTinh"] + "",dr["diaChi"] + "",
                    float.Parse( dr["diemVaoTruong"]+""),dr["hoTenBoMe"]+"",dr["soDienThoai"]+"",dr["maLop"]+"");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;


        }
        public DataTable layHoSoHocSinhCoTenLop()
        {
            KetNoiCSDL.moKetNoi();
            string get = "select maHocSinh ,hoTen ,ngaySinh, gioiTinh, diaChi, diemVaoTruong, hoTenBoMe, soDienThoai ,tenLop from HoSoHocSinh inner join Lop on HoSoHocSinh.maLop=Lop.maLop";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }
        public DataTable layHoSoHocSinhCoTenLopTheoDieuKien(string maHocSinh)
        {
            KetNoiCSDL.moKetNoi();
            string get = "select maHocSinh ,hoTen ,ngaySinh, gioiTinh, diaChi, diemVaoTruong, hoTenBoMe, soDienThoai ,tenLop from HoSoHocSinh inner join Lop on HoSoHocSinh.maLop=Lop.maLop where maHocSinh=@maHocSinh";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHocSinh", maHocSinh);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            KetNoiCSDL.dongKetNoi();
            return tb;
        }

        public void themHoSoHocSinh(HoSoHocSinh hs)
        {
            string sqlSelect = "insert into HoSoHocSinh values(@maHocSinh ,@hoTen ,@ngaySinh, @gioiTinh, @diaChi, @diemVaoTruong, @hoTenBoMe, @soDienThoai, @maLop)";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlSelect, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHocSinh", hs.MaHocSinh);
            cmd.Parameters.AddWithValue("hoTen",hs.HoTen);
            cmd.Parameters.AddWithValue("ngaySinh", hs.NgaySinh);
            cmd.Parameters.AddWithValue("gioiTinh", hs.GioiTinh);
            cmd.Parameters.AddWithValue("diaChi", hs.DiaChi);
            cmd.Parameters.AddWithValue("diemVaoTruong", hs.DiemVaoTruong);
            cmd.Parameters.AddWithValue("hoTenBoMe", hs.HoTenBoMe);
            cmd.Parameters.AddWithValue("soDienThoai", hs.SoDienThoai);
            cmd.Parameters.AddWithValue("maLop",hs.MaLop);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();

        }
        public void suaHoSoHocSinh(HoSoHocSinh hs)
        {
            string sqlUpdate = "update HoSoHocSinh set  hoTen = @hoTen ,ngaySinh=@ngaySinh,gioiTinh= @gioiTinh,diaChi= @diaChi ,diemVaoTruong= @diemVaoTruong ,hoTenBoMe= @hoTenBoMe ,soDienThoai= @soDienThoai ,maLop= @maLop where maHocSinh =@maHocSinh ";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHocSinh", hs.MaHocSinh);
            cmd.Parameters.AddWithValue("hoTen", hs.HoTen);
            cmd.Parameters.AddWithValue("ngaySinh", hs.NgaySinh);
            cmd.Parameters.AddWithValue("gioiTinh", hs.GioiTinh);
            cmd.Parameters.AddWithValue("diaChi", hs.DiaChi);
            cmd.Parameters.AddWithValue("diemVaoTruong", hs.DiemVaoTruong);
            cmd.Parameters.AddWithValue("hoTenBoMe", hs.HoTenBoMe);
            cmd.Parameters.AddWithValue("soDienThoai", hs.SoDienThoai);
            cmd.Parameters.AddWithValue("maLop", hs.MaLop);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaHoSoHocSinh(HoSoHocSinh hs)
        {
            string sqlUpdate = "delete from HoSoHocSinh where maHocSinh=@maHocSinh";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHocSinh",hs.MaHocSinh);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
