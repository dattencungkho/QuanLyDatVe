//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIQuanLyDatVe.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            this.ChuyenXes = new HashSet<ChuyenXe>();
        }
    
        public string maxe { get; set; }
        public string bienso { get; set; }
        public Nullable<int> soghe { get; set; }
        public string masodoxe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXes { get; set; }
    }
}
