namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrangThaiGhe")]
    public partial class TrangThaiGhe
    {
        public int trangthaigheId { get; set; }

        [Required]
        [StringLength(50)]
        public string maghe { get; set; }

        public DateTime? ngay { get; set; }

        public int? trangthai { get; set; }

        public virtual Ghe Ghe { get; set; }
    }
}
