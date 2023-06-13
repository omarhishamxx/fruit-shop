<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="buy.aspx.cs" Inherits="buy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        <h2>Product Details</h2>
        <div>
            <label>Product ID: </label>
            <asp:Label ID="lblProductId" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <label>Product Name: </label>
            <asp:Label ID="lblProductName" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <label>Product Price: </label>
            <asp:Label ID="lblProductPrice" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Image ID="imgProduct" runat="server" Height="200px" Width="200px" />
        </div>
         <div>
             <asp:Label ID = "lblErrorMessage" runat="server" Text=""></asp:Label>
         </div>
    </div>

</asp:Content>

