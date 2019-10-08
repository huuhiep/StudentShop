using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentShop.Models
{
    public class THONGTIN : DropCreateDatabaseAlways<SANPHAM_CT>
    {
        protected override void Seed(SANPHAM_CT context)
        {
            GetLOAISANPHAMs().ForEach(c => context.LOAISANPHAMs.Add(c));
            GetSANPHAMs().ForEach(p => context.SANPHAMs.Add(p));
        }
        private static List<LOAISANPHAM> GetLOAISANPHAMs()
        {
            var loaisanphams = new List<LOAISANPHAM> {
new LOAISANPHAM
{
MALOAISP = 1,
TENLOAISP = "Bút Mực"
},
new LOAISANPHAM
{
MALOAISP = 2,
TENLOAISP = "Bút Chì"
},
new LOAISANPHAM{
MALOAISP = 3,
TENLOAISP = "Thước Kẻ"
},
new LOAISANPHAM
{
MALOAISP = 4,
TENLOAISP = "Vở"
}
};
            return loaisanphams;
        }
        private static List<SANPHAM> GetSANPHAMs()
        {
            var sanphams = new List<SANPHAM> {
 //sp 1a
 new SANPHAM
{
MASP = 1,
TENSP = "Bút Bi Xanh",
THONGTIN = "Mực ra đều,đậm",
ANH="Pic1a.png",
DONGIA = 3000,
MALOAISP = 1
},
 //sp 1b
 new SANPHAM
{
MASP = 2,
TENSP = "Bút Bi Đỏ",
THONGTIN = "Màu mực đều",
ANH="Pic1b.png",
DONGIA = 3500,
MALOAISP = 1
},
//sp 2a
new SANPHAM
{
MASP = 3,
TENSP = "Bút Chì Gỗ",
THONGTIN = "Ngòi cứng,đậm,dễ xóa",
ANH="Pic2a.png",
DONGIA = 4000,
MALOAISP = 2
},
//sp 2b
new SANPHAM
{
MASP = 4,
TENSP = "Bút Chì Màu",
THONGTIN = "Nhiều màu,nhiều chọn lựa",
ANH="Pic2b.png",
DONGIA = 10000,
MALOAISP = 2
},
//sp 3a
new SANPHAM
{
MASP = 5,
TENSP = "Thước Nhựa Dẻo",
THONGTIN = "Dẻo,bền,khó gãy",
ANH="Pic3a.jpg",
DONGIA = 5000,
MALOAISP = 3
},
//sp 3b
new SANPHAM
{
MASP = 6,
TENSP = "Thước Nhựa Cứng",
THONGTIN = "Thẳng,cứng,chắc",
ANH="Pic3b.png",
DONGIA = 5500,
MALOAISP = 3
},

//sp 4as
new SANPHAM
{
MASP = 7,
TENSP = "Vở 100 trang",
THONGTIN = "Giấy trắng,mỏng",
ANH="Pic4a.jpg",
DONGIA = 2500,
MALOAISP = 4
},

//sp 4b
new SANPHAM
{
MASP = 8,
TENSP = "Vở 200 trang",
THONGTIN = "Giấy dày,bìa cứng",
ANH="Pic4b.jpg",
DONGIA = 5000,
MALOAISP = 4
},

};
            return sanphams;
        }
    }
}
