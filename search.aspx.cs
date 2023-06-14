using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string searchTerm = txtSearch.Text.Trim();

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            string query = "SELECT * FROM Products WHERE ProductName LIKE @SearchTerm";

            using (SqlCommand command = new SqlCommand(query, con))

            {

                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                con.Open(); 
                command
                    .ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lblResults.Text = $"Found {dt.Rows.Count} result(s) for '{searchTerm}'";
            }
        }

    }
}




