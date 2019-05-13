using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class HangVe
    {
        [Key]
        public int MaHangVe { get; set; }
        public string TenHangVeset { get; set; }
        [ForeignKey("FKMaKhoangNam")]
        public int MaKhoangNam { get; set; }
        public virtual KhoangNam FKMaKhoangNam { get; set; }
    }
}