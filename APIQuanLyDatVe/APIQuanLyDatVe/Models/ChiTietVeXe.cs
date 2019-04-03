namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietVeXe")]
    public partial class ChiTietVeXe
    {
        [StringLength(50)]
        public string chitietvexeId { get; set; }

        [Required]
        [StringLength(50)]
        public string vexeId { get; set; }

        [Required]
        [StringLength(50)]
        public string maghe { get; set; }

        public virtual VeXe VeXe { get; set; }
    }
}
