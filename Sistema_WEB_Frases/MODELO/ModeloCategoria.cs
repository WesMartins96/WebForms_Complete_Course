using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.MODELO
{
    public class ModeloCategoria
    {
        public int Id { get; set; }
        public string Categoria { get; set; }

        public ModeloCategoria()
        {
            this.Id = 0;
            this.Categoria = "";
        }
    }
}