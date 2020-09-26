using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Logic;

namespace WebApplication2
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductID"];
            int productId;
            if(!String.IsNullOrEmpty(rawId) && int.TryParse(rawId,out productId))
            {
                using (ShoppingCartActions userShoppingCart = new ShoppingCartActions())
                {
                    userShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without aProductId.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspxwithout setting a ProductId.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}