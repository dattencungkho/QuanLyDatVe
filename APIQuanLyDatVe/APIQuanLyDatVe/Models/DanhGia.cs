namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhGia")]
    public partial class DanhGia
    {
        [Key]
        [StringLength(50)]
        public string madanhgia { get; set; }

        [StringLength(50)]
        public string makhachhang { get; set; }

        [StringLength(50)]
        public string maxe { get; set; }

        public int? diemdanhgia { get; set; }

        [Column(TypeName = "ntext")]
        public string noidungdanhgia { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
