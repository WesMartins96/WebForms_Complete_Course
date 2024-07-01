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

            ListItem item = new ListItem(txtSite.Text, txtEndereco.Text);

            lbEndereco.Items.Add(item);
            txtEndereco.Text = string.Empty;
            txtSite.Text = string.Empty;

        }

        protected void btSelecionar_Click(object sender, EventArgs e)
        {
            ddlSite.Items.Clear();
         
            //Pegar multiplos valores de uma list box e jogar em uma drop down list [Usando Foreach]
            foreach (ListItem item in lbEndereco.Items)
            {
                if (item.Selected)
                {
                    item.Selected = false;
                    ddlSite.Items.Add(item);
                }
            }


            //Pegar multiplos valores de uma list box e jogar em uma drop down list [Usando laço For]
            //ListItem li;
            //for (int i = 0; i < lbEndereco.Items.Count; i++)
            //{
            //    li = lbEndereco.Items[i];
            //    if (li.Selected)
            //    {
            //        li.Selected = false;
            //        ddlSite.Items.Add(li);
            //    }
            //}

        }
    }
}