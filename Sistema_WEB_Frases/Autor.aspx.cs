using System;
using System.Collections.Generic;
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

        }

        private void AtualizaGrid()
        {
            DALCategoria dal = new DALCategoria();
            gvDados.DataSource = dal.Localizar();
            gvDados.DataBind();
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            btnSalvar.Text = "Inserir";
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string msg = "";
            DALCategoria dal = new DALCategoria();
            ModeloCategoria obj = new ModeloCategoria();
            obj.Categoria = txtCategoria.Text;

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
    }
}