using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QLVT.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }
        public virtual ICollection<VeTau> FKMaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string CMND { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}