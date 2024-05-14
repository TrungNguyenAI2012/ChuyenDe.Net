using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HealthDTO
    {
        public DateTime Ngay { get; set; }
        public string Ten { get; set; }
        public string TrieuChung { get; set; }
        public bool UongThuoc { get; set; }
        public int SoLieu { get; set; }
        public int DaUong { get; set; }
        public int CanNang { get; set; }
        public int ChieuCao { get; set; }
        public string CamGiac { get; set; }
    }
}
