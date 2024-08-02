using Sistema_WEB_Frases.DAL;
using Sistema_WEB_Frases.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_WEB_Frases
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            string email = txtbLogin.Text;
            string senha = txtbSenha.Text;

            DALUsuario dalUsuario = new DALUsuario();
            ModeloUsuario usuario = dalUsuario.GetRegistro(email);
            if (email == usuario.Email && senha == usuario.Senha)
            {
                Session["id"] = usuario.Id;
                Session["nome"] = usuario.Nome;
                Session["email"] = email;

                Response.Redirect("~/Default.aspx");
            }
            else
            {
                string msg = "<script> alert('Login ou senha incorretos!')</script>";
                Response.Write(msg);
                txtbLogin.Text = string.Empty;
                txtbSenha.Text = string.Empty;
            }
        }
    }
}