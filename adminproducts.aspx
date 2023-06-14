<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="adminproducts.aspx.cs" Inherits="adminproducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="contact_section layout_padding">
               <div class="row">
                <div class="offset-lg-2 col-md-10 offset-md-1">
                    <div class="heading_container">
                        
                        <h2 >
                            Add Product
                        </h2>
                    </div>
                </div>
            </div>
   
        <div class="layout_padding2-top">
                <div class="row">
                    <div class="col-lg-4 offset-lg-2 col-md-5 offset-md-1">
                        <form id="form2" runat="server">
                            <div class="contact_form-container">
                                <div>
                                    <div>
                                       <asp:TextBox ID="pname"  placeholder="pname" runat="server" />
                                            <asp:RequiredFieldValidator ID="Validator" ControlToValidate="pname" ErrorMessage=" required text field" runat="server" ForeColor="Red" />
                                    </div>
                                    <br>
                                    <div>
                                       <asp:TextBox ID="price"  placeholder="price" runat="server" />
                                        <asp:RegularExpressionValidator ID="regexValidator" runat="server" ControlToValidate="price"
                                             ErrorMessage="Please enter a valid number" ValidationExpression="^\d+(\.\d+)?$" />
                                          <asp:RequiredFieldValidator ID="Validator1" ControlToValidate="price" ErrorMessage=" required text field" runat="server" ForeColor="Red" />
                                    </div>
                                    <br>
                                    <div>
                                       <asp:TextBox ID="description"  placeholder="description" runat="server" />
                                          <asp:RequiredFieldValidator ID="Validator2" ControlToValidate="description" ErrorMessage=" required text field" runat="server" ForeColor="Red" />
                                    </div><div>
                                       <asp:FileUpload ID="imageUpload" runat="server" />
                                    </div>
                                    <br>
                                    
                                    <div>
                                         <asp:Button ID="submit" runat="server" OnClick="Submit_Click" Width="184px"  text="Add " />
                                        <asp:Button ID="back" runat="server" OnClick="Back_Click" Width="184px"  text="Back " />
                                    </div>
                                     <div>
                                <asp:Label ID="successLabel" runat="server" Visible="false" Text="Product added successfully!" CssClass="success-message" />
                            </div>
                                </div>
                            </div>
                        </form>
                    </div>
                   
                </div>
            </div>
         </section>
        
</asp:Content>

