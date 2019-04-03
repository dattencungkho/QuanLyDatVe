namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyenManHinhQuanLy")]
    public partial class QuyenManHinhQuanLy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quyenmanhinhquanlyId { get; set; }

        public int manhinhquanlyId { get; set; }

        [Required]
        [StringLength(50)]
        public string maquyen { get; set; }

        public bool quyenxem { get; set; }

        public bool quyenthem { get; set; }

        public bool quyensua { get; set; }

        public bool quyenxoa { get; set; }

        public virtual ManHinhQuanLy ManHinhQuanLy { get; set; }

        public virtual Quyen Quyen { get; set; }
    }
}
