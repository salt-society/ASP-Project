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
    public partial class WebForm9 : System.Web.UI.Page
    {
        DataHelper helper;
        DataTable table = new DataTable();
        DataRow row;

        List<String> cartName;
        List<int> cartQuantity;
        List<int> cartPrice;
        string currentUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["currentUser"] != null && Session["currentUserType"] != null)
            {
                if(Session["currentUserType"].ToString() == "user")
                {
                    helper = new DataHelper();
                    currentUser = Session["currentUser"].ToString();

                    if((Session["cartName"] != null && Session["cartQuantity"] != null) && Session["cartPrice"] != null)
                    {
                        cartName = Session["cartName"] as List<string>;
                        cartQuantity = Session["cartQuantity"] as List<int>;
                        cartPrice = Session["cartPrice"] as List<int>;

                        if(cartName.Count > 0)
                        {
                            table.Columns.Add("Product Name", typeof(string));
                            table.Columns.Add("Quantity", typeof(string));
                            table.Columns.Add("Sub Price", typeof(string));
                            table.Columns.Add("Remove from Cart", typeof(Button));

                            for (int CTR = 0; CTR < cartName.Count; CTR++)
                            {
                                row = table.NewRow();
                                row["Product Name"] = cartName[CTR];
                                row["Quantity"] = cartQuantity[CTR];
                                row["Sub Price"] = cartPrice[CTR];
                                row["Remove from Cart"] = NewButton(CTR);
                                table.Rows.Add(row);
                            }

                            Gv1.DataSource = table;
                            Gv1.DataBind();
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Not a user");
                    Response.Redirect("~/Base Pages/Login.aspx");
                }
            }

            else
            {
                Console.WriteLine("No one is logged in");
                Response.Redirect("~/Base Pages/Login.aspx");
            }
        }

        public Button NewButton(int count)
        {
            Button b = new Button();
            b.ID = count.ToString();
            b.Text = "Remove?";
            b.Click += new EventHandler(RemoveFromTable);
            return b;
        }

        public void RemoveFromTable(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int index = Convert.ToInt32(b.ID);

            table.Rows.Remove(table.Rows[index]);
            cartName.RemoveAt(index);
            cartPrice.RemoveAt(index);
            cartQuantity.RemoveAt(index);
        }

        public void PurchaseCart(object sender, EventArgs e)
        {
            if(cartName.Count > 0)
            {
                for (int CTR = 0; CTR < cartName.Count; CTR++)
                {
                    DataSet productSet = new DataSet();

                    productSet = helper.PRODUCT_GetProductDetails(cartName[CTR]);

                    int newStock = Convert.ToInt32(productSet.Tables[0].Rows[0][2]) - cartQuantity[CTR];

                    helper.PRODUCT_EditStock(cartName[CTR], newStock);

                    int productID = Convert.ToInt32(productSet.Tables[0].Rows[0][0]);

                    helper.TRANSACTION_CreateNewTransaction(productID, currentUser, cartQuantity[CTR], cartPrice[CTR], DateTime.Now.ToString());
                }

                Session["cartName"] = new List<String>();
                Session["cartPrice"] = new List<int>();
                Session["cartQuantity"] = new List<int>();

                Response.Redirect("~/User Pages/Content Pages/ViewTransactions.aspx");
            }
            
            else
            {
                Console.WriteLine("Your cart is empty");
                Response.Redirect("~/User Pages/ViewProducts.aspx");
            }
        }
    }
}