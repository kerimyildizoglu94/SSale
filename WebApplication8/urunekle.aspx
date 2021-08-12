<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="urunekle.aspx.cs" Inherits="WebApplication8.urunekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <div class=" form-group">
                            
                           
                                <label for="select" class=" form-control-label">Kategori Seç ve Ürününü Ekle</label>
                                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" AutoPostBack="false" ></asp:DropDownList>

                           
                          </div>
                 <div class="input-group">
                   <asp:TextBox ID="tbad" placeholder="Ürün Adı" class="form-control" type="text" runat="server"></asp:TextBox>
                    <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                </div>
         <div class="input-group">
                   <asp:TextBox ID="tbbarkod" placeholder="Barkod Yazınız " class="form-control" type="number" runat="server"></asp:TextBox>
                    <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                </div>
         <div class="input-group">
                   <asp:TextBox ID="tbaciklama" placeholder="Açıklama yazınız" class="form-control" type="text" runat="server"></asp:TextBox>
                    <div class="input-group-addon"><i class="fa fa-asterisk"></i></div>
                </div>
        <asp:FileUpload ID="FileUpload1" CssClass="btn btn-primary" runat="server" BorderColor="Black" Height="40px"/>
        <asp:Button ID="kayitbutton" type="submit" CssClass="btn btn-primary btn-flat m-b-30 m-t-30" BorderColor="Black" runat="server" Text="Kayıt Et" OnClick="kayitbutton_Click" Height="40px" />
        <div>  
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        </div>
    </form>
</asp:Content>
