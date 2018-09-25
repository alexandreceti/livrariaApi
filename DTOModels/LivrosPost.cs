using System;
using System.Collections.Generic;
using LivrariaAPI.Models;

namespace LivrariaAPI.DTOModels
{
    public class LivrosPost
    {
        public List<LivroModel> Livros { get; set; }

        public LivrosPost()
        {
            Livros = new List<LivroModel>();
        }
    }
}