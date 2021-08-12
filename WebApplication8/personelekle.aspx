<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="personelekle.aspx.cs" Inherits="WebApplication8.personelekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
                    <div class="col-lg-12">
                 <form runat="server">
                        <div class="card">
                   
                      <div class="card-body card-block">  
                          <div class="form-group">
                            <div class="input-group">
                                
                                <asp:TextBox ID="tbadi" placeholder="Personel Adı" class="form-control" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                                   <div class="input-group">
                                <asp:TextBox ID="tbsoyadi" placeholder="Personel Soyadı" class="form-control" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                                   <div class="input-group">
                                <asp:TextBox ID="tbtc" placeholder="Personel Tc" class="form-control" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                                            <div class="input-group">
                                <asp:TextBox ID="tbdogumtarihi" placeholder="Duğum Tarihi gün.ay.yıl" type="date" CssClass="form-control" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                                            <div class="input-group">
                                <asp:TextBox ID="tbemail" placeholder="E-Mail" class="form-control" type="email" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                                            <div class="input-group">
                                <asp:TextBox ID="tbcinsiyet" placeholder="Cinsiyet E/K" class="form-control" type="text" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                                            <div class="input-group">
                                <asp:TextBox ID="tbsifre" placeholder="Şifrenizi Giriniz" class="form-control" type="password" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                                         <div class="input-group">
                                <asp:TextBox ID="tbkidem" placeholder="üst/alt" class="form-control" type="text" runat="server"></asp:TextBox>
                              <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                            </div>
                            </div>
                          </div>
                  <div class="form-actions form-group">
                             <asp:Button ID="Button1" CssClass="btn btn-secondary btn-sm" runat="server" Text="Ekle" OnClick="Button1_Click" />

                          </div>
                             <div class="form-actions form-group">

                          </div>
                         

                      </div>
                    </div>
                 </form>
                  </div>
</asp:Content>
