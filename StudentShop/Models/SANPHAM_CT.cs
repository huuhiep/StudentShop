using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace StudentShop.Models
{
    public class SANPHAM_CT : DbContext
    {
        public SANPHAM_CT() : base("StudenShop")
        { }
        public DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}