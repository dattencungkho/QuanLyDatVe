namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [StringLength(50)]
        public string tentaikhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string maquyen { get; set; }

        [Required]
        [StringLength(50)]
        public string matkhau { get; set; }

        [StringLength(100)]
        public string hoten { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? solandangnhapsai { get; set; }

        public int? trangthai { get; set; }

        [StringLength(200)]
        public string linklaylaitaikhoan { get; set; }

        public DateTime? thoigianyeucaulaylaitk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }

        public virtual Quyen Quyen { get; set; }
    }
}
