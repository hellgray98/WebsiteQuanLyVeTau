//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLVT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangVe()
        {
            this.ToaTaus = new HashSet<ToaTau>();
            this.VeTaus = new HashSet<VeTau>();
        }
    
        public int MaHangVe { get; set; }
        public string TenHangVeset { get; set; }
        public Nullable<int> MaKhoangNam { get; set; }
    
        public virtual KhoangNam KhoangNam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToaTau> ToaTaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeTau> VeTaus { get; set; }
    }
}
