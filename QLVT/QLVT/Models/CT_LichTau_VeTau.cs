using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class CT_LichTau_VeTau
    {  
        [Key]
        public int MaViTri { get; set; }
        [ForeignKey("FKMaLichTau")]
        public int MaLichTau { get; set; }
        public virtual LichTau FKMaLichTau { get; set; }
        [ForeignKey("FKMaVeTau")]
        public int MaVeTau { get; set; }
        public virtual VeTau FKMaVeTau { get; set; }
        public bool DaDat { get; set; }
    }
}