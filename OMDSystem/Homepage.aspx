<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="OMDSystem.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <section>
        <img src="imgs/HomePageImg1.png" class="img-fluid"/>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Our Donation Features</h2>
                        <p><b>Our 3 Primary Features</b></p>
                    </center>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/unused%20medicine.png" />
                        <h4>Unused Medicine</h4>
                        <p class="text-justify">Donate unused medicine for the needy person.</p>
                    </center>
                </div>
            
                <div class="col-md-4">
                    <center>
                        <img width="120px" src="imgs/expiredMedicine.png" />
                        <h4>Expired Medicine</h4>
                        <p class="text-justify">Donate expired medicine for the proper disposal of it.</p>
                    </center>
                </div>

                <div class="col-md-4">
                    <center>
                        <img width="180px" src="imgs/ngocenter1.jpg" />
                        <h4>NGO Center</h4>
                        <p class="text-justify">Donate medicine to your near NGO center.</p>
                    </center>
                </div>
            </div>
    </section>
    <section>
        <img src="imgs/home.png" class="img-fluid"/>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Our Process</h2>
                        <p><b>We have simple 3 step process</b></p>
                    </center>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/signup.jpg" />
                        <h4>Sign Up</h4>
                        <p class="text-justify">Create an Account.</p>
                    </center>
                </div>
            
                <div class="col-md-4">
                    <center>
                        <img width="170px" src="imgs/detail.png" />
                        <h4>Medicine Details</h4>
                        <p class="text-justify">Fill up medicine details.</p>
                    </center>
                </div>

                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/submit.png" />
                        <h4>Submit</h4>
                        <p class="text-justify">Submit details once you fill all the details</p>
                    </center>
                </div>
            </div>
    </section>
    
</asp:Content>
