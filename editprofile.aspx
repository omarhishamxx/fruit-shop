<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="editprofile.aspx.cs" Inherits="editprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
    <form id="form1" runat="server">
        
    <br >
        <h2>Edit Profile</h2>
        <table class="w-100">
            <tr>
                 <td><label for="txtFirstName">First Name:</label></td>
                 <td><asp:TextBox ID="txtFirstName"  placeholder="firstname" runat="server" /></td>
            </tr>
            <tr> 
                 <td>  <label for="txtLastName">Last Name:</label></td>
                 <td>   <asp:TextBox ID="txtLastName"  placeholder="Lastname" runat="server" /></td>
            </tr>

            <tr>
                 <td><label for="txtemail">E-mail:</label></td>
                 <td><asp:TextBox ID="txtemail" TextMode="Email"  placeholder="Email" runat="server" /></td>   
            </tr>

            <tr>
                <td> <asp:Button ID="updatebtn" type="submit" class="update-button" runat="server" OnClick="btnEditUsername_Click" text="Update"/>
                 </td>
                <td> <asp:Label ID="Labelmsg" runat="server" Text="" /></td>
                <td><asp:Button ID="backButton" runat="server" Text="Back" OnClick="backButton_Click" /></td>
            </tr>
        </table>

        <asp:Label ID="lblErrorMessage" runat="server" Text="" />
       <asp:Label ID="Labelid" runat="server" Text="" />

        
         <br >
         <br >

       
    </form>
</asp:Content>

