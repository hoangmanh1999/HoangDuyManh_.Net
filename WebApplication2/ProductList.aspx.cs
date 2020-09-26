using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using WebApplication2.Model;

namespace WebApplication2
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<WebApplication2.Model.Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new WebApplication2.Model.ProductContext();
            IQueryable<WebApplication2.Model.Product> query = _db.Products;
            if(categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}