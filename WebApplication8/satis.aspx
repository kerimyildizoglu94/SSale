<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="satis.aspx.cs" Inherits="WebApplication8.satis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server">

            <div>
                <asp:TextBox ID="TextBox1" type="text" CssClass="form-control" placeholder="Tc/Ad/Soyad/TelNo Göre Arama Yaz Enter Bas" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
            </div>


            <div style="text-align: center; width: 100%">
                <div style="display: inline-block; width: 100%">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>

                            <asp:BoundField DataField="id" HeaderText="MüşteriNo" />
                            <asp:BoundField DataField="tc" HeaderText="T.C" />
                            <asp:BoundField DataField="ad" HeaderText="Ad" />
                            <asp:BoundField DataField="soyad" HeaderText="Soyad" />
                            <asp:BoundField DataField="email" HeaderText="E-Mail" />
                            <asp:BoundField DataField="adres" HeaderText="Adres" />
                            <asp:BoundField DataField="telno" HeaderText="TelNo" />
                            <asp:BoundField DataField="dtarihi" HeaderText="DoğumTarihi" />
                            <asp:BoundField DataField="cinsiyet" HeaderText="Cinsiyet" />
                            <asp:CommandField ShowSelectButton="True" />

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
           

            <div>
                <asp:TextBox ID="TextBox2" type="text" CssClass="form-control" placeholder="Barkod/Ad Göre Arama Yaz Enter Bas" runat="server" OnTextChanged="TextBox2_TextChanged1" AutoPostBack="true"></asp:TextBox>
            </div>
           
            <div>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="Ürün No" />
                        <asp:BoundField DataField="ad" HeaderText="Ürün Adı" />
                        <asp:BoundField DataField="barkod" HeaderText="Ürün Barkod" />
                        <asp:BoundField DataField="satis_fiyati" HeaderText="Satiş Fıyatı" />
                        <asp:BoundField DataField="stok" HeaderText="Stok Adeti" />

                        <asp:CommandField ShowSelectButton="True" />
 

                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                </div>
            <div style="margin-top:20px;margin-bottom:20px">   <asp:Button ID="kaydet" runat="server" Text="Sepete Ekle"   OnClick="kaydet_Click" /> </div>
            <div> 
                 <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%" >
                    <Columns>
                        <asp:BoundField DataField="ad" HeaderText="Ürün Ad" />
                        <asp:BoundField DataField="barkod" HeaderText="Ürün Barkod" />
                      

                        <asp:CommandField ShowSelectButton="True" />
 

                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="DarkRed" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>

            </div>
            
            
 
            
            <div style="margin-top:20px;margin-bottom:20px">   <asp:Button ID="Button1" runat="server" Text="Sepete Git"  OnClick="Button1_Click1" Visible="false" /> </div>


        </form>


    </div>

</asp:Content>
