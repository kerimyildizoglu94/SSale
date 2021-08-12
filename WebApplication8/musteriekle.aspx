<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="musteriekle.aspx.cs" Inherits="WebApplication8.musteriekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <style>
                                     label{
                             color:black!important
                            }
                         </style>
       <div class="sufee-login d-flex align-content-center flex-wrap">
        <div class="container">
            <div class="login-content" style="margin-top:0;background-color:#698cbd">
             
                <div class="login-form" style="background-color:#698cbd;color:black;">
                    <form runat="server">
                        <div> <asp:Literal ID="Literal1" runat="server"></asp:Literal> </div>
                              
                        <div class="form-group">
                            <label>TC</label>
                             <asp:TextBox ID="tbmusteritc" type="text" CssClass="form-control" placeholder="Türkiye Cumhuriyeti Kimlik Numarası" runat="server"></asp:TextBox>

                        </div>
                        
                        
                        <div class="form-group">
                            <label>Müşteri Adı </label>
                             <asp:TextBox ID="tbmusteriadi" type="text" CssClass="form-control" placeholder="Müşteri adı" runat="server"></asp:TextBox>

                        </div>
                         <div class="form-group">
                            <label>Müşteri Soyadı </label>
                             <asp:TextBox ID="tbmusterisoyadi" type="text" CssClass="form-control" placeholder="Müşteri Soyadı" runat="server"></asp:TextBox>

                        </div>

                        <div class="form-group">
                            <label>Email address</label>
                           <asp:TextBox ID="tbmusterimail" type="email" CssClass="form-control" placeholder="Mail Adresini Alalım aslanım" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Adres</label>
                           <asp:TextBox ID="tbmusteriadres" type="text" CssClass="form-control" placeholder="Şehir/ İlçe / Cad -Sk / Binano/ Daire No:" runat="server"></asp:TextBox>
                        </div>
                         <div class="form-group">
                            <label>Tel NO </label>
                           <asp:TextBox ID="tbmusteritel" type="text" CssClass="form-control" placeholder="05**₺₺₺$$€€" runat="server"></asp:TextBox>
                        </div>
                         <div class="form-group">
                            <label>Doğum Tarihi </label>
                           <asp:TextBox ID="tbmusteridtarihi" type="date" CssClass="form-control" placeholder="Gün/Ay/Yıl" runat="server"></asp:TextBox>
                        </div>
                          <div class="form-group">
                            <label>Cinsiyet </label>
                           <asp:TextBox ID="tbmustericinsiyet" type="text" CssClass="form-control" placeholder="E/K" runat="server"></asp:TextBox>
                        </div>
                    
                        <asp:Button ID="kayitbutton" type="submit" CssClass="btn btn-primary btn-flat m-b-30 m-t-30"  runat="server" Text="Kayıt Et" OnClick="kayitbutton_Click"  />
                       
                      
                    </form>
                </div>
            </div>
        </div>
    </div>    
       
</asp:Content>
