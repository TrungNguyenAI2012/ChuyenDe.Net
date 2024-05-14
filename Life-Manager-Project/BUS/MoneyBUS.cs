using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class MoneyBUS
    {
        MoneyDAO mnyDAL = new MoneyDAO();

        public List<MoneyDTO> HienThi()
        {
            return mnyDAL.HienThi();
        }

        public List<MoneyDTO> HienThi(DateTime Ngay)
        {
            return mnyDAL.HienThi(Ngay);
        }

        public bool Them(MoneyDTO mny)
        {
            return mnyDAL.Them(mny);
        }

        public bool Xoa(MoneyDTO mny)
        {
            return mnyDAL.Xoa(mny);
        }

        public bool Sua(MoneyDTO mny, DateTime Ngay, TimeSpan ThoiGian, string Ten)
        {
            return mnyDAL.Sua(mny, Ngay, ThoiGian, Ten);
        }
    }
}
