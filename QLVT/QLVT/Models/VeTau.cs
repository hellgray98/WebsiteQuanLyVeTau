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
    
    public partial class VeTau
    {
        public int MaVeTau { get; set; }
        public Nullable<int> MaLichTau { get; set; }
        public Nullable<int> MaKhachHang { get; set; }
        public Nullable<int> MaHangVe { get; set; }
        public Nullable<int> MaToa { get; set; }
        public Nullable<int> MaViTri { get; set; }
        public string GiaTien { get; set; }
        public int SoLuongKhach { get; set; }
    
        public virtual CT_LichTau_VeTau CT_LichTau_VeTau { get; set; }
        public virtual HangVe HangVe { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual LichTau LichTau { get; set; }
        public virtual ToaTau ToaTau { get; set; }
    }
}
