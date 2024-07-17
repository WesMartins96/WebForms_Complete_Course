using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModuloII
{
    public partial class Cookies2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                //acessar os cookies do cliente
                lLogin.Text = "";
                if (Request.Cookies["login"] != null)
                {
                    lLogin.Text = Request.Cookies["login"].Value;
                }
            }
            if (Session["login"] == null)
            {
                Response.Redirect("~/Cookies2.aspx");

            }
            else
            {
                lLogin.Text = Session["login"].ToString();
                if (Session["contador"] == null)
                {
                    Session["contador"] = 0;
                }

                txtbSessionID.Text = Session.SessionID.ToString();
                txtbContador.Text = Session["contador"].ToString();
            }

            if (Application["contador"] == null)
            {
                Application["contador"] = 0;
            }
            else
            {
                txtbContadorApplication.Text = Application["contador"].ToString();
            }
        }

        protected void btnExecutarCookie2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                //remove todos os cookies
                Request.Cookies.Clear();
                //remover um cookie pelo nome
                //Request.Cookies.Remove("login");
            }
        }

        protected void btnListarCookies_Click(object sender, EventArgs e)
        {
            var cookiesKeys = Request.Cookies.AllKeys;
            string texto = "<p>";
            string pos = "";
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                pos = cookiesKeys[i];
                texto += pos + ":" + Request.Cookies[pos].Value + " ";
            }
            texto += "</p>";
            Response.Write(texto);
        }

        protected void btnContador_Click(object sender, EventArgs e)
        {
            Session["contador"] = (int)Session["contador"] + 1;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            //remover um dado especifico
            Session.Remove("contador");

            //remover todos os valores da sessão
            //Session.Clear();

            //Cancela a sessão atual, finalizando a sessão
            //Session.Abandon();
        }

        protected void btnContadorApplication_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["contador"] = (int)Application["contador"] + 1;
            Application.UnLock();
        }

        protected void btnRemoveApplicationCount_Click(object sender, EventArgs e)
        {
            Application.Remove("contador");
        }
    }
}