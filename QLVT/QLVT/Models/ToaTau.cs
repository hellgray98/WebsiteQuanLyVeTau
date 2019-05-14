using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class ToaTau
    {
        [Key]
        public int MaToaTau { get; set; }
        public virtual ICollection<ToaTau> FKtoatau { get; set; }
        public virtual ICollection<QuanLyGheTau> MaToaGhe { get; set; }
        public int TenToaTau { get; set; }
        [ForeignKey("FKMatau1")]
        public int? MaTau { get; set; }
        public virtual DSTau FKMatau1 { get; set; }
        [ForeignKey("FKHangVe")]
        public int? MaHV { get; set; }
        public virtual HangVe FKHangVe { get; set; }
        public int SoGhe { get; set; }
        
    }
}