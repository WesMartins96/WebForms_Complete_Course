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
    public partial class PaginaMestre : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                //Response.Redirect("~/Login.aspx");
            }
        }
    }
}