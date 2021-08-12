<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="urunduzenle.aspx.cs" Inherits="WebApplication8.urunduzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container">
        <form runat="server">
        <div>  <asp:Literal ID="Literal1" runat="server"></asp:Literal></div>
         <div> <asp:TextBox ID="TextBox1" type="text" CssClass="form-control" placeholder="Barkod ve Ad Göre Arama"  runat="server" OnTextChanged="TextBox1_TextChanged"  AutoPostBack="true"  ></asp:TextBox> </div>

       
        <div style="text-align:center;width:100%">   
            <div style="display:inline-block;width:100%">
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
               
                <asp:BoundField DataField="id" HeaderText="Ürün No"/>
                <asp:BoundField DataField="ad" HeaderText="Ad"/>
                <asp:BoundField DataField="barkod" HeaderText="Barkod"/>
                <asp:BoundField DataField="aciklama" HeaderText="Açıklama" />
                <asp:BoundField DataField="kat_id" HeaderText="Kategori No" />
               
                 <asp:CommandField ShowSelectButton="True"/>
                <asp:CommandField ShowDeleteButton="True" />

            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
             </div>
            </div>
        <div> <asp:TextBox ID="tb1" type="text" CssClass="form-control" placeholder="Ürün Adı" runat="server"></asp:TextBox> </div>
        <div> <asp:TextBox ID="tb2" type="text" CssClass="form-control" placeholder="Ürün Barkod" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb6" type="text" CssClass="form-control" placeholder="Açıklama" runat="server"></asp:TextBox> </div>
         
            <div>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="false"></asp:DropDownList>
            </div>
        
             <div>
          
            <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-warning btn-sm" OnClick="Button1_Click"/>
     
        </div>
       
    </form>
         
    </div>
</asp:Content>
