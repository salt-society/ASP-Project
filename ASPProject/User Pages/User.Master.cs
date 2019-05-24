using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPProject.User_Pages
{
    public partial class NewUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null && Session["currentUserType"] != null)
            {
                if (Session["currentUserType"].ToString() != "admin")
                    userLabel.Text = "Welcome, " + Session["currentUser"];

                else
                    Response.Redirect("~/Base Pages/Login.aspx");
            }

            else
                Response.Redirect("~/Base Pages/Login.aspx");
        }

        // Safe Logout
        public void SafeLogout(object sender, EventArgs e)
        {
            Session["currentUser"] = null;
            Session["currentUserType"] = null;
            Session["cartName"] = null;
            Session["cartQuantity"] = null;
            Session["cartPrice"] = null;
            Session["selectedProduct"] = null;

            Response.Redirect("~/Base Pages/Login.aspx");
        }
    }
}