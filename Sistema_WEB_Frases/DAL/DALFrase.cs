using Sistema_WEB_Frases.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.DAL
{
    public class DALFrase
    {
        private System.Configuration.ConnectionStringSettings connString;
        public DALFrase()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["sisfrasesConnectionString"];
        }
        public void Inserir(ModeloFrase obj)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = this.connString.ToString();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "Insert into frases (frase, autor, categoria) values (@frase, @autor, @categoria);select @@IDENTITY;";
                cmd.Parameters.AddWithValue("frase", obj.Frase);
                cmd.Parameters.AddWithValue("autor", obj.Autor);
                cmd.Parameters.AddWithValue("categoria", obj.Categoria);
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

        public void Alterar(ModeloFrase obj)
        {
            //cria um objeto de conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "update frases set frase=@frase, autor=@autor, categoria=@categoria where id = @id;";
                cmd.Parameters.AddWithValue("frase", obj.Frase);
                cmd.Parameters.AddWithValue("autor", obj.Autor);
                cmd.Parameters.AddWithValue("categoria", obj.Categoria);
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
                cmd.CommandText = "delete from frases where id = " + cod.ToString();
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
            string sql = @"SELECT f.id, f.frase, f.autor, f.categoria, a.nome as autornome, c.categoria as categorianome
                            FROM frases f 
                            INNER JOIN autores a ON f.autor = a.id
                            INNER JOIN categorias c ON f.categoria = c.id";

            SqlDataAdapter da = new SqlDataAdapter(sql, connString.ConnectionString);
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from frases where frase like '%" + valor + "%'", connString.ConnectionString);
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

        public ModeloFrase GetRegistro(int id)
        {
            ModeloFrase obj = new ModeloFrase();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from frases where id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    obj.Id = Convert.ToInt32(registro["id"]);
                    obj.Frase = Convert.ToString(registro["frase"]);
                    obj.Autor = Convert.ToInt32(registro["autor"]);
                    obj.Categoria = Convert.ToInt32(registro["categoria"]);
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