using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class EventBUS
    {
        EventDAO evtDAL = new EventDAO();

        public List<EventDTO> HienThi()
        {
            return evtDAL.HienThi();
        }

        public List<EventDTO> HienThi(DateTime Ngay)
        {
            return evtDAL.HienThi(Ngay);
        }

        public bool Them(EventDTO evt)
        {
            return evtDAL.Them(evt);
        }
        
        public bool Xoa(EventDTO evt)
        {
            return evtDAL.Xoa(evt);
        }
        
        public bool Sua(EventDTO evt, DateTime Ngay, string Ten)
        {
            return evtDAL.Sua(evt, Ngay, Ten);
        }
    }
}
