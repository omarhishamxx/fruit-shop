﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="buy.aspx.cs" Inherits="buy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
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
                <asp:input type="number" id="quantityy" runat="server" name="quantity" min="1" max="5" step="0.5" value="1"/>
                <label for="quantityy">kilo</label>
                <asp:button type="button" id="addToCart" runat="server" OnClick="AddToCart_Click" Text="Add to Cart"/>
            </div>
        </div>
        <div>
            <label>Product ID: </label>
            <asp:Label ID="lblProductId" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblErrorMessage" runat="server" Text=""></asp:Label>
        </div>
    </div>
</div>


</asp:Content>

