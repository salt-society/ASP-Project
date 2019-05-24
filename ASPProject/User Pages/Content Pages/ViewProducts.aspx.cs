using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPProject.User_Pages
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["currentUser"] != null && Session["currentUserType"] != null)
            {
                if(Session["currentUserType"].ToString() != "user")
                {
                    Console.WriteLine("Invalid User Type");
                    Response.Redirect("~/Base Pages/Login.aspx");
                }
            }

            else
            {
                Console.WriteLine("No user currently logged in");
                Response.Redirect("~/Base Pages/Login.aspx");
            }
        }

        // Send to product page when Grid view row is selected
        public void SendToProductPage(object sender, EventArgs e)
        {
            GridViewRow selectedRow = ProductGrid.SelectedRow;

            Session["selectedProduct"] = selectedRow.Cells[1].Text;

            Response.Redirect("~/User Pages/Content Pages/ViewProduct.aspx");
        }
    }
}