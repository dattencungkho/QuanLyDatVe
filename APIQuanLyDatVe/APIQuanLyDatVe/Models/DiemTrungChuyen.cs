namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemTrungChuyen")]
    public partial class DiemTrungChuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiemTrungChuyen()
        {
            BangGias = new HashSet<BangGia>();
            BangGias1 = new HashSet<BangGia>();
        }

        [Key]
        [StringLength(50)]
        public string madiemtrungchuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string matinh { get; set; }

        [StringLength(100)]
        public string tendiemtrungchuyen { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangGia> BangGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangGia> BangGias1 { get; set; }

        public virtual TinhThanh TinhThanh { get; set; }
    }
}
