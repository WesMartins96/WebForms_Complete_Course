using Sistema_WEB_Frases.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.DAL
{
    public class DALUsuario
    {
        private System.Configuration.ConnectionStringSettings connString;
        public DALUsuario()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["sisfrasesConnectionString"];
        }

        public void Inserir(ModeloUsuario obj)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = this.connString.ToString();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "Insert into usuarios (nome, email, senha) values (@nome, @email, @senha);select @@IDENTITY;";
                cmd.Parameters.AddWithValue("nome", obj.Nome);
                cmd.Parameters.AddWithValue("email", obj.Email);
                cmd.Parameters.AddWithValue("senha", obj.Senha);
                con.Open();
                obj.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Alterar(ModeloUsuario obj)
        {
            //cria um objeto de conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "update usuarios set nome=@nome, email=@email, senha=@senha where id = @id;";
                cmd.Parameters.AddWithValue("nome", obj.Nome);
                cmd.Parameters.AddWithValue("email", obj.Email);
                cmd.Parameters.AddWithValue("senha", obj.Senha);
                cmd.Parameters.AddWithValue("id", obj.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Excluir(int cod)
        {
            //cria um objeto de conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "delete from usuarios where id = " + cod.ToString();
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuarios", connString.ConnectionString);
            try
            {
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuarios where nome like '%" + valor + "%'", connString.ConnectionString);
            try
            {
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public ModeloUsuario GetRegistro(int id)
        {
            ModeloUsuario obj = new ModeloUsuario();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from usuarios where id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Nome = Convert.ToString(registro["nome"]);
                    obj.Email = Convert.ToString(registro["email"]);
                    obj.Senha = Convert.ToString(registro["senha"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            return obj;
        }
    }
}