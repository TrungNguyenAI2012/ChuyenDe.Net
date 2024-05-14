using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HealthBUS
    {
        HealthDAO hthDAL = new HealthDAO();

        public List<HealthDTO> HienThi()
        {
            return hthDAL.HienThi();
        }

        public bool Them(HealthDTO hth)
        {
            return hthDAL.Them(hth);
        }

        public bool Xoa(HealthDTO hth)
        {
            return hthDAL.Xoa(hth);
        }

        public bool Sua(HealthDTO hth, DateTime Ngay, string Ten, string TrieuChung, bool UongThuoc, int SoLieu, int DaUong)
        {
            return hthDAL.Sua(hth, Ngay, Ten, TrieuChung, UongThuoc, SoLieu, DaUong);
        }

        public HealthDTO HienThi(DateTime Ngay)
        {
            return hthDAL.HienThi(Ngay);
        }

        public bool Them(HealthDTO hth, DateTime Ngay)
        {
            return hthDAL.Them(hth, Ngay);
        }

        public bool Sua(HealthDTO hth, DateTime Ngay)
        {
            return hthDAL.Sua(hth, Ngay);
        }
    }
}
