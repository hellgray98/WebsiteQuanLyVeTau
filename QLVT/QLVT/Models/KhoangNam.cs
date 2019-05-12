using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class KhoangNam
    {
        [Key]
        public int MaKhoangNam { get; set; }
        public string ViTriKhoang_4 { get; set; }
        public string ViTriKhoang_6 { get; set; }
    }
}