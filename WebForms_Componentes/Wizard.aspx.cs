using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Componentes
{
    public partial class Wizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //varificação se é o primeiro carregamento no site
            if (!Page.IsPostBack)
            {
                Wizard1.ActiveStepIndex = 0;
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //podemos utilizar destas formas usando WizardSteps[].FindControl() ou igual na variavel bairro (mais fácil);
            var nome = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbNome")).Text;
            var cpf = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbCPF")).Text;
            var rg = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbRG")).Text;

            var cep = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbCEP")).Text;
            var cidade = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbCidade")).Text;
            var rua = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbRua")).Text;
            //var bairro = ((TextBox)Wizard1.WizardSteps[0].FindControl("txtbBairro")).Text;
            var bairro = txtbBairro.Text;

            Wizard1.Visible = false;
            Response.Write("<h1>Dados do formulário Wizard</h1>");
            Response.Write("<br/>");
            
            Response.Write("<h3>Dados Cadastrais</h3>");
            Response.Write("<hr/>");
            Response.Write("<p>Nome: " + nome + "</p>");
            Response.Write("<p>CPF: " + cpf + "</p>");
            Response.Write("<p>RG: " + rg + "</p>");

            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<h3>Endereço</h3>");
            Response.Write("<hr/>");
            Response.Write("<p>CEP: " + cep + "</p>");
            Response.Write("<p>Cidade: " + cidade + "</p>");
            Response.Write("<p>Rua: " + rua + "</p>");
            Response.Write("<p>Bairro: " + bairro + "</p>");



        }
    }
}