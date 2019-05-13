using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLVT.Models
{
    public class User
    { 
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}