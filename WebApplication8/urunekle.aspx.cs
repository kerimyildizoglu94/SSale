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
    public partial class urunekle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                combola();
            }
         
        }
        public void combola()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from kategori ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "adi";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            con.Close();

        }
        protected void kayitbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sq = "Select * from urun where barkod=@barkod";
            SqlCommand control = new SqlCommand(sq, con);
            control.Parameters.AddWithValue("@barkod", tbbarkod.Text);
            SqlDataReader say = control.ExecuteReader();
            if (say.Read())
            {
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Success</span>" + tbbarkod.Text + "Veritabanında Kayıtlı" + "  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
                return;
            }
            say.Close();
            SqlCommand cmd = new SqlCommand("insert into urun (ad,barkod,aciklama,kat_id) values (@ad,@barkod,@aciklama,@kat_id)", con);
            cmd.Parameters.AddWithValue("@ad", tbad.Text);
            cmd.Parameters.AddWithValue("@barkod", tbbarkod.Text);
            cmd.Parameters.AddWithValue("@aciklama", tbaciklama.Text);
            cmd.Parameters.AddWithValue("@kat_id", DropDownList1.SelectedValue);
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("/urunresim/") + tbbarkod.Text.ToString() + ".jpg");
            }
            cmd.ExecuteNonQuery();

            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı </span>Kayıt Yapıldı  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
            con.Close();
        }
    }
}