<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="kategoriduzenle.aspx.cs" Inherits="WebApplication8.kategoriduzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <form runat="server">
        <div>  <asp:Literal ID="Literal1" runat="server"></asp:Literal></div>
         <div> <asp:TextBox ID="TextBox1" type="text" CssClass="form-control" placeholder="Kategori Adına Göre Ara"  runat="server" OnTextChanged="TextBox1_TextChanged"  AutoPostBack="true"  ></asp:TextBox> </div>

       
        <div style="text-align:center;width:100%">   
            <div style="display:inline-block;width:100%">
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
               
                <asp:BoundField DataField="id" HeaderText="Kategori No"/>
                <asp:BoundField DataField="adi" HeaderText="Kategori Adı"/>
              
               
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
        <div> <asp:TextBox ID="tb1" type="text" CssClass="form-control" placeholder="Kategori No" runat="server"></asp:TextBox> </div>
        <div> <asp:TextBox ID="tb2" type="text" CssClass="form-control" placeholder="Kategori Adı" runat="server"></asp:TextBox> </div>
     <div>
            <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-warning btn-sm" OnClick="Button1_Click"/>
     </div>
       
    </form>
         
    </div>
</asp:Content>
