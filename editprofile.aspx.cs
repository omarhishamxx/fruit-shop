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
using static System.Net.Mime.MediaTypeNames;

public partial class editprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            // Get the current username from the session
            string username = (string)Session["FirstName"];
            string email = (string)Session["Email"];
            test.Text = email;


            // Display the current username on the page
            txtFirstName.Text = username;

        }

    }


    protected void btnEditUsername_Click(object sender, EventArgs e)
    {
        // Get the new username from the input field


        string email = (string)Session["Email"];
        int userId = (int)Session["CustomerId"];
        string newUsername = txtLastName.Text;
        UpdateUsernameInDataStorage(newUsername);


        // Update the session with the new username


        // Display a success message


    }

    private void UpdateUsernameInDataStorage(string newUsername)
    {
        string email = (string)Session["Email"];
        string connectionString = "Data Source = 3ASSAL\\MSSQLSERVER01; Initial Catalog = fruit; Integrated Security = True";
        string updateQuery = "UPDATE Customers SET FirstName = @newUsername WHERE Email = @email";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@newUsername", newUsername);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }


}




