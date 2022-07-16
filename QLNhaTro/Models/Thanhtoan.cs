using System;
using System.Collections.Generic;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class Thanhtoan
    {
        public Thanhtoan()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public int Idtt { get; set; }
        public string LoaiThanhToan { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
