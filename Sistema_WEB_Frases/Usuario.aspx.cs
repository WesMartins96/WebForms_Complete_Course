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
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            btnSalvar.Text = "Inserir";
        }

        private void AtualizaGrid()
        {
            DALUsuario dal = new DALUsuario();
            gvDados.DataSource = dal.Localizar();
            gvDados.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            DALUsuario dal = new DALUsuario();
            ModeloUsuario obj = new ModeloUsuario();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;

            ModeloUsuario validaEmail = dal.GetRegistro(txtEmail.Text);

            try
            {
                if (btnSalvar.Text == "Inserir")
                {
                    if (validaEmail.Id == 0)
                    {
                        dal.Inserir(obj);
                        msg = "<script> alert('O código gerado foi:  " + obj.Id.ToString() + "') </script>";
                        this.LimparCampos();
                    }
                    else
                    {
                        msg = "<script> alert('Não é possível cadastrar o usuário, pois já existe um usuário cadastrado com este E-mail!') </script>";

                    }

                }
                else
                {
                    //pode alterar
                    obj.Id = Convert.ToInt32(txtId.Text);
                    if (validaEmail.Id != 0 && validaEmail.Id != obj.Id)
                    {
                        msg = "<script> alert('Não é possível Alterar o usuário, pois já existe um usuário cadastrado com este E-mail!') </script>";
                    }
                    else
                    {
                        dal.Alterar(obj);
                        msg = "<script> alert('Registro alterado com sucesso!') </script>";
                        this.LimparCampos();
                    }
                }
                Response.Write(msg);
            }
            catch (Exception erro)
            {

                Response.Write("<script> alert('" + erro.Message + "') </script>");
            }
            AtualizaGrid();
        }

        protected void gvDados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int cod = Convert.ToInt32(gvDados.Rows[index].Cells[2].Text);
            DALUsuario dal = new DALUsuario();
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
                DALUsuario dal = new DALUsuario();
                ModeloUsuario usuario = dal.GetRegistro(cod);
                if (usuario.Id != 0)
                {
                    txtId.Text = usuario.Id.ToString();
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtSenha.Text = usuario.Senha;
                    btnSalvar.Text = "Alterar";
                }
            }
            catch
            {

            }
        }
    }
}