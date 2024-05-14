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
    public class DiaryDAO : Database
    {
        public DiaryDTO HienThi(DateTime ngayTruyen)
        {
            DiaryDTO ds = new DiaryDTO();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblDiary WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                string nhatky = reader.GetString(1);
                string hinh = reader.GetString(2);

                DiaryDTO day = new DiaryDTO();
                day.Ngay = ngay;
                day.NhatKy = nhatky;
                day.Hinh = hinh;
                ds = day;
            }
            reader.Close();
            return ds;
        }

        public bool Them(DiaryDTO day, DateTime ngayTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblDiary VALUES (@ngay, @nhatky, @hinh)";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = day.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parNK = new SqlParameter("@nhatky", SqlDbType.NVarChar);
            parNK.Value = day.NhatKy;
            sqlCmd.Parameters.Add(parNK);

            SqlParameter parH = new SqlParameter("@hinh", SqlDbType.NVarChar);
            parH.Value = day.Hinh;
            sqlCmd.Parameters.Add(parH);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(DiaryDTO day, DateTime ngayTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE tblDiary WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(DiaryDTO day, DateTime ngayTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblDiary SET Ngay = @ngay, NhatKy = @nhatky WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = day.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parNK = new SqlParameter("@nhatky", SqlDbType.NText);
            parNK.Value = day.NhatKy;
            sqlCmd.Parameters.Add(parNK);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool SuaHinh(DiaryDTO day, DateTime ngayTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblDiary SET Hinh = @hinh WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            SqlParameter parH = new SqlParameter("@hinh", SqlDbType.NVarChar);
            parH.Value = day.Hinh;
            sqlCmd.Parameters.Add(parH);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }
    }
}


