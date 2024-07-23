using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.MODELO
{
    public class Frase
    {
        public int id { get; set; }
        public string frase { get; set; }
        public int autor { get; set; }
        public int categoria { get; set; }
    }
}