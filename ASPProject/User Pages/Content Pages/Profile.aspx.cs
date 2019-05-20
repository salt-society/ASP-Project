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
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataHelper helper;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null && Session["currentUserType"] != null)
            {
                if (Session["currentUserType"].ToString() != "user")
                {
                    Response.Redirect("~/Base Pages/Login.aspx");
                }

                else
                {
                    helper = new DataHelper();

                    string currentUser = Session["currentUser"].ToString();

                    DataSet userDetails = helper.USER_GetUserData(currentUser);

                    emailLabel.Text = userDetails.Tables[0].Rows[0][0].ToString();

                    nameLabel.Text = userDetails.Tables[0].Rows[0][2].ToString() + " " 
                        + userDetails.Tables[0].Rows[0][3].ToString();
                }
            }
        }

        // Go to edit profile page
        public void GoToEdit(object sender, EventArgs e)
        {
            Response.Redirect("~/User Pages/Content Pages/EditProfile.aspx");
        }
    }
}