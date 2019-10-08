using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentShop.Models
{
    public class LOAISANPHAM
    {
        [ScaffoldColumn(false)]
        [Key]
        public int MALOAISP { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string TENLOAISP { get; set; }
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}