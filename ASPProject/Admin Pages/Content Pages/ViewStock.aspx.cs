using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPProject.Admin_Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUserType"] != null)
            {
                if (Session["currentUserType"].ToString() != "admin")
                    Response.Redirect("~/Base Pages/Login.aspx");
            }

            else
                Response.Redirect("~/Base Pages/Login.aspx");
        }
    }
}