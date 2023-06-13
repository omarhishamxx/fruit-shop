
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class editprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)
        {
            // Redirect the user to the login page or any other appropriate page
            Response.Redirect("login.aspx");
        }

        if (!IsPostBack)
        {
            

            // Retrieve the user's existing profile information
            int userId = GetLoggedInUserId(); // Implement this method to get the logged-in user's ID
           
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT FirstName, LastName, Email FROM Customers WHERE CustomerId = @userId";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtemail.Text = reader["Email"].ToString();
                        }
                    }
                }
            }
        }
    }
    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void btnEditUsername_Click(object sender, EventArgs e)
    {
        try
        {
            // Retrieve the updated profile information
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Email = txtemail.Text;

            // Update the table with the new profile information
            int userId = GetLoggedInUserId(); // Implement this method to get the logged-in user's ID

         


            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                con.Open();
                string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE CustomerId = @userId";
                
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Profile updated successfully
                        Labelmsg.Text = "Profile updated successfully!";
                    }
                    else
                    {
                        // Profile update failed
                        Labelmsg.Text = "Failed to update profile. Please try again.";
                    }
                }
            }
        }
        
        catch (Exception ex)
        {
            // Log the exception or display an error message
            lblErrorMessage.Text = "An error occurred: " + ex.Message;
        
        }
    }

    // Implement this method to get the logged-in user's ID
    private int GetLoggedInUserId()
    {
        int id = (int)Session["CustomerId"];
        return id;
    }
}




/*using System;
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
        if (Session["CustomerId"] == null )
        {
            // Redirect the user to the login page or any other appropriate page
            Response.Redirect("login.aspx");
        }

        if (!IsPostBack)
        {
            // Get the current username from the session
            string username = (string)Session["FirstName"];
            string email = (string)Session["Email"];
            txtemail.Text = email;


            // Display the current username on the page
            txtFirstName.Text = username;

        }

    }


    protected void btnEditUsername_Click(object sender, EventArgs e)
    {
        // Get the new username from the input field


        string email = (string)Session["Email"];
        int userId = (int)Session["CustomerId"];

        string newFirstname = txtFirstName.Text;
        string newLastname = txtLastName.Text;
        UpdateUsernameInDataStorage(newLastname);


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



    protected void txtemail_TextChanged(object sender, EventArgs e)
    {

    }
}*/

