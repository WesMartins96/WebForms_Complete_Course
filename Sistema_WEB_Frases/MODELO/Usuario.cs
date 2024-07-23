using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.MODELO
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}