using System;
using System.Collections.Generic;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class Dichvu
    {
        public Dichvu()
        {
            Cthoadons = new HashSet<Cthoadon>();
        }

        public int MaDv { get; set; }
        public string TenDv { get; set; }
        public double? SoTien { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Cthoadon> Cthoadons { get; set; }
    }
}
