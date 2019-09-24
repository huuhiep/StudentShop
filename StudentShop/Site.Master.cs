using StudentShop.Logic;
using StudentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentShop
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new StudentShop.Models.BookContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartAction usersShoppingCart = new ShoppingCartAction())
            {
                string cartStr = string.Format("Cart ({0})",
                usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
    }
}