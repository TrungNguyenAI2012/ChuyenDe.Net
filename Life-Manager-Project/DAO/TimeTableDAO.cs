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
    public class TimeTableDAO : Database
    {
        public List<TimeTableDTO> HienThi()
        {
            List<TimeTableDTO> ds = new List<TimeTableDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblTimeTable";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                TimeSpan ngay = reader.GetTimeSpan(0);
                string thu2 = reader.GetString(1);
                string thu3 = reader.GetString(2);
                string thu4 = reader.GetString(3);
                string thu5 = reader.GetString(4);
                string thu6 = reader.GetString(5);
                string thu7 = reader.GetString(6);
                string chunhat = reader.GetString(7);

                TimeTableDTO ttbe = new TimeTableDTO();
                ttbe.ThoiGian = ngay;
                ttbe.Thu2 = thu2;
                ttbe.Thu3 = thu3;
                ttbe.Thu4 = thu4;
                ttbe.Thu5 = thu5;
                ttbe.Thu6 = thu6;
                ttbe.Thu7 = thu7;
                ttbe.ChuNhat = chunhat;
                ds.Add(ttbe);
            }
            reader.Close();
            return ds;
        }

        public bool Them(TimeTableDTO ttbe)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblTimeTable VALUES (@thoigian, @thu2, @thu3, @thu4, @thu5, @thu6, @thu7, @chunhat)";

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = ttbe.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            SqlParameter parT2 = new SqlParameter("@thu2", SqlDbType.NVarChar);
            parT2.Value = ttbe.Thu2;
            sqlCmd.Parameters.Add(parT2);

            SqlParameter parT3 = new SqlParameter("@thu3", SqlDbType.NVarChar);
            parT3.Value = ttbe.Thu3;
            sqlCmd.Parameters.Add(parT3);

            SqlParameter parT4 = new SqlParameter("@thu4", SqlDbType.NVarChar);
            parT4.Value = ttbe.Thu4;
            sqlCmd.Parameters.Add(parT4);

            SqlParameter parT5 = new SqlParameter("@thu5", SqlDbType.NVarChar);
            parT5.Value = ttbe.Thu5;
            sqlCmd.Parameters.Add(parT5);

            SqlParameter parT6 = new SqlParameter("@thu6", SqlDbType.NVarChar);
            parT6.Value = ttbe.Thu6;
            sqlCmd.Parameters.Add(parT6);

            SqlParameter parT7 = new SqlParameter("@thu7", SqlDbType.NVarChar);
            parT7.Value = ttbe.Thu7;
            sqlCmd.Parameters.Add(parT7);

            SqlParameter parCN = new SqlParameter("@chunhat", SqlDbType.NVarChar);
            parCN.Value = ttbe.ChuNhat;
            sqlCmd.Parameters.Add(parCN);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(TimeTableDTO ttbe)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblTimeTable WHERE ThoiGian = @thoigian";

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = ttbe.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(TimeTableDTO ttbe, TimeSpan thoiGianTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblTimeTable SET ThoiGian = @thoigian, Thu2 = @thu2, Thu3 = @thu3, Thu4 = @thu4, Thu5 = @thu5, Thu6 = @thu6, Thu7 = @thu7, ChuNhat = @chunhat WHERE ThoiGian = @thoiGianTruyen";

            SqlParameter parTGTruyen = new SqlParameter("@thoiGianTruyen", SqlDbType.Time);
            parTGTruyen.Value = thoiGianTruyen;
            sqlCmd.Parameters.Add(parTGTruyen);

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = ttbe.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            SqlParameter parT2 = new SqlParameter("@thu2", SqlDbType.NVarChar);
            parT2.Value = ttbe.Thu2;
            sqlCmd.Parameters.Add(parT2);

            SqlParameter parT3 = new SqlParameter("@thu3", SqlDbType.NVarChar);
            parT3.Value = ttbe.Thu3;
            sqlCmd.Parameters.Add(parT3);

            SqlParameter parT4 = new SqlParameter("@thu4", SqlDbType.NVarChar);
            parT4.Value = ttbe.Thu4;
            sqlCmd.Parameters.Add(parT4);

            SqlParameter parT5 = new SqlParameter("@thu5", SqlDbType.NVarChar);
            parT5.Value = ttbe.Thu5;
            sqlCmd.Parameters.Add(parT5);

            SqlParameter parT6 = new SqlParameter("@thu6", SqlDbType.NVarChar);
            parT6.Value = ttbe.Thu6;
            sqlCmd.Parameters.Add(parT6);

            SqlParameter parT7 = new SqlParameter("@thu7", SqlDbType.NVarChar);
            parT7.Value = ttbe.Thu7;
            sqlCmd.Parameters.Add(parT7);

            SqlParameter parCN = new SqlParameter("@chunhat", SqlDbType.NVarChar);
            parCN.Value = ttbe.ChuNhat;
            sqlCmd.Parameters.Add(parCN);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }
    }
}
