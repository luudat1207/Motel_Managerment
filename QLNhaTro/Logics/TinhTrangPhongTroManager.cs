using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.Logics
{
    internal class TinhTrangPhongTroManager
    {
        public static List<Tinhtrang> GetAllTinhTrang()
        {
            using (var context = new DBNhaTroContext())
            {

                List<Tinhtrang> tinhtrangList = context.Tinhtrangs.ToList();
                return tinhtrangList;
            }

        }
    }
}
