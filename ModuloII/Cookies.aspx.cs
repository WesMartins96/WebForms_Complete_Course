using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModuloII
{
    public partial class Cookies : System.Web.UI.Page
    {
        List<string> Usuarios;
        string senhaPadrao = "123456";

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios = new List<string>();
            Usuarios.Add("Wesley");
            Usuarios.Add("DevWes");
            Usuarios.Add("Teste");

            if (Request.Cookies["login"] != null)
            {
                //se tiver cookies vai direto para a pagina cookies2
                txtbLoginCookie.Text = Request.Cookies["login"].Value;
                txtbSenhaCookie.Text = Request.Cookies["senha"].Value;
                btnExecutarCookie_Click(sender, e);
            }
        }

        protected void btnExecutarCookie_Click(object sender, EventArgs e)
        {
            //bool flag = false;
            foreach (var item in Usuarios)
            {
                if (item == txtbLoginCookie.Text && senhaPadrao == txtbSenhaCookie.Text)
                {
                    //utilizando cookies para armazenar o login e senha do usuario no pc do mesmo.
                    HttpCookie login = new HttpCookie("login", txtbLoginCookie.Text);
                    Response.Cookies.Add(login);
                    Response.Cookies.Add(new HttpCookie("senha", txtbSenhaCookie.Text));

                    //Session
                    Session["login"] = txtbLoginCookie.Text;

                    Response.Redirect("~/Cookies2.aspx");
                }
            }
        }
    }
}