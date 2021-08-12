<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true"  CodeBehind="musteriduzenle.aspx.cs" Inherits="WebApplication8.musteriduzenle" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server">
        <div>  <asp:Literal ID="Literal1" runat="server"></asp:Literal></div>
         <div> <asp:TextBox ID="TextBox1" type="text" CssClass="form-control" placeholder="Tc/Ad/Soyad/TelNo Göre Arama Yaz Enter Bas" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"  ></asp:TextBox> </div>

       
        <div style="text-align:center;width:100%">   
            <div style="display:inline-block;width:100%">
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
               
                <asp:BoundField DataField="id" HeaderText="MüşteriNo"   />
                <asp:BoundField DataField="tc" HeaderText="T.C"   />
                <asp:BoundField DataField="ad" HeaderText="Ad"   />
                <asp:BoundField DataField="soyad" HeaderText="Soyad"   />
                <asp:BoundField DataField="email" HeaderText="E-Mail" />
                <asp:BoundField DataField="adres" HeaderText="Adres" />
                <asp:BoundField DataField="telno" HeaderText="TelNo" />
                <asp:BoundField DataField="dtarihi" HeaderText="DoğumTarihi" />
                <asp:BoundField DataField="cinsiyet" HeaderText="Cinsiyet" />
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
        <div> <asp:TextBox ID="tb1" type="text" CssClass="form-control" placeholder="T.C" runat="server"></asp:TextBox> </div>
        <div> <asp:TextBox ID="tb2" type="text" CssClass="form-control" placeholder="Müşteri adı" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb3" type="text" CssClass="form-control" placeholder="Müşteri Soyadı" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb4" type="text" CssClass="form-control" placeholder="E-Mail" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb5" type="text" CssClass="form-control" placeholder="Adres" runat="server" ></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb6" type="text" CssClass="form-control" placeholder="Tel-No" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb7" type="text" CssClass="form-control" placeholder="Doğum Tarihi YY/AA/GG" runat="server"></asp:TextBox> </div>
         <div> <asp:TextBox ID="tb8" type="text" CssClass="form-control" placeholder="E/K" runat="server"></asp:TextBox> </div>
        <div>
          
            <asp:Button ID="Button1" runat="server" Text="Button"  CssClass="btn btn-warning btn-sm" OnClick="Button1_Click"/>
     
        </div>

       

        

    </form>
         
    </div>
</asp:Content>
