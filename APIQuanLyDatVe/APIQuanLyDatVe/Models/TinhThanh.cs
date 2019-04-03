namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhThanh")]
    public partial class TinhThanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhThanh()
        {
            ChiTietLoTrinhs = new HashSet<ChiTietLoTrinh>();
            DiemTrungChuyens = new HashSet<DiemTrungChuyen>();
        }

        [Key]
        [StringLength(50)]
        public string matinh { get; set; }

        [StringLength(100)]
        public string tentinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLoTrinh> ChiTietLoTrinhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemTrungChuyen> DiemTrungChuyens { get; set; }
    }
}
