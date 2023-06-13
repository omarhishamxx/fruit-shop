using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public partial class adminproducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        string productName = pname.Text;
        decimal Price = decimal.Parse(price.Text);
        string Description = description.Text;
        string imageURL = imageurl.Text;

       
        using (con)
        {
            string insertQuery = "INSERT INTO Products (ProductName, Price,Description, ImageURL) VALUES (@ProductName, @Price,@Description, @ImageURL)";
            using (SqlCommand command = new SqlCommand(insertQuery, con))
            {
                // Add parameter values to the SqlCommand
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@ImageURL", imageURL);

                // Open the connection
                con.Open();

                // Execute the INSERT statement
                command.ExecuteNonQuery();

                // Close the connection
                con.Close();
            }
        }

        // Optionally, you can redirect the user to a different page after the insertion
        // Response.Redirect("success.html");
    }
}