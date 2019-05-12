using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class DSTau
    {
        [Key]
        public int MaDSTau { get; set; }
        public int SoLuongKhoang { get; set; }
    }
}