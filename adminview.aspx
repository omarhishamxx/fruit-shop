<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="adminview.aspx.cs" Inherits="adminview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <section class="contact_section layout_padding">
        <form runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="offset-lg-2 col-md-10 offset-md-1">
                    <div class="heading_container">
                        <h2>Admins</h2>
                    </div>
                </div>
            </div>

            <div class="layout_padding2-top">
                <div class="row">
                    <div class="col-lg-4 offset-lg-2 col-md-5 offset-md-1">
                        <div class="contact_form-container">
                            <div>
                                <asp:GridView ID="customersGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="customersGridView_RowDeleting">
                                    <Columns>
                                        <asp:BoundField DataField="firstname" HeaderText="First Name" />
                                        <asp:BoundField DataField="lastname" HeaderText="Last Name" />
                                        <asp:BoundField DataField="email" HeaderText="Email" />
                                        <asp:BoundField DataField="address" HeaderText="Address" />
                                        <asp:BoundField DataField="city" HeaderText="City" />
                                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                                    </Columns>
                                </asp:GridView>
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                                <br />
                                <asp:Button ID="backButton" runat="server" Text="Back" OnClick="backButton_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
            </form>
    </section>
</asp:Content>

