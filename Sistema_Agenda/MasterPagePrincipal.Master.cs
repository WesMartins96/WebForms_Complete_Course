using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Agenda
{
    public partial class MasterPagePrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //só navega no site se o usuário fizer login
            if (Request.Cookies["Login"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}