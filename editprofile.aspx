<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="editprofile.aspx.cs" Inherits="editprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br >
   <h2>Edit Profile</h2>
    <form method="post" action="Default.aspx" runat="server">
        <label for="txtFirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName"  placeholder="Email" runat="server" />
         <br >
         <br >

        <label for="txtLastName">Last Name:</label>
         <asp:TextBox ID="txtLastName"  placeholder="Email" runat="server" />

        <asp:TextBox ID="test" TextMode="Email"  placeholder="Email" runat="server" />

        <!-- Add other profile fields here -->
         <asp:Label ID="Labelmsg" TextMode="Text" placeholder="Email" runat="server" />
         <br >
         <br >

        <input type="submit" value="Save" OnClick="btnEditUsername_Click" />
    </form>

</asp:Content>

