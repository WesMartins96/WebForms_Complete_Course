﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_WEB_Frases.MODELO
{
    public class ModeloFrase
    {
        public int Id { get; set; }
        public string Frase { get; set; }
        public int Autor { get; set; }
        public int Categoria { get; set; }
    }
}