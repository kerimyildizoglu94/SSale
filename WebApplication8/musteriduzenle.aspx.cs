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
    public partial class musteriduzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-B69UVIS\\SQLEXPRESS;Database=web;Trusted_Connection=True;");
        int id = -1;
       
        public void gunc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from musteri order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        void sil()
        {
            if (id != -1)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM musteri WHERE Name = " + id, con);
                con.Close(); }
            else {
                Response.Write("Hata");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            gunc();
        }

        public void textdoldur()
        {
            tb1.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[1].Text);
            tb2.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[2].Text);
            tb3.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[3].Text);
            tb4.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[4].Text);
            tb5.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[5].Text);
            tb6.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[6].Text);
            tb7.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[7].Text);
            tb8.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[8].Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
                Session["id"] = id.ToString();
                textdoldur();
            
     


        }
        public void sqlupdate()
        {
            int id =int.Parse( Session["id"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE musteri SET tc=@tc,ad=@ad,soyad=@soyad,email=@email,adres=@adres,telno=@telno,dtarihi=@dtarihi,cinsiyet=@cinsiyet where id="+ id, con);

            cmd.Parameters.AddWithValue("@tc", tb1.Text);
            cmd.Parameters.AddWithValue("@ad", tb2.Text);
            cmd.Parameters.AddWithValue("@soyad", tb3.Text);
            cmd.Parameters.AddWithValue("@email", tb4.Text);
            cmd.Parameters.AddWithValue("@adres", tb5.Text);
            cmd.Parameters.AddWithValue("@telno", tb6.Text);
            cmd.Parameters.AddWithValue("@dtarihi", tb7.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", tb8.Text);
            cmd.ExecuteNonQuery();
            con.Close();
         
            Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Success</span> Güncellendi  <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Session["id"] != null)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("DELETE FROM musteri WHERE id = " + Convert.ToInt32(Session["id"].ToString()), con);
                cmd1.ExecuteNonQuery();
                con.Close();
                Literal1.Text = "<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Success</span> Silindi <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
                gunc();
            }
            else {
                Literal1.Text ="<div class='col-sm-12'><div class='alert  alert-success alert-dismissible fade show' role='alert'><span class='badge badge-pill badge-success'>Success</span> Lütfen Seçim Yapınız <button type = 'button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button></div></div>";
                    }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sqlupdate();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from musteri where tc like '%"+TextBox1.Text+ "%' or ad like'%" + TextBox1.Text + "%'  or soyad like'%" + TextBox1.Text + "%' or telno like '%" + TextBox1.Text + "%'", con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
    }
}