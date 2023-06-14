<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- about section -->

  <section class="about_section">
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-6 px-0">

          <div class="img-box">
            <img src="images/about-img.jpg" alt="">
          </div>

        </div>

        <div class="col-md-5">
          <div class="detail-box">
            <div class="heading_container">
              <hr>
              <h2>
                About Our Fruit Shop
              </h2>
            </div>
            
            <p>
              There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour
            </p>

            <a href="about.html">
              Read More
            </a>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- end about section -->
</asp:Content>

