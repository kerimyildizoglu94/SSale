<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="duyuru.aspx.cs" Inherits="WebApplication8.duyuru" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <div class="form-group">
                            <label>Başlık</label>
                           <asp:TextBox ID="tb1" type="text" CssClass="form-control" placeholder="Başlık" runat="server"></asp:TextBox>
                        </div>
        <div class="form-group">
                            <label>İçerik</label>
                           <asp:TextBox ID="tb2" type="text" CssClass="form-control" placeholder="İçerik giriniz" runat="server"></asp:TextBox>
                        </div>
        
        <asp:Button ID="Button1" runat="server" Text="ekle" OnClick="Button1_Click" />

    </form>
   

</asp:Content>
