using StudentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentShop
{
    public partial class CHITIETSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<SANPHAM> GetDetails([QueryString("bookID")] int? bookId)
        {
            var _db = new StudentShop.Models.SANPHAM_CT();
            IQueryable<SANPHAM> query = _db.SANPHAMs;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(p => p.MASP == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}