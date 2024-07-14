using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModuloII
{
    public partial class FilmesVirtualPath : System.Web.UI.Page
    {
        public List<string> Filmes { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserirFilme_Click(object sender, EventArgs e)
        {
            ddlFilmes.Items.Add(new ListItem(txtbFilmes.Text, txtbFilmes.Text));
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Filmes = new List<string>();
            foreach (ListItem item in ddlFilmes.Items)
            {
                Filmes.Add(item.Text);
            }
        }
    }
}