namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            ChuyenXes = new HashSet<ChuyenXe>();
            DanhGias = new HashSet<DanhGia>();
            Ghes = new HashSet<Ghe>();
        }

        [Key]
        [StringLength(50)]
        public string maxe { get; set; }

        [Required]
        [StringLength(50)]
        public string biensoxe { get; set; }

        public int? soghe { get; set; }

        public int? socot { get; set; }

        public int? sohang { get; set; }

        [Column(TypeName = "ntext")]
        public string ghichu { get; set; }

        public int trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGia> DanhGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ghe> Ghes { get; set; }
    }
}
