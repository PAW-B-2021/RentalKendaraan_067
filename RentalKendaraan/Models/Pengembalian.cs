﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public virtual Peminjaman IdKondisi1 { get; set; }
        public virtual KondisiKendaraan IdKondisiNavigation { get; set; }
    }
}
