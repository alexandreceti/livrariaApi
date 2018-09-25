using System;
using System.Collections.Generic;
using LivrariaAPI.Models;

namespace LivrariaAPI.DTOModels
{
    public class AutoresGet : ResponseGet
    {
        public List<AutorModel> Autores { get; set; }

        public AutoresGet()
            : base()
        {
            Autores = new List<AutorModel>();
        }
    }
}