<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="satinalinan.aspx.cs" Inherits="WebApplication8.satinalinan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="icon" href="shop/img/Fevicon.png" type="image/png"/>
  <link rel="stylesheet" href="shop/vendors/bootstrap/bootstrap.min.css"/>
  <link rel="stylesheet" href="shop/vendors/fontawesome/css/all.min.css"/>
	<link rel="stylesheet" href="shop/vendors/themify-icons/themify-icons.css"/>
	<link rel="stylesheet" href="shop/vendors/linericon/style.css"/>
  <link rel="stylesheet" href="shop/vendors/owl-carousel/owl.theme.default.min.css"/>
  <link rel="stylesheet" href="shop/vendors/owl-carousel/owl.carousel.min.css"/>
  <link rel="stylesheet" href="shop/vendors/nice-select/nice-select.css"/>
  <link rel="stylesheet" href="shop/vendors/nouislider/nouislider.min.css"/>
  <link rel="stylesheet" href="shop/css/style.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <section class="cart_area">
      <div class="container">
          <div class="cart_inner">
              <div class="table-responsive">
                  <table class="table">
                      <thead>
                          <tr>
                              <th scope="col">Ürün</th>
                              <th scope="col">Fiyatı</th>
                              <th scope="col">Adeti</th>
                              <th scope="col">Toplam Fiyat</th>
                          </tr>
                      </thead>
                      <tbody>
                          
                          <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                      
                          <tr class="bottom_button">
                              <td>
                                
                              </td>
                              <td>

                              </td>
                              <td>

                              </td>
                              <td>
                                  <div class="cupon_text d-flex align-items-center">
                                     
                                      
                                      <asp:Button ID="Button1" runat="server" CssClass="cupon_area" Text="Onayla" OnClick="Button1_Click" />

                                  
                                  </div>
                              </td>
                          </tr>
                          <tr>
                              <td>

                              </td>
                              <td>

                              </td>
                              <td>
                                  <h5> Sepet Toplam Fiyat</h5>
                              </td>
                              <td>
                                  <h5>
                                      <asp:Literal ID="Literal2" runat="server"></asp:Literal></h5>
                              </td>
                          </tr>
                          
                      </tbody>
                  </table>
              </div>
          </div>
      </div>
  </section>
    </div>
    </form>
</body>
</html>
