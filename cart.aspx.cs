using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.SessionState;

public partial class cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Retrieve cart data from the database or any other source
            DataTable cartData = GetCartData();

            // Bind the cart data to the GridView
            customersGridView.DataSource = cartData;
            customersGridView.DataBind();
        }
    }

    private DataTable GetCartData()
    {
        DataTable cartData = new DataTable();

        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            int customerId = int.Parse(Session["CustomerId"].ToString());

            string query = "SELECT product AS ProductName, quantity AS Quantity, total_price AS TotalPrice FROM cart WHERE customerid = @CustomerId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);

            SqlDataReader reader = command.ExecuteReader();

            // Add columns to the DataTable
            cartData.Columns.Add("ProductName", typeof(string));
            cartData.Columns.Add("Quantity", typeof(int));
            cartData.Columns.Add("TotalPrice", typeof(decimal));

            while (reader.Read())
            {
                // Add rows to the DataTable
                cartData.Rows.Add(
                    reader["ProductName"].ToString(),
                    int.Parse(reader["Quantity"].ToString()),
                    decimal.Parse(reader["TotalPrice"].ToString())
                );
            }

            reader.Close();
        }

        return cartData;
    }
}
/*
 private DataTable GetCartData()
    {
        DataTable cartData = new DataTable();

        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            int customerId = int.Parse(Session["CustomerId"].ToString());

            string query = "SELECT product AS ProductName, quantity AS Quantity, total_price AS TotalPrice FROM cart WHERE customerid = @CustomerId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);

            SqlDataReader reader = command.ExecuteReader();

            // Add columns to the DataTable
            cartData.Columns.Add("ProductName", typeof(string));
            cartData.Columns.Add("Quantity", typeof(int));
            cartData.Columns.Add("TotalPrice", typeof(decimal));

            while (reader.Read())
            {
                // Add rows to the DataTable
                cartData.Rows.Add(
                    reader["ProductName"].ToString(),
                    int.Parse(reader["Quantity"].ToString()),
                    decimal.Parse(reader["TotalPrice"].ToString())
                );
            }

            reader.Close();
        }

        return cartData;
    }

*/
/*     <div style="display: flex; align-items: center;">
        <div style="border: 1px solid black; padding: 10px;">
            <h2>Cart Details</h2>
            <table>
                <tr>
                    <th>Product Name</th>
                    <th>Product Price</th>
                    <th>Quantity</th>
                    <th>Total Price</th>
                </tr>
                <tr>
                    <td><asp:Label ID="lblProdName" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lblProdPrice" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lblProdQuan" runat="server" Text=""></asp:Label></td>
                   
                </tr>
                <tr>
                    <td colspan="3" style="text-align: right;">Total:</td>
                    <td>$35</td>
                </tr>
            </table>
        </div>
    </div>
*/