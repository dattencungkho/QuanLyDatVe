namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            DanhGias = new HashSet<DanhGia>();
            VeXes = new HashSet<VeXe>();
        }

        [StringLength(50)]
        public string khachhangId { get; set; }

        [Required]
        [StringLength(50)]
        public string madoituong { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string sodienthoai { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public double? diemtichluy { get; set; }

        [StringLength(10)]
        public string matkhau { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGia> DanhGias { get; set; }

        public virtual DoiTuong DoiTuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXes { get; set; }
    }
}
