namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            ChiTietLaiXes = new HashSet<ChiTietLaiXe>();
            ChuyenXes = new HashSet<ChuyenXe>();
            ChuyenXes1 = new HashSet<ChuyenXe>();
        }

        [Key]
        [StringLength(50)]
        public string manhanvien { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [Required]
        [StringLength(50)]
        public string machucvu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string sodienthoai { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string socmt { get; set; }

        [StringLength(10)]
        public string ngaycap { get; set; }

        [StringLength(50)]
        public string tentaikhoan { get; set; }

        [StringLength(200)]
        public string noicap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLaiXe> ChiTietLaiXes { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXes1 { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
