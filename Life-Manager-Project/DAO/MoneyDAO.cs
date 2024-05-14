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
    public class MoneyDAO : Database
    {
        public List<MoneyDTO> HienThi()
        {
            List<MoneyDTO> ds = new List<MoneyDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblMoney";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                TimeSpan thoigian = reader.GetTimeSpan(1);
                string ten = reader.GetString(2);
                string thuchi = reader.GetString(3);
                string giatien = reader.GetString(4);
                string nhom = reader.GetString(5);
                string vi = reader.GetString(6);
                string voi = reader.GetString(7);
                string ghichu = reader.GetString(8);

                MoneyDTO mny = new MoneyDTO();
                mny.Ngay = ngay;
                mny.ThoiGian = thoigian;
                mny.Ten = ten;
                mny.ThuChi = thuchi;
                mny.GiaTien = giatien;
                mny.Nhom = nhom;
                mny.Vi = vi;
                mny.Voi = voi;
                mny.GhiChu = ghichu;
                ds.Add(mny);
            }
            reader.Close();
            return ds;
        }

        public List<MoneyDTO> HienThi(DateTime ngayTruyen)
        {
            List<MoneyDTO> ds = new List<MoneyDTO>();
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblMoney WHERE Ngay = @ngayTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime(0);
                TimeSpan thoigian = reader.GetTimeSpan(1);
                string ten = reader.GetString(2);
                string thuchi = reader.GetString(3);
                string giatien = reader.GetString(4);
                string nhom = reader.GetString(5);
                string vi = reader.GetString(6);
                string voi = reader.GetString(7);
                string ghichu = reader.GetString(8);

                MoneyDTO mny = new MoneyDTO();
                mny.Ngay = ngay;
                mny.ThoiGian = thoigian;
                mny.Ten = ten;
                mny.ThuChi = thuchi;
                mny.GiaTien = giatien;
                mny.Nhom = nhom;
                mny.Vi = vi;
                mny.Voi = voi;
                mny.GhiChu = ghichu;
                ds.Add(mny);
            }
            reader.Close();
            return ds;
        }

        public bool Them(MoneyDTO mny)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO tblMoney VALUES (@ngay, @thoigian, @ten, @thuchi, @giatien, @nhom, @vi, @voi, @ghichu)";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = mny.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = mny.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = mny.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parTC = new SqlParameter("@thuchi", SqlDbType.Char);
            parTC.Value = mny.ThuChi;
            sqlCmd.Parameters.Add(parTC);

            SqlParameter parGT = new SqlParameter("@giatien", SqlDbType.VarChar);
            parGT.Value = mny.GiaTien;
            sqlCmd.Parameters.Add(parGT);

            SqlParameter parNhom = new SqlParameter("@nhom", SqlDbType.NVarChar);
            parNhom.Value = mny.Nhom;
            sqlCmd.Parameters.Add(parNhom);

            SqlParameter parVi = new SqlParameter("@vi", SqlDbType.NVarChar);
            parVi.Value = mny.Vi;
            sqlCmd.Parameters.Add(parVi);

            SqlParameter parVoi = new SqlParameter("@voi", SqlDbType.NVarChar);
            parVoi.Value = mny.Voi;
            sqlCmd.Parameters.Add(parVoi);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = mny.GhiChu;
            sqlCmd.Parameters.Add(parGC);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Xoa(MoneyDTO mny)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM tblMoney WHERE Ngay = @ngay AND ThoiGian = @thoigian AND Ten = @ten";

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = mny.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parThoiGian = new SqlParameter("@thoigian", SqlDbType.Time);
            parThoiGian.Value = mny.ThoiGian;
            sqlCmd.Parameters.Add(parThoiGian);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = mny.Ten;
            sqlCmd.Parameters.Add(parTen);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
                return true;
            else
                return false;
        }

        public bool Sua(MoneyDTO mny, DateTime ngayTruyen, TimeSpan thoiGianTruyen, string tenTruyen)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE tblMoney SET Ngay = @ngay, ThoiGian = @thoigian, Ten = @ten, ThuChi = @thuchi, GiaTien = @giatien, Nhom = @nhom, Vi = @vi, Voi = @voi, GhiChu = @ghichu WHERE Ngay = @ngayTruyen AND ThoiGian = @thoiGianTruyen AND Ten = @tenTruyen";

            SqlParameter parNgayTruyen = new SqlParameter("@ngayTruyen", SqlDbType.Date);
            parNgayTruyen.Value = ngayTruyen;
            sqlCmd.Parameters.Add(parNgayTruyen);

            SqlParameter parThoiGianTruyen = new SqlParameter("@thoiGianTruyen", SqlDbType.Time);
            parThoiGianTruyen.Value = thoiGianTruyen;
            sqlCmd.Parameters.Add(parThoiGianTruyen);

            SqlParameter parTenTruyen = new SqlParameter("@tenTruyen", SqlDbType.NVarChar);
            parTenTruyen.Value = tenTruyen;
            sqlCmd.Parameters.Add(parTenTruyen);

            SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
            parNgay.Value = mny.Ngay;
            sqlCmd.Parameters.Add(parNgay);

            SqlParameter parTG = new SqlParameter("@thoigian", SqlDbType.Time);
            parTG.Value = mny.ThoiGian;
            sqlCmd.Parameters.Add(parTG);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = mny.Ten;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parTC = new SqlParameter("@thuchi", SqlDbType.Char);
            parTC.Value = mny.ThuChi;
            sqlCmd.Parameters.Add(parTC);

            SqlParameter parGT = new SqlParameter("@giatien", SqlDbType.VarChar);
            parGT.Value = mny.GiaTien;
            sqlCmd.Parameters.Add(parGT);

            SqlParameter parNhom = new SqlParameter("@nhom", SqlDbType.NVarChar);
            parNhom.Value = mny.Nhom;
            sqlCmd.Parameters.Add(parNhom);

            SqlParameter parVi = new SqlParameter("@vi", SqlDbType.NVarChar);
            parVi.Value = mny.Vi;
            sqlCmd.Parameters.Add(parVi);

            SqlParameter parVoi = new SqlParameter("@voi", SqlDbType.NVarChar);
            parVoi.Value = mny.Voi;
            sqlCmd.Parameters.Add(parVoi);

            SqlParameter parGC = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            parGC.Value = mny.GhiChu;
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
