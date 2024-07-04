using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadArquivos
{
    public partial class UploadArquivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nomeArquivo = fuArquivos.FileName;
            txtbNomeArquivo.Text = nomeArquivo;

            txtbTamanhoArquivo.Text = fuArquivos.PostedFile.ContentLength.ToString();

            //variavel fileName é o caminho da pasta onde eu irei enviar o arquivo
            string fileName = @"C:\Users\wesley_lopes\Desktop\Codigos_Cursos\WebForms_Course\WebForms_Course\UploadArquivos\upload\" + nomeArquivo;
            fuArquivos.PostedFile.SaveAs(fileName);
        }
    }
}