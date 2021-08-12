using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication8
{
    public partial class satinalinan : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        SqlCommand komut = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["musteriid"] == null)
            { Response.Redirect("login.aspx"); return;
            }
            uzun_eksilt();
            urun_arttir();
            fonk();
            toplam_fiat();
           
          
        }
        void urun_arttir()
        {
            if (Request.QueryString["urunarttir"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["urunarttir"].ToString());
                con.Open();
                komut.Connection = con;
                komut.CommandText = "Select * from sepet where id= "+id;
                komut.ExecuteNonQuery();
                SqlDataReader dr1 = komut.ExecuteReader();
                if (dr1.Read())
                {
                    Session["adet"] = dr1["miktar"].ToString();
                    Session["top_fiyat"] = dr1["totalfiyat"].ToString();
                    Session["adet_fiyat"] = dr1["alisfiyati"].ToString();
                }
                int adet = int.Parse(Session["adet"].ToString());
                adet++;
                int toplamfiyat = int.Parse(Session["top_fiyat"].ToString())+ int.Parse( Session["adet_fiyat"].ToString());
                string guncel = "Update sepet set miktar = @miktar,totalfiyat=@totalfiyat Where id = @id";
                SqlCommand guncelle = new SqlCommand(guncel, con);
                guncelle.Parameters.AddWithValue("@id", Convert.ToInt32(Request.QueryString["urunarttir"].ToString()));
                guncelle.Parameters.AddWithValue("@miktar", adet);
                guncelle.Parameters.AddWithValue("@totalfiyat", toplamfiyat);
                con.Close();
                con.Open();
                guncelle.ExecuteNonQuery();
                con.Close();

                
            }
        }

        void uzun_eksilt()
        {
            if (Request.QueryString["uruneksilt"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["uruneksilt"].ToString());
                con.Open();
                komut.Connection = con;
                komut.CommandText = "Select * from sepet where id= " + id;
                komut.ExecuteNonQuery();
                SqlDataReader dr1 = komut.ExecuteReader();
                if (dr1.Read())
                {
                    Session["adet"] = dr1["miktar"].ToString();
                    Session["top_fiyat"] = dr1["totalfiyat"].ToString();
                    Session["adet_fiyat"] = dr1["alisfiyati"].ToString();
                }
                int adet = int.Parse(Session["adet"].ToString());
                adet--;
                int toplamfiyat = int.Parse(Session["top_fiyat"].ToString()) - int.Parse(Session["adet_fiyat"].ToString());
                string guncel = "Update sepet set miktar = @miktar,totalfiyat=@totalfiyat Where id = @id";
                SqlCommand guncelle = new SqlCommand(guncel, con);
                guncelle.Parameters.AddWithValue("@id", Convert.ToInt32(Request.QueryString["uruneksilt"].ToString()));
                guncelle.Parameters.AddWithValue("@miktar", adet);
                guncelle.Parameters.AddWithValue("@totalfiyat", toplamfiyat);
                con.Close();
                con.Open();
                guncelle.ExecuteNonQuery();
                con.Close();

            }

          }
        void toplam_fiat()
        {
           
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select sum(totalfiyat) as total From sepet where  sepet.musteri_id=" +Convert.ToInt32(Session["musteriid"].ToString()) + "", con);
            da.Fill(ds, "sepet");
            Literal2.Text = ds.Tables[0].Rows[0]["total"].ToString() + ".TL";

        }
       
        void fonk()
        {
            int musteri_id;
            if (Session["musteriid"] != null)
            {
                musteri_id = Convert.ToInt32(Session["musteriid"].ToString());
            }
            else musteri_id = 11;


            con.Open();
            string st = "select *from sepet ,urun where urun.id=sepet.urun_id and musteri_id="+musteri_id;
            SqlDataAdapter da = new SqlDataAdapter(st, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sepet");
           for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      
            {

                Literal1.Text += "<tr><td><div class='media'><div class='d-flex'></div><div class='media-body'><p> "+ ds.Tables[0].Rows[i]["ad"].ToString() +" </p></div></td>"+
    "<td><h5>"+ ds.Tables[0].Rows[i]["alisfiyati"].ToString() +"</h5></td><td><div class='product_count'><input type = 'text' name='qty' id='sst' maxlength='12' value="+ ds.Tables[0].Rows[i]["miktar"].ToString() +" title='Quantity:'class='input-text qty'><a class='lnr lnr-chevron-up' href='/satinalinan.aspx?urunarttir=" + ds.Tables[0].Rows[i]["id"].ToString() + "' >  </a><a class='lnr lnr-chevron-down' href='/satinalinan.aspx?uruneksilt=" + ds.Tables[0].Rows[i]["id"].ToString() + "' > </a></div></td><td><h5>" + ds.Tables[0].Rows[i]["totalfiyat"].ToString() + "</h5></td></tr>";
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("enson.aspx");
        }
    }
}