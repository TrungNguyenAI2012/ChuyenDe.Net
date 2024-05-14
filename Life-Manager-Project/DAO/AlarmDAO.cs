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
    public class AlarmDAO : Database
    {
        public List<AlarmDTO> HienThi()
        {
            List<AlarmDTO> ds = new List<AlarmDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblAlarm";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                TimeSpan thoigian = reader.GetTimeSpan(0);
                string ten = reader.GetString(1);
                string ghichu = reader.GetString(2);

                AlarmDTO alm = new AlarmDTO();
                alm.ThoiGian = thoigian;
                alm.Ten = ten;
                alm.GhiChu = ghichu;
                ds.Add(alm);
            }
            reader.Close();
            return ds;
        }

        public bool Them(AlarmDTO alm)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblAlarm VALUES (@thoigian, @ten, @ghichu)";

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = alm.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = alm.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = alm.GhiChu;
            sqlCmd.Parameters.Add(parGC);
            
            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(AlarmDTO alm)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblAlarm WHERE ThoiGian = @thoigian";

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = alm.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(AlarmDTO alm, TimeSpan thoiGianTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblAlarm SET ThoiGian = @thoigian, Ten = @ten, GhiChu = @ghichu WHERE ThoiGian = @thoiGianTruyen";

            SqlParameter parTGTruyen = new SqlParameter("@thoiGianTruyen", SqlDbType.Time);
            parTGTruyen.Value = thoiGianTruyen;
            sqlCmd.Parameters.Add(parTGTruyen);

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = alm.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = alm.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = alm.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }
    }
}
