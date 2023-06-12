using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class adminview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["isAdmin"] == null || !(bool)Session["isAdmin"])
        {
            // Redirect the user to the login page or any other appropriate page
            Response.Redirect("login.aspx");
        }
        if (!IsPostBack)
        {
            Bindadmin();
        }
    }
    private void Bindadmin()
    {     // Retrieve customer data from the database
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        string query = "SELECT firstname, lastname, email, address, city FROM customers";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the customer data to the GridView control
            customersGridView.DataSource = dataTable;
            customersGridView.DataBind();
        }
    }
    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminpanel.aspx");
    }
    protected void customersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        // Get the ID of the customer to be deleted
        int customerId = Convert.ToInt32(customersGridView.DataKeys[e.RowIndex].Value);

        // Delete the customer from the database
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        string query = "DELETE FROM customers WHERE id = @CustomerId";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                // Refresh the GridView to reflect the changes
                Bindadmin();
                Label1.Text = "Customer deleted successfully.";
            }
            else
            {
                Label1.Text = "Failed to delete the customer.";
            }
        }
    }
}