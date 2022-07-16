using QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.Logics
{
    public class ChuNhaManager
    {
        
        public static List<Chunha> GetAllChuNha()
        {
            using (var context = new DBNhaTroContext())
            {

                List<Chunha> chunhaList = context.Chunhas.ToList();
                return chunhaList;
            }
            
        }
    }
}
