using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLibrary;

namespace ASPProject.Admin_Pages
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataHelper helper;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUserType"] != null)
            {
                if (Session["currentUserType"].ToString() != "admin")
                    Response.Redirect("~/Base Pages/Login.aspx");
            }
                
            else
                Response.Redirect("~/Base Pages/Login.aspx");

            helper = new DataHelper();
        }

        // Get the details first
        public void GetDetails(object sender, EventArgs e)
        {
            string productName = nameBox.Text;
            int stock = Convert.ToInt32(stockBox.Text);
            int price = Convert.ToInt32(priceBox.Text);
            string description = descBox.Text;
            string image = "Test";
            // Insert Checking for image here

            // Some preliminary checking
            if(price <= 0)
            {
                Console.WriteLine("Price cannot be less than or equal to 0$!");
                return;
            }

            // No problems encountered if it reaches here
            AddProduct(productName, stock, price, description, image);
        }

        private void AddProduct(string productName, int stock, int price, string description, string image)
        {
            try
            {
                helper.PRODUCT_CreateNewProduct(productName, stock, price, description, image);
                Response.Redirect("~/Admin Pages/Content Pages/ViewStock.aspx");
            }

            catch(Exception)
            {
                Console.WriteLine("Something went wrong... Try again!");
                return;
            }
        }
    }
}