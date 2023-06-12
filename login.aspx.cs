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




public partial class login : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        string uid = emailbox.Text;
        string pass = passbox.Text;

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            string query = "SELECT * FROM customers WHERE email = @Email AND password = @Password";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Email", uid);
                cmd.Parameters.AddWithValue("@Password", pass);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session["username"] = uid;
                    Response.Redirect("index.aspx");
                }
                else
                {
                    Label1.Text = "Incorrect email or password.";
                }

                reader.Close();
            }

            con.Close();
        }
    }

    /*protected void Login_Click(object sender, EventArgs e)
    {


        string uid = emailbox.Text;
        string pass = passbox.Text;
        con.Open();
        String qry = "select * from [customers] where email ='" + uid + "' and password='" + pass + "' ";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.Read())
        {
            Session["username"] = uid;
            Response.Redirect("index.aspx");
        }
        else
        {
            Label1.Text = "incorrect";
        }
        con.Close();


    }*/

}
