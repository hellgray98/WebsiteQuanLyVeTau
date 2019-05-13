using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class ThamSo
    {
        [Key]
        public int MaThamSo { get; set; }
        public string GiaTri { get; set; }
        public string GhiChu { get; set; }
    }
}