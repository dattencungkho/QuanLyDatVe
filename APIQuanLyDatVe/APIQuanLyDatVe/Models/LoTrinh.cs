namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoTrinh")]
    public partial class LoTrinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoTrinh()
        {
            ChiTietLoTrinhs = new HashSet<ChiTietLoTrinh>();
            ChuyenXes = new HashSet<ChuyenXe>();
        }

        [Key]
        [StringLength(50)]
        public string malotrinh { get; set; }

        [StringLength(10)]
        public string matinhtra { get; set; }

        [StringLength(10)]
        public string matinhdon { get; set; }

        [StringLength(100)]
        public string tenlotrinh { get; set; }

        public double? khoangthoigiandukien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLoTrinh> ChiTietLoTrinhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXes { get; set; }
    }
}
