namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietLaiXe")]
    public partial class ChiTietLaiXe
    {
        public int chitietlaixeId { get; set; }

        [Required]
        [StringLength(50)]
        public string manhanvien { get; set; }

        [Required]
        [StringLength(50)]
        public string giaypheplaixe { get; set; }

        [StringLength(10)]
        public string hanglai { get; set; }

        [StringLength(10)]
        public string ngaycap { get; set; }

        [StringLength(200)]
        public string noicap { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
