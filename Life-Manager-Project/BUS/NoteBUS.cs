using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NoteBUS
    {
        NoteDAO nteDAL = new NoteDAO();

        public List<NoteDTO> HienThi()
        {
            return nteDAL.HienThi();
        }

        public NoteDTO HienThi(string tenTruyen)
        {
            return nteDAL.HienThi(tenTruyen);
        }

        public bool Them(NoteDTO nte)
        {
            return nteDAL.Them(nte);
        }

        public bool Xoa(NoteDTO nte)
        {
            return nteDAL.Xoa(nte);
        }

        public bool Sua(NoteDTO nte, string Ten)
        {
            return nteDAL.Sua(nte, Ten);
        }
    }
}
