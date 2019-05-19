using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLibrary;

namespace ASPProject.Base_Sites
{
    public partial class Register : System.Web.UI.Page
    {
        DataHelper helper;

        protected void Page_Load(object sender, EventArgs e)
        {
            helper = new DataHelper();
        }

        // First get details from input boxes
        public void GetDetails(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;
            string confirm = confirmBox.Text;
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;

            // Some beyond HTML controls checking
            if (password != confirm)
            {
                Console.WriteLine("Passwords do not match!");
                return;
            }

            // Arrives here if there are no problems
            RegisterUser(username, password, fname, lname);
        }

        public void RegisterUser(string username, string password, string fname, string lname)
        {
            // Let's try to create a user
            try
            {
                helper.USER_CreateNewUser(username, password, fname, lname);
                Response.Redirect("~/Base Pages/Login.aspx");
            }

            catch(Exception)
            {
                Console.WriteLine("Something went wrong... Try again!");
                return;
            }
        }
    }
}