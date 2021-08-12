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
    public partial class urunduzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        int id = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            gunc();

            if (!IsPostBack)
            {
                combola();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            sqlupdate();
            gunc();

        }
        public void gunc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from urun order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


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
        public void textdoldur()
        {
            tb1.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[1].Text);
            tb2.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[2].Text);
            tb6.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[3].Text);
       //     tb7.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[7].Text);

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
            Session["id"] = id.ToString();
            textdoldur();




        }
        public void sqlupdate()
        {
            int id = int.Parse(Session["id"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE urun SET ad=@ad,barkod=@barkod,aciklama=@aciklama,kat_id=@kat_id where id=" + id, con);

            cmd.Parameters.AddWithValue("@ad", tb1.Text);
            cmd.Parameters.AddWithValue("@barkod", tb2.Text);
            cmd.Parameters.AddWithValue("@aciklama", tb6.Text);
            cmd.Parameters.AddWithValue("@kat_id",DropDownList1.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();

            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı Güncelleme</span>  Ürün  Güncellendi  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from urun where ad like '%" + TextBox1.Text + "%' or barkod like'%" + TextBox1.Text + "%' ", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Session["id"] != null)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("DELETE FROM urun WHERE id = " + Convert.ToInt32(Session["id"].ToString()), con);
                cmd1.ExecuteNonQuery();
                con.Close();
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarılı</span> Ürün Silindi <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
                gunc();
            }
            else
            {
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Başarısız </span> Lütfen Seçim Yapınız <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}