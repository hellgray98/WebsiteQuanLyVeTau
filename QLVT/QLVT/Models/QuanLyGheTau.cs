using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class QuanLyGheTau
    {
        [Key]
        public int MaQLGhe { get; set; }
        [ForeignKey("FKMatau")]
        public int MaTau { get; set; }
        public virtual DSTau FKMaTau { get; set; }
        [ForeignKey("FKMaToa")]
        public int MaToa { get; set; }
        public virtual ToaTau FKMaToaTau { get; set; }
        public string TenViTri { get; set; }
    }
}