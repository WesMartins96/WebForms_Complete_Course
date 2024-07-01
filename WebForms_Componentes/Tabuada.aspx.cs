using System;
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
            //lbDados.Items.Clear();
            ListItem li = ddlNumeros.SelectedItem;
            int n = Convert.ToInt32(li.Value);
            int resultado = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    resultado = i * n;
            //    lbDados.Items.Add(i.ToString() + "x" + n.ToString() + " = " + resultado.ToString());

            //    tbDados.Rows[i].Cells[0].Text = n.ToString();
            //    tbDados.Rows[i].Cells[4].Text = resultado.ToString();
            //}


            //Usando placeholder
            
            Table tabela = new Table();
            for (int i = 0; i <= 10; i++)
            {
                TableRow linha = new TableRow();
                //1° celula
                TableCell coluna = new TableCell();
                coluna.Text = n.ToString() + " X " + i.ToString() + " = ";
                linha.Cells.Add(coluna);

                //2° celula
                coluna = new TableCell();
                resultado = i * n;
                coluna.Text = resultado.ToString();
                linha.Cells.Add(coluna);

                tabela.Rows.Add(linha);
            }
            PlaceHolder.Controls.Add(tabela);
        }
    }
}