using System;
using System.Collections.Generic;
using LivrariaAPI.Models;

namespace LivrariaAPI.DTOModels
{
    public class LivrosGet : ResponseGet
    {
        public List<LivroModel> Livros { get; set; }

        public LivrosGet(int limit = 0, int offset = 0)
            : base()
        {
            Limit = limit;
            Offset = offset;
            Livros = new List<LivroModel>();
        }
    }
}