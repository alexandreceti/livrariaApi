using System;
using System.Collections.Generic;

namespace LivrariaAPI.Models
{
    public class CarrinhoModel
    {
        public int IdCarrinho { get;set;  }
        public DateTime Criado { get;set; }

        public List<LivroModel> ListaLivros { get;set; }

        public CarrinhoModel()
        {
            ListaLivros = new List<LivroModel>();
        }
    }
}
