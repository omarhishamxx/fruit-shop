﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="web_project_asp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- shop section -->
  <section class="shop_section layout_padding">
    <div class="container">
      <div class="box">

        <div class="detail-box">
          <h2>
            Fruit shop
          </h2>
          <p>
            There are many variations of fruits available
          </p>
        </div>

        <div class="img-box">
          <img src="images/shop-img.jpg" alt="">
        </div>
        
        <div class="btn-box">

          <a href="buy.aspx?product=1">
            Buy Now
          </a>

        </div>
      </div>
    </div>
  </section>

  <!-- end shop section -->

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

  <!-- fruit section -->

  <section class="fruit_section layout_padding">
    <div class="container">

      <div class="heading_container">
        <hr>
        <h2>
          Fresh Fruit
        </h2>
      </div>

    </div>

    <div class="container-fluid">

      <div class="fruit_container">

        <div class="box">
          <img src="images/f-1.jpg" alt="">

          <div class="link_box">

            <h5>
              Orange
            </h5>

            <a href="buy.aspx?product=2">
              Buy Now
            </a>

          </div>

        </div>

        <div class="box">
          <img src="images/f-2.jpg" alt="">

          <div class="link_box">

            <h5>
              Blueberry
            </h5>

            <a href="buy.aspx?product=3">
              Buy Now
            </a>

          </div>

        </div>

        <div class="box">
          <img src="images/f-3.jpg" alt="">

          <div class="link_box">

            <h5>
              Banana
            </h5>

            <a href="buy.aspx?product=4">
              Buy Now
            </a>

          </div>

        </div>

        <div class="box">
          <img src="images/f-4.jpg" alt="">

          <div class="link_box">
            <h5>
              Apple
            </h5>

            <a href="buy.aspx?product=5">
              Buy Now
            </a>

          </div>

        </div>

        <div class="box">
          <img src="images/f-5.jpg" alt="">

          <div class="link_box">
            <h5>
              Mango
            </h5>
            <a href="buy.aspx?product=6">
              Buy Now
            </a>
          </div>

        </div>

        <div class="box">
          <img src="images/f-6.jpg" alt="">

          <div class="link_box">
            <h5>
              Strawberry
            </h5>
            <a href="buy.aspx?product=7">
              Buy Now
            </a>
          </div>

        </div>

      </div>
    </div>
  </section>

  <!-- end fruit section -->




 


  



  <!-- footer section -->
  <section class="container-fluid footer_section ">
    
  </section>
  <!-- footer section -->

  <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
  <script type="text/javascript" src="js/bootstrap.js"></script>
  <script type="text/javascript" src="js/custom.js"></script>
</asp:Content>
