using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Calculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (TextBox1.Text == "" )
            {
                Label1.Text = "du lieu phai la so";
                return;
            }
            else
            {
                Label1.Text = "";
                Label3.Text = "so thu nhat la: " + TextBox1.Text;
            }
            if (TextBox2.Text == "")
            {
                Label2.Text = "du lieu phai la so";
                return;
            }
            else
            {
                Label2.Text = "";
                Label4.Text = "so thu hai la: "+TextBox2.Text;
            }


        }
    }
}