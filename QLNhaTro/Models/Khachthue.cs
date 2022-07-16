﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QLNhaTro.Models
{
    public partial class Khachthue
    {
        public Khachthue()
        {
            Hopdongs = new HashSet<Hopdong>();
        }

        public string Cccd { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }
        public string ThongTinKhac { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Hopdong> Hopdongs { get; set; }
    }
}
