using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.Logics
{
    internal class KhachThueManager
    {
        public static List<Khachthue> GetAllKhachThue()
        {
            using (var context = new DBNhaTroContext())
            {

                List<Khachthue> khachthueList = context.Khachthues.OrderBy(x => x.HoTen).ToList();
                return khachthueList;
            }

        }
    }
}
