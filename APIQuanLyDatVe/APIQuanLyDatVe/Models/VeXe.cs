namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeXe")]
    public partial class VeXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VeXe()
        {
            ChiTietVeXes = new HashSet<ChiTietVeXe>();
        }

        [StringLength(50)]
        public string vexeId { get; set; }

        [Required]
        [StringLength(50)]
        public string machuyenxe { get; set; }

        [Required]
        [StringLength(50)]
        public string khachhangId { get; set; }

        public int? matrangthaive { get; set; }

        [StringLength(10)]
        public string tongtien { get; set; }

        public int? sokhach { get; set; }

        [Column(TypeName = "ntext")]
        public string ghichu { get; set; }

        [StringLength(50)]
        public string madiemtrungchuyendon { get; set; }

        [StringLength(50)]
        public string madiemtrungchuyentra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietVeXe> ChiTietVeXes { get; set; }

        public virtual ChuyenXe ChuyenXe { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual TrangThaiVeXe TrangThaiVeXe { get; set; }
    }
}
