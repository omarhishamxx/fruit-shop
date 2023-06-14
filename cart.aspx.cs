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
            int customerId = int.Parse(Session["CustomerId"].ToString());
            // Retrieve cart data from the database or any other source
            DataTable cartData = GetCartData(customerId);

            // Bind the cart data to the GridView
            customersGridView.DataSource = cartData;
            customersGridView.DataBind();
        }
    }
    protected void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        int customerId = int.Parse(Session["CustomerId"].ToString());

        InsertOrder(customerId);

        ClearCart(customerId);

        lblOrderStatus.Text = "Order placed successfully";
        lblOrderStatus.ForeColor = System.Drawing.Color.Green;
        lblOrderStatus.Visible = true;
        customersGridView.DataSource = null;
        customersGridView.DataBind();

    }
    private void InsertOrder(int customerId)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Retrieve cart items for the customer
            DataTable cartData = GetCartData(customerId);

            // Get customer name and address from the Customers table
            string customerName = string.Empty;
            string customerAddress = string.Empty;
            string customerQuery = "SELECT FirstName, Address FROM Customers WHERE CustomerId = @CustomerId";
            SqlCommand customerCommand = new SqlCommand(customerQuery, connection);
            customerCommand.Parameters.AddWithValue("@CustomerId", customerId);
            SqlDataReader customerReader = customerCommand.ExecuteReader();

            if (customerReader.Read())
            {
                customerName = customerReader["FirstName"].ToString();
                customerAddress = customerReader["Address"].ToString();
            }

            customerReader.Close();

            // Insert each cart item into the Order table
            foreach (DataRow row in cartData.Rows)
            {
                string productName = row["ProductName"].ToString();
                int quantity = int.Parse(row["Quantity"].ToString());
                decimal totalPrice = decimal.Parse(row["TotalPrice"].ToString());

                // Perform the insert query using a parameterized query or stored procedure
                string query = "INSERT INTO [Order] (customer_id, customer_name, address, product, quantity, total_price) VALUES (@CustomerId, @CustomerName, @CustomerAddress, @Product, @Quantity, @TotalPrice)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@CustomerName", customerName);
                command.Parameters.AddWithValue("@CustomerAddress", customerAddress);
                command.Parameters.AddWithValue("@Product", productName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                command.ExecuteNonQuery();
            }
        }
    }



    private void ClearCart(int customerId)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Perform the delete query to remove the cart items for the customer
            string query = "DELETE FROM cart WHERE customerid = @CustomerId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);

            command.ExecuteNonQuery();
        }
    }

    private DataTable GetCartData(int customerId)
    {
        DataTable cartData = new DataTable();

        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT product AS ProductName, quantity AS Quantity, total_price AS TotalPrice FROM cart WHERE customerid = @CustomerId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(cartData);
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