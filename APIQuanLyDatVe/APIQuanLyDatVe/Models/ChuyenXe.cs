namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenXe")]
    public partial class ChuyenXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenXe()
        {
            VeXes = new HashSet<VeXe>();
        }

        [Key]
        [StringLength(50)]
        public string machuyenxe { get; set; }

        [Required]
        [StringLength(50)]
        public string malotrinh { get; set; }

        [Required]
        [StringLength(50)]
        public string makip { get; set; }

        [Required]
        [StringLength(50)]
        public string maxe { get; set; }

        [Required]
        [StringLength(50)]
        public string mataixe { get; set; }

        [Required]
        [StringLength(50)]
        public string maphuxe { get; set; }

        public DateTime? ngayhoatdong { get; set; }

        public DateTime? thoigiandungxe { get; set; }

        public virtual Kip Kip { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }

        public virtual Xe Xe { get; set; }

        public virtual LoTrinh LoTrinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXes { get; set; }
    }
}
