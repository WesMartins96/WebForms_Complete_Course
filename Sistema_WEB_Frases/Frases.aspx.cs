using Sistema_WEB_Frases.DAL;
using Sistema_WEB_Frases.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_WEB_Frases
{
    public partial class Frases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            if (!IsPostBack)
            {
                AtualizaCategoria();
                AtualizaAutor();
            }

        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtFrases.Text = string.Empty;
            btnSalvar.Text = "Inserir";
        }

        private void AtualizaGrid()
        {
            DALFrase dal = new DALFrase();
            gvDados.DataSource = dal.Localizar();
            gvDados.DataBind();
        }

        private void AtualizaAutor()
        {
            DALAutor dal = new DALAutor();
            ddlAutor.DataSource = dal.Localizar();
            ddlAutor.DataTextField = "nome";
            ddlAutor.DataValueField = "id";
            ddlAutor.DataBind();
        }

        private void AtualizaCategoria()
        {
            DALCategoria dal = new DALCategoria();
            ddlCategoria.DataSource = dal.Localizar();
            ddlCategoria.DataTextField = "categoria";
            ddlCategoria.DataValueField = "id";
            ddlCategoria.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            DALFrase dal = new DALFrase();
            ModeloFrase obj = new ModeloFrase();
            obj.Frase = txtFrases.Text;
            obj.Autor = Convert.ToInt32(ddlAutor.SelectedValue);
            obj.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue);

            try
            {
                if (btnSalvar.Text == "Inserir")
                {
                    dal.Inserir(obj);
                    msg = "<script> alert('O código gerado foi:  " + obj.Id.ToString() + "') </script>";

                }
                else
                {
                    obj.Id = Convert.ToInt32(txtId.Text);
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
        }

        protected void gvDados_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int index = gvDados.SelectedIndex;
                int cod = Convert.ToInt32(gvDados.Rows[index].Cells[2].Text);
                DALFrase dal = new DALFrase();
                ModeloFrase frase = dal.GetRegistro(cod);
                if (frase.Id != 0)
                {
                    txtId.Text = frase.Id.ToString();
                    txtFrases.Text = frase.Frase;
                    ddlAutor.SelectedValue = frase.Autor.ToString();
                    ddlCategoria.SelectedValue = frase.Categoria.ToString();
                    btnSalvar.Text = "Alterar";
                }
            }
            catch
            {

            }

        }

        protected void gvDados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gvDados.Rows[index].Cells[2].Text);
            DALFrase dal = new DALFrase();
            dal.Excluir(cod);
            this.LimparCampos();
            AtualizaGrid();
        }
    }
}