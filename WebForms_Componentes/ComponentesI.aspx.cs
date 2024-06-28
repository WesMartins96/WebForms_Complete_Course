using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Componentes
{
    public partial class ComponentesI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            //ddlSite.Items.Add(txtSite.Text);

            ListItem item = new ListItem(txtSite.Text, ddlSite.Items.Count.ToString());
            ddlSite.Items.Add(item);
            txtSite.Text = string.Empty;

            item = new ListItem(txtEndereco.Text, lbEndereco.Items.Count.ToString());
            lbEndereco.Items.Add(item);
            txtEndereco.Text = string.Empty;

        }

        protected void btSelecionar_Click(object sender, EventArgs e)
        {

            ListItem item = ddlSite.SelectedItem;
            txtSite.Text = item.Text;
            item = lbEndereco.SelectedItem;
            txtEndereco.Text = item.Text;

        }
    }
}