using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLibrary;

namespace ASPProject.Admin_Pages
{
    public partial class WebForm2 : System.Web.UI.Page
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

        // Change the number to be added or reduced from the stock
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
                valueChanged--;

            editLabel.Text = valueChanged.ToString();
        }

        // Edit the selected product's stock
        public void EditStock(object sender, EventArgs e)
        {
            // First get the product to change
            string selectedProduct = ProductListBox.SelectedValue;

            // Then get it's details from the database
            DataSet dataset = helper.PRODUCT_GetProductDetails(selectedProduct);

            // First check if the value to use is positive or negative
            // Positive denotes addition, negative denotes subtraction. 0 is an error.
            int valueModifier = Convert.ToInt32(editLabel.Text);

            // Value to hold the new stock
            int newValue = 0;

            // Value to hold the current stock
            int currentStock = Convert.ToInt32(dataset.Tables[0].Rows[0][2]);

            if(valueModifier > 0)
            {
                newValue = valueModifier + currentStock;
                helper.PRODUCT_EditStock(selectedProduct, newValue);
                ResetValue();
            }

            else if(valueModifier < 0)
            {
                newValue = currentStock - valueModifier;

                if (newValue >= 0)
                {
                    helper.PRODUCT_EditStock(selectedProduct, newValue);
                    ResetValue();
                }
                    
                else
                {
                    Console.WriteLine("Value to subtract is too much for the current stock");
                    ResetValue();
                    return;
                }
            }
        }

        public void ResetValue(object sender, EventArgs e)
        {
            editLabel.Text = "0";

            // Set Stock Count
            DataSet dataset = helper.PRODUCT_GetProductDetails(ProductListBox.SelectedValue);

            int count = Convert.ToInt32(dataset.Tables[0].Rows[0][2]);

            stockCountLabel.Text = count.ToString();
        }

        private void ResetValue()
        {
            editLabel.Text = "0";

            // Set Stock Count
            DataSet dataset = helper.PRODUCT_GetProductDetails(ProductListBox.SelectedValue);

            int count = Convert.ToInt32(dataset.Tables[0].Rows[0][2]);

            stockCountLabel.Text = count.ToString();
        }
    }
}