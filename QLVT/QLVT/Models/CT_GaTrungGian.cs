using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class CT_GaTrungGian
    { 
        [Key]
        public int MaGaTrungGian { get; set; }
        [ForeignKey("FKMaLichTau")]
        public int? MaLichTau { get; set; }
        public virtual LichTau FKMaLichTau { get; set; }    
        [ForeignKey("FKMaGa")]
        public int? MaGa { get; set; }
        public virtual GaTau FKMaGa { get; set; }
        public string ThoiGianDung { get; set; }
    }
}