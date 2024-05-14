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
    public class NoteDAO : Database
    {
        public List<NoteDTO> HienThi()
        {
            List<NoteDTO> ds = new List<NoteDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblNote";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ten = reader.GetString(0);
                string ghichu = reader.GetString(1);

                NoteDTO nte = new NoteDTO();
                nte.Ten = ten;
                nte.GhiChu = ghichu;
                ds.Add(nte);
            }
            reader.Close();
            return ds;
        }

        public NoteDTO HienThi(string tenTruyen)
        {
            NoteDTO ds = new NoteDTO();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblNote WHERE Ten = @tenTruyen";

            SqlParameter parTenTruyen = new SqlParameter("@tenTruyen", SqlDbType.NVarChar);
            parTenTruyen.Value = tenTruyen;
            sqlCmd.Parameters.Add(parTenTruyen);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ten = reader.GetString(0);
                string ghichu = reader.GetString(1);

                NoteDTO nte = new NoteDTO();
                nte.Ten = ten;
                nte.GhiChu = ghichu;
                ds = nte;
            }
            reader.Close();
            return ds;
        }

        public bool Them(NoteDTO nte)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblNote VALUES (@ten, @ghichu)";

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = nte.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = nte.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(NoteDTO nte)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblNote WHERE Ten = @ten";

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = nte.Ten;
            sqlCmd.Parameters.Add(parTen);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(NoteDTO nte, string tenTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblNote SET GhiChu = @ghichu WHERE Ten = @tenTruyen";

            SqlParameter parTenTruyen = new SqlParameter("@tenTruyen", SqlDbType.NVarChar);
            parTenTruyen.Value = tenTruyen;
            sqlCmd.Parameters.Add(parTenTruyen);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = nte.GhiChu;
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
