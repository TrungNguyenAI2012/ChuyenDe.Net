using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class AlarmBUS
    {
        AlarmDAO almDAL = new AlarmDAO();

        public List<AlarmDTO> HienThi()
        {
            return almDAL.HienThi();
        }

        public bool Them(AlarmDTO alm)
        {
            return almDAL.Them(alm);
        }

        public bool Xoa(AlarmDTO alm)
        {
            return almDAL.Xoa(alm);
        }

        public bool Sua(AlarmDTO alm, TimeSpan ThoiGian)
        {
            return almDAL.Sua(alm, ThoiGian);
        }
    }
}
