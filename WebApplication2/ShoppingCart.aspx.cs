﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Logic;
using WebApplication2.Model;

namespace WebApplication2
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List <CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions =new ShoppingCartActions();
            return actions.GetCartItems();
        }
    }
}