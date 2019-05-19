using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPProject.Master_Sites
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUserType"].ToString() != "admin")
                Response.Redirect("~/Base Sites/Login.aspx");
        }

        public void SafeLogout(object sender, EventArgs e)
        {
            // Empty Session Variables Here
            Session["currentUser"] = null;
            Session["currentUserType"] = null;

            Response.Redirect("~/Base Pages/Login.aspx");
        }
    }
}