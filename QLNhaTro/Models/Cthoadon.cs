using System;
using System.Collections.Generic;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class Cthoadon
    {
        public int Idhd { get; set; }
        public int MaDv { get; set; }
        public double? SoLuong { get; set; }
        public double? GiaTien { get; set; }

        public virtual Hoadon IdhdNavigation { get; set; }
        public virtual Dichvu MaDvNavigation { get; set; }
    }
}
