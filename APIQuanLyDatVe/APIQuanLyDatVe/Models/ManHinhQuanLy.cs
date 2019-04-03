namespace APIQuanLyDatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManHinhQuanLy")]
    public partial class ManHinhQuanLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ManHinhQuanLy()
        {
            QuyenManHinhQuanLies = new HashSet<QuyenManHinhQuanLy>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manhinhquanlyId { get; set; }

        [StringLength(50)]
        public string tenmanhinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuyenManHinhQuanLy> QuyenManHinhQuanLies { get; set; }
    }
}
