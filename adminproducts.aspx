<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="adminproducts.aspx.cs" Inherits="adminproducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>ADD Product</h2>
   
        <div class="layout_padding2-top">
                <div class="row">
                    <div class="col-lg-4 offset-lg-2 col-md-5 offset-md-1">
                        <form id="form2" runat="server">
                            <div class="contact_form-container">
                                <div>
                                    <div>
                                       <asp:TextBox ID="pname"  placeholder="pname" runat="server" />
                                    </div>
                                    <div>
                                       <asp:TextBox ID="price"  placeholder="price" runat="server" />
                                    </div>
                                    <div>
                                       <asp:TextBox ID="categoryid"  placeholder="cateoryid" runat="server" />
                                    </div>
                                    
                                    <div>
                                       <asp:TextBox ID="description"  placeholder="description" runat="server" />
                                    </div><div>
                                       <asp:TextBox ID="imageurl"  placeholder="imageurl" runat="server" />
                                    </div>
                                    
                                    <div>
                                         <asp:Button ID="submit" runat="server" OnClick="Submit_Click" Width="184px"   />
                                    </div>
                                </div>
                            </div>
                        </form>
                    </div>
                   
                </div>
            </div>
        
</asp:Content>

