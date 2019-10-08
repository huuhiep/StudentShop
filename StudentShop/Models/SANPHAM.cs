using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentShop.Models
{
    public class SANPHAM
    {
        [ScaffoldColumn(false)]
        [Key]
        public int MASP { get; set; }
        [Required, StringLength(100), Display(Name = "Ten San Pham")]
        public string TENSP { get; set; }
        [Required, StringLength(1000), Display(Name = "Thong Tin"),
        DataType(DataType.MultilineText)]
        public string THONGTIN { get; set; }
        public string ANH { get; set; }
        [Display(Name = "Gia")]
        public float? DONGIA { get; set; }
        public int? MALOAISP { get; set; }
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
    }
}