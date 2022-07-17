using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.Logics
{
    internal class ThanhToanHoaDonManager
    {
        public static List<Thanhtoan> GetAllThanhToan()
        {
            using (var context = new DBNhaTroContext())
            {
                List<Thanhtoan> thanhtoanList = context.Thanhtoans.ToList();
                return thanhtoanList;
            }

        }
    }
}
