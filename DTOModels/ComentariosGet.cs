using System;
using System.Collections.Generic;
using LivrariaAPI.Models;

namespace LivrariaAPI.DTOModels
{
    public class ComentariosGet : ResponseGet
    {
        public List<ComentarioModel> Comentarios { get; set; }

        public ComentariosGet(int limit = 0, int offset = 0)
            : base()
        {
            Limit = limit;
            Offset = offset;
            Comentarios = new List<ComentarioModel>();
        }
    }
}