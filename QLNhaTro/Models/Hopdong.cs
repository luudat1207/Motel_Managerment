using System;
using System.Collections.Generic;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class Hopdong
    {
        public string SoHopDong { get; set; }
        public int? Idcn { get; set; }
        public string Cccd { get; set; }
        public string MaPhong { get; set; }
        public double? GiaThue { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DuKienTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public bool? DaKetThuc { get; set; }
    }
}
