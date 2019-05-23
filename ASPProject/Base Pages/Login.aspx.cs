using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLibrary;

namespace ASPProject
{
    public partial class Login : System.Web.UI.Page
    {
        DataHelper helper;

        protected void Page_Load(object sender, EventArgs e)
        {
            helper = new DataHelper();

            Session["currentUser"] = null;
            Session["currentUserType"] = null;
        }

        // First get the details from both boxes
        public void GetDetails(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;

            // if Username is an email, it is a user
            if (username.Contains("@"))
                UserLogin(username, password);

            // if Username is not an email it is an admin
            else
                AdminLogin(username, password);
        }

        public void AdminLogin(string username, string password)
        {
            if (helper.ADMIN_LoginAdmin(username, password))
            {
                Session["currentUser"] = username;
                Session["currentUserType"] = "admin";
                Response.Redirect("~/Admin Pages/Content Pages/ViewStock.aspx");
            }

            else
                Console.WriteLine("No record of those credentials exist!");
        }

        public void UserLogin(string username, string password)
        {
            if (helper.USER_LoginUser(username, password))
            {
                Session["currentUser"] = username;
                Session["currentUserType"] = "user";
                Response.Redirect("~/User Pages/Content Pages/ViewProducts.aspx");
            }

            else
                Console.WriteLine("No record of those credentials exist!");
        }
    }
}