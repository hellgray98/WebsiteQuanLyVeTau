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
        [ForeignKey("")]
        public int MaLichTau { get; set; }
        public int MaKhachHang { get; set; }
        public int MaHangVe { get; set; }
        public int MaToa { get; set; }
        public int MaViTri { get; set; }
        public string GiaTien { get; set; }
        public int SoLuongKhach { get; set; }
    }
}