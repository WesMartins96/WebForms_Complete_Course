using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModuloII
{
    public partial class RespostaSalarioMinimo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
            if (Request["txtbSalario"] == null)
            {
                Response.Redirect("~/FormSalarioMinimo.aspx");
            }
            else
            {
                double salarioBruto = Convert.ToDouble(Request.Form["txtbSalario"]);
                double porcentagem = Convert.ToDouble(Request.Form["txtbDesconto"]);

                double desconto = (salarioBruto * porcentagem) / 100;
                double salario = salarioBruto - desconto;

                Table tabela = new Table();
                //Salario Bruto
                TableRow linha = new TableRow();
                //Texto
                TableCell coluna = new TableCell();
                coluna.Text = "Salário Bruto: ";
                linha.Cells.Add(coluna);
                //Valor
                coluna = new TableCell();
                coluna.Text = salarioBruto.ToString("C");
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);

                //Percentual de Desconto
                linha = new TableRow();
                //Texto
                coluna = new TableCell();
                coluna.Text = "Percentual de Desconto: ";
                linha.Cells.Add(coluna);
                //Valor
                coluna = new TableCell();
                coluna.Text = $"{porcentagem.ToString()}%";
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);

                //Salario Liquido
                linha = new TableRow();
                //Texto
                coluna = new TableCell();
                coluna.Text = "Salário Liquido: ";
                linha.Cells.Add(coluna);
                //Valor
                coluna = new TableCell();
                coluna.Text = salario.ToString("C");
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);

                PlaceHolder1.Controls.Add(tabela);
            }
            
            //Pegando um objeto de outro formulario, usando Request
            //Response.Write("<h3> txtbSalario: "+ Request.Form["txtbSalario"] +" </h3>");
            //Response.Write("<h3> txtbDesconto: "+ Request.Form["txtbDesconto"] +" </h3>");
        }
    }
}