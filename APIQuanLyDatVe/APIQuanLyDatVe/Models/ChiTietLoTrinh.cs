namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietLoTrinh")]
    public partial class ChiTietLoTrinh
    {
        [Key]
        [StringLength(50)]
        public string machitietlotrinh { get; set; }

        [StringLength(50)]
        public string malotrinh { get; set; }

        [StringLength(50)]
        public string idtinhthanh { get; set; }

        public virtual LoTrinh LoTrinh { get; set; }

        public virtual TinhThanh TinhThanh { get; set; }
    }
}
