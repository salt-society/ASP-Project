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
        DataSet dataSet;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["currentUser"] != null && Session["currentUserType"] != null)
            {
                if(Session["currentUserType"].ToString() != "user")
                {
                    Console.WriteLine("Invalid user type!");
                    Response.Redirect("~/Base Pages/Login.aspx");
                }

                else if(Session["selectedProduct"].ToString() == "null")
                {
                    Console.WriteLine("Can't reach here without a selected product");
                    Response.Redirect("~/User Pages/Content Pages/ViewProducts.aspx");
                }

                else
                {
                    helper = new DataHelper();

                    string selectedProduct = Session["selectedProduct"].ToString();

                    dataSet = helper.PRODUCT_GetProductDetails(selectedProduct);

                    productImage.ImageUrl = dataSet.Tables[0].Rows[0][5].ToString();
                    nameLabel.Text = selectedProduct;
                    descriptionLabel.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    stockLabel.Text = "Remaining Stock: " +dataSet.Tables[0].Rows[0][2].ToString();
                    priceLabel.Text = "Price: " + dataSet.Tables[0].Rows[0][3].ToString();
                }
            }

            else
            {
                Console.WriteLine("No user found!");
                Response.Redirect("~/Base Pages/Login.aspx");
            }
        }

        // Change index of quantity
        public void ChangeInput(object sender, EventArgs e)
        {
            // Get the ID of the button clicked
            Button b = sender as Button;
            string buttonName = b.ID;

            // Get the label we're going to edit
            int valueChanged = Convert.ToInt32(editLabel.Text);

            if (buttonName == "plusButton")
                valueChanged++;

            else
            {
                if(valueChanged > 1)
                    valueChanged--;
            }
                
            editLabel.Text = valueChanged.ToString();
        }

        // Add to cart
        public void AddToCart(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(editLabel.Text);
            int price = Convert.ToInt32(priceLabel.Text.Substring(6));

            if((Session["cartName"] != null && Session["cartQuantity"] != null) && Session["cartPrice"] != null)
            {
                List<String> cartName = Session["cartName"] as List<String>;
                List<int> cartQuantity = Session["cartQuantity"] as List<int>;
                List<int> cartPrice = Session["cartPrice"] as List<int>;

                string selectedProduct = Session["selectedProduct"].ToString();

                if(cartName.Contains(selectedProduct))
                {
                    int index = cartName.IndexOf(selectedProduct);

                    cartQuantity[index] += quantity;
                    cartPrice[index] += price * quantity;
                }

                else
                {
                    cartName.Add(selectedProduct);
                    cartQuantity.Add(quantity);
                    cartPrice.Add(price * quantity);
                }

                Session["cartName"] = cartName;
                Session["cartQuantity"] = cartQuantity;
                Session["cartPrice"] = cartPrice;

                Response.Redirect("~/User Pages/Content Pages/ViewCart.aspx");
            }
        }
    }
}