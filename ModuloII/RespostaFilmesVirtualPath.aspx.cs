using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModuloII
{
    public partial class RespostaFilmesVirtualPath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage.Filmes != null)
            {
                //utilizando virtualPath
                List<string> Filmes = PreviousPage.Filmes;
                foreach (var filme in Filmes)
                {
                    Response.Write("<h3>" + filme + "</h3>");
                }
            }
        }
    }
}