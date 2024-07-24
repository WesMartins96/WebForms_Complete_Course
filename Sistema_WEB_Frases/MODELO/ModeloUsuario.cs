using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.MODELO
{
    public class ModeloUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}