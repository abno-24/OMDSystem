<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminNGOmanagement.aspx.cs" Inherits="OMDSystem.adminNGOmanagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

      <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>NGO Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <img width="100px" src="imgs/NGOmanagement.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>NGO ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"
                                        placeholder="ID"></asp:TextBox><br />
                                        <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-8">
                                <label>NGO Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"
                                        placeholder="Name"></asp:TextBox><br />
                                </div>
                            </div>
                        </div>

                        <div class="d-grid gap-4 d-md-block">
                            <center>
                            <asp:Button CssClass="btn btn-success" ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
                            <asp:Button CssClass="btn btn-warning" ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                            <asp:Button CssClass="btn btn-danger" ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
                            </center>
                        </div>
                    </div>
                </div>

                <a href="Homepage.aspx"><< Back to Home</a><br /><br />
            </div>

            <div class="col-md-7">
                 <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>NGO List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=LAPTOP-258O2DGA;Initial Catalog=OMDSdb;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ngo_management]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView Class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ngo_id" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="ngo_id" HeaderText="ngo_id" ReadOnly="True" SortExpression="ngo_id" />
                                        <asp:BoundField DataField="ngo_name" HeaderText="ngo_name" SortExpression="ngo_name" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                       
                    </div>
                </div>
            </div>
        </div>
      </div>

</asp:Content>
