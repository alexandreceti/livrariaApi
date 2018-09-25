using System;
using System.Collections.Generic;
using LivrariaAPI.Models;

namespace LivrariaAPI.DTOModels
{
    public class EditorasGet : ResponseGet
    {
        public List<EditoraModel> Editoras { get; set; }

        public EditorasGet(int limit = 0, int offset = 0)
            : base()
        {
            Limit = limit;
            Offset = offset;
            Editoras = new List<EditoraModel>();
        }
    }
}