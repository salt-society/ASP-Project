using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPProject.User_Pages
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        DataHelper helper;

        string currentUser;

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

                    currentUser = Session["currentUser"].ToString();

                    DataSet userDetails = helper.USER_GetUserData(currentUser);

                    passBox.Text = userDetails.Tables[0].Rows[0][1].ToString();

                    fnameBox.Text = userDetails.Tables[0].Rows[0][2].ToString();

                    lnameBox.Text = userDetails.Tables[0].Rows[0][3].ToString();
                }
            }
        }

        // Get Details from Boxes
        public void GetDetails(object sender, EventArgs e)
        {
            string password = passBox.Text;
            string confirm = confirmBox.Text;
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;

            // Preliminary Checking
            if (password != confirm)
            {
                Console.WriteLine("Passwords do not match!");
                return;
            }

            // Try to Edit the Data
            try
            {
                helper.USER_EditUserDetails(currentUser, password, fname, lname);
                Response.Redirect("~/User Pages/Content Pages/Profile.aspx");
            }

            catch
            {
                Console.WriteLine("Something went wrong... Try again!");
                return;
            }
        }
    }
}