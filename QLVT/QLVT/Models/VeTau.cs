using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class VeTau
    {
        [Key]
        public int MaVeTau { get; set; }
        public string GiaTien { get; set; }
        public int SoLuongKhach { get; set; }
    }
}