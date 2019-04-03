namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangGia")]
    public partial class BangGia
    {
        public int banggiaId { get; set; }

        [StringLength(50)]
        public string madiemtrungchuyendon { get; set; }

        [StringLength(50)]
        public string madiemtrungchuyentra { get; set; }

        public double? giave { get; set; }

        public double? thoigiandukien { get; set; }

        public virtual DiemTrungChuyen DiemTrungChuyen { get; set; }

        public virtual DiemTrungChuyen DiemTrungChuyen1 { get; set; }
    }
}
