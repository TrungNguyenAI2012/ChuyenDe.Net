using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EventDTO
    {
        public DateTime Ngay { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
        public TimeSpan BatDau { get; set; }
        public TimeSpan KetThuc { get; set; }
    }
}
