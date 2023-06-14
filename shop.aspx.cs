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

public partial class _Default : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "SELECT ProductID, ProductName, ImageUrl, Description, Price FROM Products";

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int productId = Convert.ToInt32(reader["ProductID"]);
                string productName = reader["ProductName"].ToString();
                string imageUrl = reader["ImageUrl"].ToString();
                string price = reader["Price"].ToString();
                string description = reader["Description"].ToString();

                // Create the product elements
                Panel productPanel = new Panel();
                productPanel.CssClass = "box";

                Image productImage = new Image();
                productImage.ImageUrl = imageUrl;
                productImage.AlternateText = "";
                productPanel.Controls.Add(productImage);

                Panel linkBox = new Panel();
                linkBox.CssClass = "link_box";

                Label productNameLabel = new Label();
                productNameLabel.ID = "productname";
                productNameLabel.Text = productName;
                linkBox.Controls.Add(productNameLabel);

                Label priceLabel = new Label();
                priceLabel.Text = "Price: " + price;
                linkBox.Controls.Add(priceLabel);

                Label descriptionLabel = new Label();
                descriptionLabel.Text = description;
                linkBox.Controls.Add(descriptionLabel);

                HyperLink buyNowLink = new HyperLink();
                buyNowLink.NavigateUrl = "buy.aspx?product=" + productId;
                buyNowLink.Text = "Buy Now";
                linkBox.Controls.Add(buyNowLink);

                productPanel.Controls.Add(linkBox);

                // Add the product panel to the fruit_container
                fruit_container.Controls.Add(productPanel);
            }

            reader.Close();
        }
    }

}