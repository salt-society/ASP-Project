using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLibrary;

namespace ASPProject.User_Pages
{
    public partial class User : System.Web.UI.MasterPage
    {
        DataHelper helper;

        private DataSet userDetails;
        private string currentUser;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["currentUser"] != null && Session["currentUserType"] != null)
            {
                if(Session["currentUserType"].ToString() != "user")
                {
                    Response.Redirect("~/Base Pages/Login.aspx");
                }

                else
                {
                    helper = new DataHelper();

                    currentUser = Session["currentUser"].ToString();

                    userDetails = helper.USER_GetUserData(currentUser);

                    userLabel.Text = "Welcome, " + userDetails.Tables[0].Rows[0][2];
                }
            }
        }

        // For a safe logout
        public void SafeLogout(object sender, EventArgs e)
        {
            Session["currentUser"] = null;
            Session["currentUserType"] = null;
        }
    }
}