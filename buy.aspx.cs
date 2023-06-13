﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.SessionState;

public partial class buy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   try 
       { 
        if (!IsPostBack)
        {
            string productId = Request.QueryString["product"];
            lblProductId.Text = productId;

            // Retrieve product details from the database
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT ProductName, Price , ImageUrl FROM Products WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            string productPrice = reader["Price"].ToString();
                                string imageUrl = reader["ImageUrl"].ToString();

                                lblProductName.Text = productName;
                                lblProductPrice.Text = productPrice;
                                imgProduct.ImageUrl = imageUrl;

                            }
                    }
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
}
 



