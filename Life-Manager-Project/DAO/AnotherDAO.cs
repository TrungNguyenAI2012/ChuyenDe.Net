using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AnotherDAO : Database
    {
        public List<AnotherDTO> HienThi()
        {
            List<AnotherDTO> ds = new List<AnotherDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblAnother";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string nhom = reader.GetString(0);
                string ten = reader.GetString(1);
                string chinh = reader.GetString(2);
                string phu = reader.GetString(3);
                string ghichu = reader.GetString(4);
                string the = reader.GetString(5);
                DateTime batdau = reader.GetDateTime(6);
                bool trangthai = reader.GetBoolean(7);
                if (trangthai == true)
                {
                    DateTime ketthuc = reader.GetDateTime(8);
                }
                else
                {
                    DateTime ketthuc = DateTime.Parse("01-01-2000");
                }

                AnotherDTO antr = new AnotherDTO();
                antr.Nhom = nhom;
                antr.Ten = ten;
                antr.Chinh = chinh;
                antr.Phu = phu;
                antr.GhiChu = ghichu;
                antr.The = the;
                antr.BatDau = batdau;
                antr.TrangThai = trangthai;
                antr.KetThuc = batdau;
                ds.Add(antr);
            }
            reader.Close();
            return ds;
        }

        //public List<AnotherDTO> SapXep(string Truyen)
        //{
        //    List<AnotherDTO> ds = new List<AnotherDTO>();
        //    OpenConnection();
        //    SqlCommand sqlCmd = new SqlCommand();
        //    sqlCmd.CommandType = CommandType.Text;
        //    sqlCmd.CommandText = "SELECT Nhom, Ten, Chinh, Phu, GhiChu, The, BatDau, TrangThai, KetThuc FROM tblAnother " +
        //        "ORDER BY " +
        //        "CASE WHEN @Truyen = @nhom THEN Nhom";

        //    SqlParameter parTruyen = new SqlParameter("@Truyen", SqlDbType.VarChar);
        //    parTruyen.Value = Truyen;
        //    sqlCmd.Parameters.Add(parTruyen);

        //    sqlCmd.Connection = sqlCon;
        //    SqlDataReader reader = sqlCmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        string nhom = reader.GetString(0);
        //        string ten = reader.GetString(1);
        //        string chinh = reader.GetString(2);
        //        string phu = reader.GetString(3);
        //        string ghichu = reader.GetString(4);
        //        string the = reader.GetString(5);
        //        DateTime batdau = reader.GetDateTime(6);
        //        bool trangthai = reader.GetBoolean(7);
        //        if (trangthai == true)
        //        {
        //            DateTime ketthuc = reader.GetDateTime(8);
        //        }
        //        else
        //        {
        //            DateTime ketthuc = DateTime.Parse("01-01-2000");
        //        }

        //        AnotherDTO antr = new AnotherDTO();
        //        antr.Nhom = nhom;
        //        antr.Ten = ten;
        //        antr.Chinh = chinh;
        //        antr.Phu = phu;
        //        antr.GhiChu = ghichu;
        //        antr.The = the;
        //        antr.BatDau = batdau;
        //        antr.TrangThai = trangthai;
        //        antr.KetThuc = batdau;
        //        ds.Add(antr);
        //    }
        //    reader.Close();
        //    return ds;
        //}

        public bool Them(AnotherDTO antr)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblAnother VALUES (@nhom, @ten, @chinh, @phu, @ghichu, @the, @batdau, @trangthai, @ketthuc)";

            SqlParameter parNhom = new SqlParameter("@nhom", SqlDbType.NVarChar);
            parNhom.Value = antr.Nhom;
            sqlCmd.Parameters.Add(parNhom);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = antr.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parChinh = new SqlParameter("@chinh", SqlDbType.NVarChar);
            parChinh.Value = antr.Chinh;
            sqlCmd.Parameters.Add(parChinh);

            SqlParameter parPhu = new SqlParameter("@phu", SqlDbType.NVarChar);
            parPhu.Value = antr.Phu;
            sqlCmd.Parameters.Add(parPhu);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = antr.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            SqlParameter parThe = new SqlParameter("@the", SqlDbType.NVarChar);
            parThe.Value = antr.The;
            sqlCmd.Parameters.Add(parThe);

            SqlParameter parBD = new SqlParameter("@batdau", SqlDbType.Date);
            parBD.Value = antr.BatDau;
            sqlCmd.Parameters.Add(parBD);

            SqlParameter parTT = new SqlParameter("@trangthai", SqlDbType.Bit);
            parTT.Value = antr.TrangThai;
            sqlCmd.Parameters.Add(parTT);

            SqlParameter parKT = new SqlParameter("@ketthuc", SqlDbType.Date);
            parKT.Value = antr.KetThuc;
            sqlCmd.Parameters.Add(parKT);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(AnotherDTO antr)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblAnother WHERE Nhom = @Nhom AND Ten = @ten AND Chinh = @chinh";

            SqlParameter parNhom = new SqlParameter("@nhom", SqlDbType.NVarChar);
            parNhom.Value = antr.Nhom;
            sqlCmd.Parameters.Add(parNhom);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = antr.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parChinh = new SqlParameter("@chinh", SqlDbType.NVarChar);
            parChinh.Value = antr.Chinh;
            sqlCmd.Parameters.Add(parChinh);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(AnotherDTO antr, string nhomTruyen, string tenTruyen, string chinhTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblAnother SET Nhom = @nhom, Ten = @ten, Chinh = @chinh, Phu = @phu, GhiChu = @ghichu, The = @the, BatDau = @batdau, TrangThai = @trangthai, KetThuc = @ketthuc WHERE Nhom = @nhomTruyen AND Ten = @tenTruyen AND Chinh = @chinhTruyen";

            SqlParameter parNhomTruyen = new SqlParameter("@nhomTruyen", SqlDbType.NVarChar);
            parNhomTruyen.Value = nhomTruyen;
            sqlCmd.Parameters.Add(parNhomTruyen);

            SqlParameter parTenTruyen = new SqlParameter("@tenTruyen", SqlDbType.NVarChar);
            parTenTruyen.Value = tenTruyen;
            sqlCmd.Parameters.Add(parTenTruyen);

            SqlParameter parChinhTruyen = new SqlParameter("@chinhTruyen", SqlDbType.NVarChar);
            parChinhTruyen.Value = chinhTruyen;
            sqlCmd.Parameters.Add(parChinhTruyen);

            SqlParameter parNhom = new SqlParameter("@nhom", SqlDbType.NVarChar);
            parNhom.Value = antr.Nhom;
            sqlCmd.Parameters.Add(parNhom);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = antr.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parChinh = new SqlParameter("@chinh", SqlDbType.NVarChar);
            parChinh.Value = antr.Chinh;
            sqlCmd.Parameters.Add(parChinh);

            SqlParameter parPhu = new SqlParameter("@phu", SqlDbType.NVarChar);
            parPhu.Value = antr.Phu;
            sqlCmd.Parameters.Add(parPhu);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = antr.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            SqlParameter parThe = new SqlParameter("@the", SqlDbType.NVarChar);
            parThe.Value = antr.The;
            sqlCmd.Parameters.Add(parThe);

            SqlParameter parBD = new SqlParameter("@batdau", SqlDbType.Date);
            parBD.Value = antr.BatDau;
            sqlCmd.Parameters.Add(parBD);

            SqlParameter parTT = new SqlParameter("@trangthai", SqlDbType.Bit);
            parTT.Value = antr.TrangThai;
            sqlCmd.Parameters.Add(parTT);

            SqlParameter parKT = new SqlParameter("@ketthuc", SqlDbType.Date);
            parKT.Value = antr.KetThuc;
            sqlCmd.Parameters.Add(parKT);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        //public List<AnotherDTO> HienThi(string truyen)
        //{
        //    List<AnotherDTO> ds = new List<AnotherDTO>();
        //    OpenConnection();
        //    SqlCommand sqlCmd = new SqlCommand();
        //    sqlCmd.CommandType = CommandType.Text;
        //    sqlCmd.CommandText = "SELECT * FROM tblAnother ORDER BY @truyen";

        //    SqlParameter parTruyen = new SqlParameter("@truyen", SqlDbType.NVarChar);
        //    parTruyen.Value = truyen;
        //    sqlCmd.Parameters.Add(parTruyen);

        //    sqlCmd.Connection = sqlCon;
        //    SqlDataReader reader = sqlCmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        string nhom = reader.GetString(0);
        //        string ten = reader.GetString(1);
        //        string chinh = reader.GetString(2);
        //        string phu = reader.GetString(3);
        //        string ghichu = reader.GetString(4);
        //        string the = reader.GetString(5);
        //        DateTime batdau = reader.GetDateTime(6);
        //        bool trangthai = reader.GetBoolean(7);
        //        if (trangthai == true)
        //        {
        //            DateTime ketthuc = reader.GetDateTime(8);
        //        }
        //        else
        //        {
        //            DateTime ketthuc = DateTime.Parse("01-01-2000");
        //        }

        //        AnotherDTO antr = new AnotherDTO();
        //        antr.Nhom = nhom;
        //        antr.Ten = ten;
        //        antr.Chinh = chinh;
        //        antr.Phu = phu;
        //        antr.GhiChu = ghichu;
        //        antr.The = the;
        //        antr.BatDau = batdau;
        //        antr.TrangThai = trangthai;
        //        antr.KetThuc = batdau;
        //        ds.Add(antr);
        //    }
        //    reader.Close();
        //    return ds;
        //}
    }
}
