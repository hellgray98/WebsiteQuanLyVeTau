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
        public DateTime NgayDi { get; set; }
        public string ThoiGianDi { get; set; }
        public string ThoiGianDen { get; set; }
        public int MaGaTau { get; set; }
    }
}