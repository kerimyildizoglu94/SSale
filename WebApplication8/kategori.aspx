<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="kategori.aspx.cs" Inherits="WebApplication8.kategori" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
                 <form runat="server">
                        <div class="card">
                   
                      <div class="card-body card-block">  
                          <div class="form-group">
                            <div class="input-group">
                                <asp:TextBox ID="TextBox1" placeholder="Kategori İsmi" class="form-control" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                          </div>
                          <div class="form-actions form-group">
                              <asp:Button ID="Button1" CssClass="btn btn-secondary btn-sm" runat="server" Text="Ekle" OnClick="Button1_Click" />

                          </div>

                      </div>
                    </div>
                 </form>
                  </div>


</asp:Content>
