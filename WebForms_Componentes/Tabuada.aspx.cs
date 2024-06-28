﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Componentes
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i <= 10; i++)
                {
                    ddlNumeros.Items.Add(i.ToString());
                }
            }

        }

        protected void btExecutar_Click(object sender, EventArgs e)
        {
            lbDados.Items.Clear();
            ListItem li = ddlNumeros.SelectedItem;
            int n = Convert.ToInt32(li.Value);
            int resultado = 0;
            for (int i = 0; i <= 10; i++)
            {
                resultado = i * n;
                lbDados.Items.Add(i.ToString() + "x" + n.ToString() + " = " + resultado.ToString());
            }
        }
    }
}