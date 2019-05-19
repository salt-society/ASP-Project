using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataHelper
    {
        static String myConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aeon\Desktop\Zero Waste\ASP-Project\ASPProject\App_Data\GMBDatabase.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(myConnStr);

        // Check if there is a record in the admin table with the username and password
        public bool ADMIN_LoginAdmin(string admin_id, string password)
        {
            DataSet dataSet = new DataSet();

            SqlDataAdapter ADMIN_LoginAdmin = new SqlDataAdapter("ADMIN_LoginAdmin", myConn);
            ADMIN_LoginAdmin.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            ADMIN_LoginAdmin.SelectCommand.Parameters.Add("@admin_id", SqlDbType.NVarChar).Value = admin_id;
            ADMIN_LoginAdmin.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            ADMIN_LoginAdmin.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count != 0)
                return true;

            else
                return false;
        }

        // Check if there is a record in the user table with the username and password
        public bool USER_LoginUser(string user_id, string password)
        {
            DataSet dataSet = new DataSet();

            SqlDataAdapter USER_LoginUser = new SqlDataAdapter("USER_LoginUser", myConn);
            USER_LoginUser.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            USER_LoginUser.SelectCommand.Parameters.Add("@user_id", SqlDbType.NVarChar).Value = user_id;
            USER_LoginUser.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            USER_LoginUser.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count != 0)
                return true;

            else
                return false;
        }

        // Create a new user
        public void USER_CreateNewUser(string user_id, string password, string fname, string lname)
        {
            myConn.Open();
            SqlCommand USER_CreateNewUser = new SqlCommand("USER_CreateNewUser", myConn);
            USER_CreateNewUser.CommandType = System.Data.CommandType.StoredProcedure;
            USER_CreateNewUser.Parameters.Add("@user_id", SqlDbType.NVarChar).Value = user_id;
            USER_CreateNewUser.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            USER_CreateNewUser.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            USER_CreateNewUser.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            USER_CreateNewUser.ExecuteNonQuery();
            myConn.Close();
        }

        // Get a product's details
        public DataSet PRODUCT_GetProductDetails(string product_name)
        {
            DataSet dataSet = new DataSet();

            SqlDataAdapter PRODUCT_GetProductDetails = new SqlDataAdapter("PRODUCT_GetProductDetails", myConn);
            PRODUCT_GetProductDetails.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            PRODUCT_GetProductDetails.SelectCommand.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = product_name;

            PRODUCT_GetProductDetails.Fill(dataSet);

            return dataSet;
        }

        // Edit a product's stock
        public void PRODUCT_EditStock(string selectedProduct, int stock)
        {
            myConn.Open();
            SqlCommand PRODUCT_EditStock = new SqlCommand("PRODUCT_EditStock", myConn);
            PRODUCT_EditStock.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = selectedProduct;
            PRODUCT_EditStock.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
            PRODUCT_EditStock.ExecuteNonQuery();
            myConn.Close();
        }

        // Add a product
        public void PRODUCT_CreateNewProduct(string product_name, int stock, int price, string description, string image)
        {
            myConn.Open();
            SqlCommand PRODUCT_CreateNewProduct = new SqlCommand("PRODUCT_CreateNewProduct", myConn);
            PRODUCT_CreateNewProduct.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = product_name;
            PRODUCT_CreateNewProduct.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
            PRODUCT_CreateNewProduct.Parameters.Add("@price", SqlDbType.Int).Value = price;
            PRODUCT_CreateNewProduct.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
            PRODUCT_CreateNewProduct.Parameters.Add("@image", SqlDbType.NVarChar).Value = image;
            PRODUCT_CreateNewProduct.ExecuteNonQuery();
            myConn.Close();
        }
    }
}
