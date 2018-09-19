using System;
using System.Collections.Generic;
using Models;

namespace LivrariaAPI.Models
{
    public class LivroModel
    {
        public int Isbn { get;set;  }
        public string Titulo { get;set;  }
        public int IdEditora { get;set;  }
        public DateTime AnoLancamento { get;set; }

        public IEnumerable<AutoresModel> listaAutores { get;set; }

        public LivroModel()
        {}
    }
}
