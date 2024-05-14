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
    public class HealthDAO : Database
    {
        public List<HealthDTO> HienThi()
        {
            List<HealthDTO> ds = new List<HealthDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblHealth";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                string ten = reader.GetString(1);
                string trieuchung = reader.GetString(2);
                bool uongthuoc = reader.GetBoolean(3);
                int solieu = reader.GetInt32(4);
                int dauong = reader.GetInt32(5);

                HealthDTO hth = new HealthDTO();
                hth.Ngay = ngay;
                hth.Ten = ten;
                hth.TrieuChung = trieuchung;
                hth.UongThuoc = uongthuoc;
                hth.SoLieu = solieu;
                hth.DaUong = dauong;
                ds.Add(hth);
            }
            reader.Close();
            return ds;
        }

        public bool Them(HealthDTO hth)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblHealth VALUES (@ngay, @ten, @trieuchung, @uongthuoc, @solieu, @dauong)";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = hth.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = hth.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parTT = new SqlParameter("@trieuchung", SqlDbType.NVarChar);
            parTT.Value = hth.TrieuChung;
            sqlCmd.Parameters.Add(parTT);

            SqlParameter parUT = new SqlParameter("@uongthuoc", SqlDbType.Bit);
            parUT.Value = hth.UongThuoc;
            sqlCmd.Parameters.Add(parUT);

            SqlParameter parSL = new SqlParameter("@solieu", SqlDbType.Int);
            parSL.Value = hth.SoLieu;
            sqlCmd.Parameters.Add(parSL);

            SqlParameter parDU = new SqlParameter("@dauong", SqlDbType.Int);
            parDU.Value = hth.DaUong;
            sqlCmd.Parameters.Add(parDU);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(HealthDTO hth)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblHealth WHERE Ngay = @ngay AND Ten = @ten AND TrieuChung = @trieuchung AND UongThuoc = @uongthuoc AND SoLieu = @solieu AND DaUong = @dauong";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = hth.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = hth.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parTT = new SqlParameter("@trieuchung", SqlDbType.NVarChar);
            parTT.Value = hth.TrieuChung;
            sqlCmd.Parameters.Add(parTT);

            SqlParameter parUT = new SqlParameter("@uongthuoc", SqlDbType.Bit);
            parUT.Value = hth.UongThuoc;
            sqlCmd.Parameters.Add(parUT);

            SqlParameter parSL = new SqlParameter("@solieu", SqlDbType.Int);
            parSL.Value = hth.SoLieu;
            sqlCmd.Parameters.Add(parSL);

            SqlParameter parDU = new SqlParameter("@dauong", SqlDbType.Int);
            parDU.Value = hth.DaUong;
            sqlCmd.Parameters.Add(parDU);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(HealthDTO hth, DateTime ngayTruyen, string tenTruyen, string trieuChungTruyen, bool uongThuocTruyen, int soLieuTruyen, int daUongTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblHealth SET Ngay = @ngay, Ten = @ten, TrieuChung = @trieuchung, UongThuoc = @uongthuoc, SoLieu = @solieu, DaUong = @dauong WHERE Ngay = @ngayTruyen AND Ten = @tenTruyen AND TrieuChung = @trieuChungTruyen AND UongThuoc = @uongThuocTruyen AND SoLieu = @soLieuTruyen AND DaUong = @daUongTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            SqlParameter parTenTruyen = new SqlParameter("@tenTruyen", SqlDbType.NVarChar);
            parTenTruyen.Value = tenTruyen;
            sqlCmd.Parameters.Add(parTenTruyen);

            SqlParameter parChieuTrungTruyen = new SqlParameter("@trieuChungTruyen", SqlDbType.NVarChar);
            parChieuTrungTruyen.Value = trieuChungTruyen;
            sqlCmd.Parameters.Add(parChieuTrungTruyen);

            SqlParameter parUongThuocTruyen = new SqlParameter("@uongThuocTruyen", SqlDbType.Bit);
            parUongThuocTruyen.Value = uongThuocTruyen;
            sqlCmd.Parameters.Add(parUongThuocTruyen);

            SqlParameter parSoLieuTruyen = new SqlParameter("@soLieuTruyen", SqlDbType.Int);
            parSoLieuTruyen.Value = soLieuTruyen;
            sqlCmd.Parameters.Add(parSoLieuTruyen);

            SqlParameter parDaUuongTruyen = new SqlParameter("@daUongTruyen", SqlDbType.Int);
            parDaUuongTruyen.Value = daUongTruyen;
            sqlCmd.Parameters.Add(parDaUuongTruyen);

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = hth.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = hth.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parTC = new SqlParameter("@trieuchung", SqlDbType.NVarChar);
            parTC.Value = hth.TrieuChung;
            sqlCmd.Parameters.Add(parTC);

            SqlParameter parUT = new SqlParameter("@uongthuoc", SqlDbType.Bit);
            parUT.Value = hth.UongThuoc;
            sqlCmd.Parameters.Add(parUT);

            SqlParameter parSL = new SqlParameter("@solieu", SqlDbType.Int);
            parSL.Value = hth.SoLieu;
            sqlCmd.Parameters.Add(parSL);

            SqlParameter parDU = new SqlParameter("@dauong", SqlDbType.Int);
            parDU.Value = hth.DaUong;
            sqlCmd.Parameters.Add(parDU);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        // Quản lý vóc dáng
        public HealthDTO HienThi(DateTime ngayTruyen)
        {
            HealthDTO ds = new HealthDTO();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblHealthDay WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                int cannang = reader.GetInt32(1);
                int chieucao = reader.GetInt32(2);
                string camgiac = reader.GetString(3);

                HealthDTO hth = new HealthDTO();
                hth.Ngay = ngay;
                hth.CanNang = cannang;
                hth.ChieuCao = chieucao;
                hth.CamGiac = camgiac;
                ds = hth;
            }
            reader.Close();
            return ds;
        }

        public bool Them(HealthDTO hth, DateTime ngayTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblHealthDay VALUES (@ngay, @cannang, @chieucao, @camgiac)";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = hth.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parCN = new SqlParameter("@cannang", SqlDbType.Int);
            parCN.Value = hth.CanNang;
            sqlCmd.Parameters.Add(parCN);

            SqlParameter parCC = new SqlParameter("@chieucao", SqlDbType.Int);
            parCC.Value = hth.ChieuCao;
            sqlCmd.Parameters.Add(parCC);

            SqlParameter parCG = new SqlParameter("@camgiac", SqlDbType.NText);
            parCG.Value = hth.CamGiac;
            sqlCmd.Parameters.Add(parCG);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(HealthDTO hth, DateTime ngayTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblHealthDay SET Ngay = @ngay, CanNang = @cannang, ChieuCao = @chieucao, CamGiac = @camgiac WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = hth.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parCN = new SqlParameter("@cannang", SqlDbType.Int);
            parCN.Value = hth.CanNang;
            sqlCmd.Parameters.Add(parCN);

            SqlParameter parCC = new SqlParameter("@chieucao", SqlDbType.Int);
            parCC.Value = hth.ChieuCao;
            sqlCmd.Parameters.Add(parCC);

            SqlParameter parCG = new SqlParameter("@camgiac", SqlDbType.NText);
            parCG.Value = hth.CamGiac;
            sqlCmd.Parameters.Add(parCG);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }
    }
}
