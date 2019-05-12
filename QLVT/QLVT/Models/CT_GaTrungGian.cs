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
        public string ThoiGianDung { get; set; }
    }
}