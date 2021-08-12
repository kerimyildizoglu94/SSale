<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="personelduzenle.aspx.cs" Inherits="WebApplication8.personelduzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server">
        <div>  <asp:Literal ID="Literal1" runat="server"></asp:Literal></div>
         <div> <asp:TextBox ID="TextBox1" type="text" CssClass="form-control" placeholder="Tc/Ad/Soyad/ Göre Arama Yaz Enter Bas" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"  ></asp:TextBox> </div>

       
    <div style="text-align:center;width:100%">   
            <div style="display:inline-block;width:100%">
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
               
                    <asp:BoundField DataField="id" HeaderText="PersonelNo"   />
                    <asp:BoundField DataField="ad" HeaderText="Ad"   />
                    <asp:BoundField DataField="soyad" HeaderText="Soyad"   />
                    <asp:BoundField DataField="tc" HeaderText="T.C" />
                    <asp:BoundField DataField="dtarihi" HeaderText="Doğum Tarihi" />
                    <asp:BoundField DataField="email" HeaderText="E-Mail" />
                    <asp:BoundField DataField="cinsiyet" HeaderText="Cinsiyet" />
                    <asp:BoundField DataField="sifre" HeaderText="Şifre" />
                    <asp:BoundField DataField="kidem" HeaderText="Kıdem" />
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
    <div
        <div> <asp:TextBox ID="tb1" type="text" CssClass="form-control" placeholder="Personel Adı" runat="server"></asp:TextBox> </div>
        <div> <asp:TextBox ID="tb2" type="text" CssClass="form-control" placeholder="Personel Soyadı" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb3" type="text" CssClass="form-control" placeholder="Personel Tc" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb4" type="text" CssClass="form-control" placeholder="Personel Doğum Tarihi" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb5" type="text" CssClass="form-control" placeholder="Personel E-Mail" runat="server" ></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb6" type="text" CssClass="form-control" placeholder="Personel Cinsiyet E/K" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb7" type="text" CssClass="form-control" placeholder="Personel Şifre" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb8" type="text" CssClass="form-control" placeholder="Personel Kıdem" runat="server"></asp:TextBox> </div>
         <div>
       </div>
          
            <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-warning btn-sm" OnClick="Button1_Click"/>
     
        </div>
       
    </form>
         
    </div>
</asp:Content>
