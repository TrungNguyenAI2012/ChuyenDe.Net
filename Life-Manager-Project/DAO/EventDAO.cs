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
    public class EventDAO : Database
    {
        public List<EventDTO> HienThi()
        {
            List<EventDTO> ds = new List<EventDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblEvent";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                string ten = reader.GetString(1);
                string ghichu = reader.GetString(2);
                TimeSpan batdau = reader.GetTimeSpan(3);
                TimeSpan ketthuc = reader.GetTimeSpan(4);

                EventDTO evt = new EventDTO();
                evt.Ngay = ngay;
                evt.Ten = ten;
                evt.GhiChu = ghichu;
                evt.BatDau = batdau;
                evt.KetThuc = ketthuc;
                ds.Add(evt);
            }
            reader.Close();
            return ds;
        }

        public List<EventDTO> HienThi(DateTime ngayTruyen)
        {
            List<EventDTO> ds = new List<EventDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblEvent WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                string ten = reader.GetString(1);
                string ghichu = reader.GetString(2);
                TimeSpan batdau = reader.GetTimeSpan(3);
                TimeSpan ketthuc = reader.GetTimeSpan(4);

                EventDTO evt = new EventDTO();
                evt.Ngay = ngay;
                evt.Ten = ten;
                evt.GhiChu = ghichu;
                evt.BatDau = batdau;
                evt.KetThuc = ketthuc;
                ds.Add(evt);
            }
            reader.Close();
            return ds;
        }

        public bool Them(EventDTO evt)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblEvent VALUES (@ngay, @ten, @ghichu, @batdau, @ketthuc)";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = evt.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = evt.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = evt.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            SqlParameter parBD = new SqlParameter("@batdau", SqlDbType.Time);
            parBD.Value = evt.BatDau;
            sqlCmd.Parameters.Add(parBD);

            SqlParameter parKT = new SqlParameter("@ketthuc", SqlDbType.Time);
            parKT.Value = evt.KetThuc;
            sqlCmd.Parameters.Add(parKT);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(EventDTO evt)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblEvent WHERE Ngay = @ngay AND Ten = @ten";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = evt.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = evt.Ten;
            sqlCmd.Parameters.Add(parTen);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(EventDTO evt, DateTime ngayTruyen, string tenTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblEvent SET Ngay = @ngay, Ten = @ten, GhiChu = @ghichu, BatDau = @batdau, KetThuc = @ketthuc WHERE Ngay = @ngayTruyen AND Ten = @tenTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            SqlParameter parTenTruyen = new SqlParameter("@tenTruyen", SqlDbType.NVarChar);
            parTenTruyen.Value = tenTruyen;
            sqlCmd.Parameters.Add(parTenTruyen);

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = evt.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = evt.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = evt.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            SqlParameter parBD = new SqlParameter("@batdau", SqlDbType.Time);
            parBD.Value = evt.BatDau;
            sqlCmd.Parameters.Add(parBD);

            SqlParameter parKT = new SqlParameter("@ketthuc", SqlDbType.Time);
            parKT.Value = evt.KetThuc;
            sqlCmd.Parameters.Add(parKT);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }
    }
}