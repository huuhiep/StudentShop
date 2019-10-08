using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentShop.Models;
using System.Web.ModelBinding;

namespace StudentShop
{
    public partial class DANHMUCSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<SANPHAM> GetSANPHAMs([QueryString("id")] int? categoryId)
        {
            var _db = new StudentShop.Models.SANPHAM_CT();
            IQueryable<SANPHAM> query = _db.SANPHAMs;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.MALOAISP == categoryId);
            }
            return query;
        }
    }
}