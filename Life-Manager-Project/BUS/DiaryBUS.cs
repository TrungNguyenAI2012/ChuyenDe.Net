using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DiaryBUS
    {
        DiaryDAO dayDAL = new DiaryDAO();

        public DiaryDTO HienThi(DateTime Ngay)
        {
            return dayDAL.HienThi(Ngay);
        }

        public bool Them(DiaryDTO day, DateTime Ngay)
        {
            return dayDAL.Them(day, Ngay);
        }

        public bool Sua(DiaryDTO day, DateTime Ngay)
        {
            return dayDAL.Sua(day, Ngay);
        }

        public bool Xoa(DiaryDTO day, DateTime Ngay)
        {
            return dayDAL.Xoa(day, Ngay);
        }

        public bool SuaHinh(DiaryDTO day, DateTime Ngay)
        {
            return dayDAL.SuaHinh(day, Ngay);
        }
    }
}
