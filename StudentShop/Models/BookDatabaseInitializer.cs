using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentShop.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
new Category
{
CategoryID = 1,
CategoryName = "Bút Mực"
},
new Category
{
CategoryID = 2,
CategoryName = "Bút Chì"
},
new Category{
CategoryID = 3,
CategoryName = "Thước Kẻ"
},
new Category
{
CategoryID = 4,
CategoryName = "Vở"
}
};
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
 //book 1a
 new Book
{
BookID = 1,
BookName = "Bút Bi Xanh",
Description = "Mực ra đều,đậm",
ImagePath="Pic1a.png",
UnitPrice = 3000f,
CategoryID = 1
},
 //book 1b
 new Book
{
BookID = 2,
BookName = "Bút Bi Đỏ",
Description = "Màu mực đều",
ImagePath="Pic1b.png",
UnitPrice = 3500f,
CategoryID = 1
},
//book 2a
new Book
{
BookID = 3,
BookName = "Bút Chì Gỗ",
Description = "Ngòi cứng,đậm,dễ xóa",
ImagePath="Pic2a.png",
UnitPrice = 4000f,
CategoryID = 2
},
//book 2b
new Book
{
BookID = 4,
BookName = "Bút Chì Màu",
Description = "Nhiều màu,nhiều chọn lựa",
ImagePath="Pic2b.png",
UnitPrice = 10000f,
CategoryID = 2
},
//book 3a
new Book
{
BookID = 5,
BookName = "Thước Nhựa Dẻo",
Description = "Dẻo,bền,khó gãy",
ImagePath="Pic3a.jpg",
UnitPrice = 5000f,
CategoryID = 3
},
//book 3b
new Book
{
BookID = 6,
BookName = "Thước Nhựa Cứng",
Description = "Thẳng,cứng,chắc",
ImagePath="Pic3b.png",
UnitPrice = 5500f,
CategoryID = 3
},

//book 4as
new Book
{
BookID = 7,
BookName = "Vở 100 trang",
Description = "Giấy trắng,mỏng",
ImagePath="Pic4a.jpg",
UnitPrice = 2500f,
CategoryID = 4
},

//book 4b
new Book
{
BookID = 8,
BookName = "Vở 200 trang",
Description = "Giấy dày,bìa cứng",
ImagePath="Pic4b.jpg",
UnitPrice = 5000f,
CategoryID = 4
},

};
            return books;
        }
    }
}
