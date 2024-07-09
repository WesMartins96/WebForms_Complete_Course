using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataList
{
	public partial class DataList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnEnviarAoBanco_Click(object sender, EventArgs e)
        {
			//captura a string de conexão
			var rootWebConfig = WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
			ConnectionStringSettings connectionString;
			connectionString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
			//cria um objeto de conexão ao banco de dados
			SqlConnection con = new SqlConnection();
			con.ConnectionString = connectionString.ToString();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			//comando que será utilizado
			cmd.CommandText = "INSERT INTO Contato (Nome, Email) VALUES (@Nome, @Email)";
			//definir os parametros utilizados na query
			cmd.Parameters.AddWithValue("Nome", txtNome.Text);
			cmd.Parameters.AddWithValue("Email", txtEmail.Text);
			//abrir conexão
			con.Open();
			//executa o comando
			cmd.ExecuteNonQuery();
			//fecha a conexão
			con.Close();
			DataList1.DataBind();
        }
    }
}