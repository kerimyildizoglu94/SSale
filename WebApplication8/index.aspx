<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication8.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
          <div class="content mt-3">


          <asp:Literal ID="Literal1" runat="server"></asp:Literal>
           <div class="col-sm-6 col-lg-3">
                <div class="card text-white bg-flat-color-1">
                    <div class="card-body pb-0">
                       
                        <h4 class="mb-0">
                            <span class="count"> <%Response.Write(calisansayisi); %></span>
                        </h4>
                        <p class="text-light"> Kayıtlı personel</p>

                        

                    </div>

                </div>
            </div>
            <!--/.col-->

            <div class="col-sm-6 col-lg-3">
                <div class="card text-white bg-flat-color-2">
                    <div class="card-body pb-0">
                       
                        <h4 class="mb-0">
                            <span class="count"><%Response.Write(kayıtlımüsteri); %></span>
                        </h4>
                        <p class="text-light">Kayıtlı Müşteri</p>

                        

                    </div>
                </div>
            </div>
            <!--/.col-->

            <div class="col-sm-6 col-lg-3">
                <div class="card text-white bg-flat-color-3">
                    <div class="card-body pb-0">
                        <div class="dropdown float-right">
                            
                        </div>
                        <h4 class="mb-0">
                            <span class="count"><%Response.Write(urunsayisi); %></span>
                        </h4>
                        <p class="text-light">Kayıtlı Ürünler </p>

                    </div>

                       
                </div>
            </div>
            <!--/.col-->

            <div class="col-sm-6 col-lg-3">
                <div class="card text-white bg-flat-color-4">
                    <div class="card-body pb-0">
                       
                        <h4 class="mb-0">
                            <span class="count"><%Response.Write(katagorisayisi); %></span>
                        </h4>
                        <p class="text-light">Kategori Sayısı</p>

                    

                    </div>
                </div>
            </div>
            <!--/.col--> 

        

        

            <div class="col-xl-6 col-lg-6">
                <div class="card">
                    <div class="card-body">
                        <div class="stat-widget-one">
                            <div class="stat-icon dib"><i class="ti-money text-success border-success"></i></div>
                            <div class="stat-content dib">
                                <div class="stat-text">DOLAR </div>
                                <div class="stat-digit"><%Response.Write(Dolar); %></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            


            <div class="col-xl-6 col-lg-6">
                <div class="card">
                    <div class="card-body">
                        <div class="stat-widget-one">
                            <div class="stat-icon dib"><i class="ti-user text-primary border-primary"></i></div>
                            <div class="stat-content dib">
                                <div class="stat-text">Aktif Kullancı </div>
                                <div class="stat-digit"><%Response.Write(Application["OU"].ToString()); %></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>  <div class="col-xl-6 col-lg-6">
                <div class="card">
                    <div class="card-body">
                        <div class="stat-widget-one">
                            <div class="stat-icon dib"><i class="ti-user text-primary border-primary"></i></div>
                            <div class="stat-content dib">
                                <div class="stat-text">Toplam Ziyaretçi </div>
                                <div class="stat-digit"><%Response.Write(toplamziyaretci); %></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-xl-6 col-lg-6">
                <div class="card">
                    <div class="card-body">
                        <div class="stat-widget-one">
                            <div class="stat-icon dib"><i class="ti-layout-grid2 text-warning border-warning"></i></div>
                            <div class="stat-content dib">
                                <div class="stat-text">Aktif Ürün Sayısı</div>
                                <div class="stat-digit"><%Response.Write(aktif); %></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
              </div>
          
          <div style="border:solid;border-color:red;width:400px;height:380px;float:right;margin-right:38px; ">

            <div style="text-align:center;font-size:large"> Duyurular </div>
              <marquee  padding-left="20px";padding-right="20px" onmouseover="this.stop();" onmouseout="this.start();" scrollamount="1" height="85%" width="100%" direction="up"> 
                  <asp:Literal ID="duyuru" runat="server"></asp:Literal>                 
           </marquee>
        </div>

          
            <div class="col-xl-6 col-lg-12">
                 
               <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
              <div class="carousel-inner">
                <div class="carousel-item active">
                  <img class="d-block w-100" src="/images2/thumbnails/801.jpg" alt="First slide">
                </div>
                <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/802.jpg" alt="Second slide">
                </div>
                <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/803.jpg" alt="Third slide">  
              </div>
                   <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/901.jpg" alt="sixth slide">  
              </div>
               <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/902.jpg" alt="sevent slide">  
              </div>
                   <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/903.jpg" alt="eighth slide">  
              </div>
                   <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/904.jpg" alt="ninth slide">  
              </div>
                   <div class="carousel-item">
                  <img class="d-block w-100" src="/images2/thumbnails/905.jpg" alt="tenth slide">  
              </div>

              <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
              </a>
              <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
              </a>
            </div>
    
            <div>
                <asp:Menu ID="Menu1" runat="server" DataSourceid="SiteMapDataSource1"></asp:Menu>
                <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server"/>
          </div>
             


<!-- .content -->
      </form>
</asp:Content>
