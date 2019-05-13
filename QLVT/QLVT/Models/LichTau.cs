using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class LichTau
    {
        [Key]
        public int MaLichTau { get; set; }
        [ForeignKey("FKMaTau")]
        public int MaTau { get; set; }
        public virtual DSTau FKMatau { get; set; }
        [ForeignKey("FKMaGaDi")]
        public int MaGaDi { get; set; }
        public virtual GaTau FKGaDi { get; set; }
        [ForeignKey("FKMaGaDen")]
        public int MaGaDen { get; set; }
        public virtual GaTau FKGaDen { get; set; }
        public DateTime NgayDi { get; set; }
        public string ThoiGianDi { get; set; }
        public string ThoiGianDen { get; set; }
        
    }
}