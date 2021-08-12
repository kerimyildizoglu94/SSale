<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="enson.aspx.cs" Inherits="WebApplication8.enson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <form runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="100%">
        <Columns>
            <asp:BoundField DataField="ad" HeaderText="Ad"   />
            <asp:BoundField DataField="soyad" HeaderText="Ad"   />
            <asp:BoundField DataField="ad1" HeaderText="Ürün Adı"   />
            <asp:BoundField DataField="miktar" HeaderText="Ürün Miktarı"   />
            <asp:BoundField DataField="alisfiyati" HeaderText="Adet Fiyatı"   />
            <asp:BoundField DataField="totalfiyat" HeaderText="Toplam Fiyat"   />
            <asp:BoundField DataField="satinalmatarihi" HeaderText="SatinAlmaTarihi"   />
     
  
</Columns>
    </asp:GridView>
      
       <div > 
       <asp:Button ID="Button1" runat="server" Text="İndex'e git"  OnClick="Button1_Click"/> </div>
        </form>
</asp:Content>
