<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeFile="shop.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="fruit_section layout_padding">
    

    <div class="container-fluid">

      <div class="fruit_container">

        <div class="box">
          <img src="images/f-1.jpg" alt="">

          <div class="link_box">

            <h5>
              Orange
                 <br />
                8.99 EGP 
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
                  <br />
                16.99 EGP 
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
                  <br />
                9.99 EGP 
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
                  <br />
                15.99 EGP 
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
                  <br />
                28.99 EGP 
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
                  <br />
                21.85 EGP 
            </h5>
            <a href="buy.aspx?product=7">
                Buy Now
            </a>
          </div>

        </div>

      </div>
    </div>
  </section>
</asp:Content>

