using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class signup : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Signup_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        string firstName = firstnamebox.Text;
        string lastName = lastnamebox.Text;
        string email = emailbox.Text;
        string address = addressbox.Text;
        string city = citybox.Text;
        string password = passbox.Text;

        using (con)
        {
            string query = "INSERT INTO customers (firstname, lastname, email, address, city, password) VALUES (@FirstName, @LastName, @Email, @Address, @City, @Password)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Label1.Text = "Signup successful. You can now login.";

                    // Clear the form fields
                    firstnamebox.Text = string.Empty;
                    lastnamebox.Text = string.Empty;
                    emailbox.Text = string.Empty;
                    addressbox.Text = string.Empty;
                    citybox.Text = string.Empty;
                    passbox.Text = string.Empty;
                }
                else
                {
                    Label1.Text = "Signup failed. Please try again.";
                }
            }
        }
    }

}