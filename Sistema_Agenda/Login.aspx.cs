using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Agenda
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtbEmailLogin.Text;
            string senha = txtbSenhaLogin.Text;

			//captura a string de conexão
			var rootWebConfig = WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
			ConnectionStringSettings connectionString;
			connectionString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
			//cria um objeto de conexão ao banco de dados
			SqlConnection con = new SqlConnection();
			con.ConnectionString = connectionString.ToString();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			//comando que será utilizado para verificar se contem no banco os dados email e senha
			cmd.CommandText = "SELECT * FROM Usuario WHERE Email = @Email AND Senha = @Senha";
			//definir os parametros utilizados na query
			cmd.Parameters.AddWithValue("Email", txtbEmailLogin.Text);
			cmd.Parameters.AddWithValue("Senha", txtbSenhaLogin.Text);
			//abrir conexão
			con.Open();
			//retorna os registros
			SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
				//Direcionar para a pagina principal
				Response.Redirect("~/Index.aspx");
            }
            else
            {
				lMsg.Text = "Email ou Senha incorretos!";
            }

		}
    }
}