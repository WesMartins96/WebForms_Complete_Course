using Sistema_WEB_Frases.DAL;
using Sistema_WEB_Frases.MODELO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_WEB_Frases
{
    public partial class Autor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            DALAutor dal = new DALAutor();
            gvDados.DataSource = dal.Localizar();
            gvDados.DataBind();
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtAutor.Text = string.Empty;
            btnSalvar.Text = "Inserir";
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        { 
            try
            {
                string msg = "";
                DALAutor dal = new DALAutor();
                ModeloAutor obj = new ModeloAutor();
                string caminho = Server.MapPath(@"IMAGENS\AUTORES\");
                obj.Nome = txtAutor.Text;

                //faz o upload da foto e salva o nome do obj
                if (flFoto.PostedFile.FileName != "")
                {
                    obj.Foto = DateTime.Now.Millisecond.ToString() + flFoto.PostedFile.FileName;
                    string img = caminho + obj.Foto;
                    flFoto.PostedFile.SaveAs(img);
                }

                if (btnSalvar.Text == "Inserir")
                {
                    dal.Inserir(obj);
                    msg = "<script> alert('O código gerado foi:  " + obj.Id.ToString() + "') </script>";

                }
                else
                {
                    obj.Id = Convert.ToInt32(txtId.Text);
                    //verifica se existe foto e deleta
                    ModeloAutor upFoto = dal.GetRegistro(obj.Id);
                    if (upFoto.Foto != "")
                    {
                        File.Delete(caminho + upFoto.Foto);
                    }

                    dal.Alterar(obj);
                    msg = "<script> alert('Registro alterado com sucesso!') </script>";

                }
                Response.Write(msg);
                this.LimparCampos();
            }
            catch (Exception erro)
            {

                Response.Write("<script> alert('" + erro.Message + "') </script>");
            }
            AtualizaGrid();
            this.LimparCampos();

        }

        protected void gvDados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gvDados.Rows[index].Cells[2].Text);
            string caminho = Server.MapPath(@"IMAGENS\AUTORES\");

            DALAutor dal = new DALAutor();

            //verifica se existe foto e deleta
            ModeloAutor upFoto = dal.GetRegistro(cod);
            if (upFoto.Foto != "")
            {
                File.Delete(caminho + upFoto.Foto);
            }

            dal.Excluir(cod);
            this.LimparCampos();
            AtualizaGrid();
        }

        protected void gvDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = gvDados.SelectedIndex;
                int cod = Convert.ToInt32(gvDados.Rows[index].Cells[2].Text);
                DALAutor dal = new DALAutor();
                ModeloAutor autor = dal.GetRegistro(cod);
                if (autor.Id != 0)
                {
                    txtId.Text = autor.Id.ToString();
                    txtAutor.Text = autor.Nome;
                    btnSalvar.Text = "Alterar";
                }
            }
            catch
            {

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }
    }
}