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
    public partial class Contatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserirNovoContato_Click(object sender, EventArgs e)
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
			cmd.CommandText = "INSERT INTO Contato (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";
			//definir os parametros utilizados na query
			cmd.Parameters.AddWithValue("Nome", txtbNome.Text);
			cmd.Parameters.AddWithValue("Email", txtbEmail.Text);
			cmd.Parameters.AddWithValue("Telefone", txtbTelefone.Text);
			//abrir conexão
			con.Open();
			//executa o comando
			cmd.ExecuteNonQuery();
			//fecha a conexão
			con.Close();
			//Recarrega a GridView
			GridView1.DataBind();
		}
    }
}