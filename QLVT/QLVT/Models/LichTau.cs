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
        public virtual ICollection<VeTau> FkVeTau { get; set; }
        public virtual ICollection<CT_LichTau_VeTau> FKLichVetau { get; set; }
        public virtual ICollection<CT_GaTrungGian> FKMaLichTau { get; set; }
        [ForeignKey("FKMaTau")]
        public int? MaTau { get; set; }
        public virtual DSTau FKMaTau { get; set; }
        [ForeignKey("FKMaGaDi")]
        public int? MaGaDi { get; set; }
        public virtual GaTau FKMaGaDi { get; set; }
        [ForeignKey("FKMaGaDen")]
        public int? MaGaDen { get; set; }
        public virtual GaTau FKMaGaDen { get; set; }
        public DateTime NgayDi { get; set; }
        public string ThoiGianDi { get; set; }
        public string ThoiGianDen { get; set; }
        
    }
}