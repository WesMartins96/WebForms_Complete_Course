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
            //acessar os cookies do cliente
            lLogin.Text = "";
            if (Request.Cookies["login"] != null)
            {
                lLogin.Text = Request.Cookies["login"].Value;
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
    }
}