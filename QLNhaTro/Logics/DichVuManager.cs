using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.Logics
{
    internal class DichVuManager
    {
        public static List<Dichvu> GetAllDichVu()
        {
            using (var context = new DBNhaTroContext())
            {

                List<Dichvu> dichvuList = context.Dichvus.ToList();
                return dichvuList;
            }

        }
    }
}
