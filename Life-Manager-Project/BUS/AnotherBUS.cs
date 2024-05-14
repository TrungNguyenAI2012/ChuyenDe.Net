using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class AnotherBUS
    {
        AnotherDAO antrDAL = new AnotherDAO();

        public List<AnotherDTO> HienThi()
        {
            return antrDAL.HienThi();
        }

        //public List<AnotherDTO> SapXep(string Truyen)
        //{
        //    return antrDAL.SapXep(Truyen);
        //}

        public bool Them(AnotherDTO antr)
        {
            return antrDAL.Them(antr);
        }

        public bool Xoa(AnotherDTO antr)
        {
            return antrDAL.Xoa(antr);
        }

        public bool Sua(AnotherDTO antr, string Nhom, string Ten, string Chinh)
        {
            return antrDAL.Sua(antr, Nhom, Ten, Chinh);
        }

        //public List<AnotherDTO> HienThi(string Truyen)
        //{
        //    return antrDAL.HienThi(Truyen);
        //}
    }
}
