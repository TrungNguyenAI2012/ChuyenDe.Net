using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TimeTableBUS
    {
        TimeTableDAO ttbeDAL = new TimeTableDAO();

        public List<TimeTableDTO> HienThi()
        {
            return ttbeDAL.HienThi();
        }

        public bool Them(TimeTableDTO ttbe)
        {
            return ttbeDAL.Them(ttbe);
        }

        public bool Xoa(TimeTableDTO ttbe)
        {
            return ttbeDAL.Xoa(ttbe);
        }

        public bool Sua(TimeTableDTO ttbe, TimeSpan ThoiGian)
        {
            return ttbeDAL.Sua(ttbe, ThoiGian);
        }
    }
}
