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
    
    public partial class DiemTrungChuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiemTrungChuyen()
        {
            this.DiemDons = new HashSet<DiemDon>();
            this.DiemXuongs = new HashSet<DiemXuong>();
        }
    
        public string madiemtrungchuyen { get; set; }
        public string tendiemtrungchuyen { get; set; }
        public Nullable<int> giave { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemDon> DiemDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemXuong> DiemXuongs { get; set; }
    }
}
