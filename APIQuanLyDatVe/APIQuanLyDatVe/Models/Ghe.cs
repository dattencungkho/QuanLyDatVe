namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ghe")]
    public partial class Ghe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ghe()
        {
            TrangThaiGhes = new HashSet<TrangThaiGhe>();
        }

        [Key]
        [StringLength(50)]
        public string maghe { get; set; }

        public int? tang { get; set; }

        [Required]
        [StringLength(50)]
        public string maxe { get; set; }

        public int vitriX { get; set; }

        public int vitriY { get; set; }

        public bool? active { get; set; }

        public virtual Xe Xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrangThaiGhe> TrangThaiGhes { get; set; }
    }
}
