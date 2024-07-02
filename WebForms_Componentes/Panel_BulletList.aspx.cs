using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Componentes
{
    public partial class Panel_BulletList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void blLista_Click(object sender, BulletedListEventArgs e)
        {
            pnParouImpar.Visible = false;
            pnFatorial.Visible = false;
            switch (e.Index)
            {
                case 0:
                    pnParouImpar.Visible = true;
                    break;
                case 1:
                    pnFatorial.Visible = true;
                    break;
                default:
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //verificar se é par ou impar
            int n = Convert.ToInt32(txtValorPn1.Text);
            string txt = "O número é par";
            if (n % 2 != 0)
            {
                txt = "O número é impar";
            }

            lResult1.Text = txt;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnParouImpar.Visible = false;
            pnFatorial.Visible = false;
            if (RadioButtonList1.SelectedIndex == 0)
            {
                pnParouImpar.Visible = true;
            }
            else
            {
                pnFatorial.Visible = true;
            }
            
        }
    }
}