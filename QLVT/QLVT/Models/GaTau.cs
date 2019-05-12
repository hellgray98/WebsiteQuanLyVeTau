using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class GaTau
    {
        [Key]
        public int MaGaTau { get; set; }
        public string TenGaDi { get; set; }
        public string TenGaDen { get; set; }
    }
}