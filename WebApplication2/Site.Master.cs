using System;
using System.Linq;
using System.Web.UI;

namespace WebApplication2
{
    public partial class SiteMaster : MasterPage
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
        public IQueryable<WebApplication2.Model.Category> GetCategories()
        {
            var _db = new WebApplication2.Model.ProductContext();
            IQueryable<WebApplication2.Model.Category> query = _db.Categories; 
            return query;
        }
    }
}