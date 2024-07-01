using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Componentes
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar2.SelectedDate = DateTime.Now;
        }

        protected void btnCalcularDias_Click(object sender, EventArgs e)
        {
            

            int diaNascimento = 0, mesNascimento = 0, anoNascimento = 0;
            int diaAtual = 0, mesAtual = 0, anoAtual = 0;

            diaNascimento = Calendar1.SelectedDate.Day;
            mesNascimento = Calendar1.SelectedDate.Month * 30;
            anoNascimento = Calendar1.SelectedDate.Year * 365;

            diaAtual = Calendar2.SelectedDate.Day;
            mesAtual = Calendar2.SelectedDate.Month * 30;
            anoAtual = Calendar2.SelectedDate.Year * 365;

            int total = (diaAtual + mesAtual + anoAtual) - (diaNascimento + mesNascimento + anoNascimento);

            lbResultadoDias.Text = "Dias de Vida: " + total.ToString();
        }
    }
}