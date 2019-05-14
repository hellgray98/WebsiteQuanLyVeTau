using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class VeTau
    {
        [Key]
        public int MaVeTau { get; set; }
        public virtual ICollection<CT_LichTau_VeTau> FKLichvetau { get; set; }
        [ForeignKey("FKLichTau")]
        public int? MaLichTau { get; set; }
        public virtual LichTau FKLichTau { get; set; }
        [ForeignKey("FKKhachHang")]
        public int? MaKhachHang { get; set; }
        public virtual KhachHang FKKhachHang { get; set; }
        [ForeignKey("FKHangVe")]
        public int? MaHangVe { get; set; }
        public virtual HangVe FKHangVe { get; set; }
        [ForeignKey("FKToa")]
        public int? MaToa { get; set; }
        public virtual ToaTau FKToa { get; set; }
        [ForeignKey("FKVitri")]
        public int? MaViTri { get; set; }
        public virtual CT_LichTau_VeTau FKVitri { get; set; }
        public string GiaTien { get; set; }
        public int SoLuongKhach { get; set; }
    }
}