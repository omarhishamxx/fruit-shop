using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using System.Globalization;





public partial class adminproducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["isAdmin"] == null || !(bool)Session["isAdmin"])
        {
            // Redirect the user to the login page or any other appropriate page
            Response.Redirect("login.aspx");
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    { Response.Redirect("adminpanel.aspx"); }
        protected void Submit_Click(object sender, EventArgs e)
    {
        string productName = pname.Text;
        decimal Price = decimal.Parse(price.Text);
        string Description = description.Text;

        // Check if an image file was uploaded
        if (imageUpload.HasFile)
        {
            // Specify the directory to save the uploaded images
            string uploadDirectory = Server.MapPath("~/images/");

            // Get the filename of the uploaded image
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageUpload.FileName);

            // Save the image to the specified directory
            string filePath = Path.Combine(uploadDirectory, fileName);
            imageUpload.SaveAs(filePath);

            // Generate the image URL based on the saved file
            string imageURL = "images/" + fileName;

            // Insert the product into the database
            InsertProduct(productName, Price, Description, imageURL);

            successLabel.Visible = true;
            ClearFields();
        }
        else
        {
            // If no image file was uploaded, display an error message or handle it as desired
        }
    }
 
        protected void FileUploadValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
        bool isFileValid = imageUpload.HasFile && imageUpload.PostedFile.ContentType == "image/jpg";
        args.IsValid = imageUpload.HasFile;

            if (!args.IsValid)
            {
                fileUploadError.Visible = true;
            }
            else
            {
                fileUploadError.Visible = false;
            }
        }
    

    private void InsertProduct(string productName, decimal price, string description, string imageURL)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        string insertQuery = "INSERT INTO Products (ProductName, Price, Description, ImageURL) VALUES (@ProductName, @Price, @Description, @ImageURL)";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(insertQuery, con))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@ImageURL", imageURL);

                con.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    private void ClearFields()
    {
        pname.Text = string.Empty;
        price.Text = string.Empty;
        description.Text = string.Empty;
        imageUpload.Dispose(); 
    }

}