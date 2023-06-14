<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="buy.aspx.cs" Inherits="buy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <center>
<div style="display: flex; align-items: center;">
    <div style="border: 1px solid black; padding: 10px;">
        <h2>Product Details</h2>
        <div style="display: flex; align-items: center;">
            <asp:Image ID="imgProduct" runat="server" Height="200px" Width="200px" style="margin-right: 10px;" />
            <div>
                <div>
                    <label>Product Name: </label>
                    <asp:Label ID="lblProductName" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <label>Product Price: </label>
                    <asp:Label ID="lblProductPrice" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div style="margin-left: auto;">
                <form runat="server">
                    <asp:TextBox type="number" ID="quantityy" runat="server" name="quantity" min="1" max="5" step="0.5" value="1"></asp:TextBox>
                    <label for="quantityy">kilo</label>
                    <asp:Button type="button" ID="addToCart" runat="server" OnClick="btnAddToCart_Click" Text="Add to Cart" />
                </form>
            </div>
        </div>
        <div>
            <label>Product ID: </label>
            <asp:Label ID="lblProductId" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblSuccessMessage" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblErrorMessage" runat="server" Text=""></asp:Label>
        </div>
    </div>
  </div>
      </center>
</asp:Content>

