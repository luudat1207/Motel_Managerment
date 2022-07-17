using System;
using System.Collections.Generic;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class Tinhtrang
    {
        public Tinhtrang()
        {
            Phongtros = new HashSet<Phongtro>();
        }

        public int MaTinhTrang { get; set; }
        public string TinhTrang1 { get; set; }

        public virtual ICollection<Phongtro> Phongtros { get; set; }

        public Tinhtrang(string tinhTrang1)
        {
            TinhTrang1 = tinhTrang1;
        }
    }
}
