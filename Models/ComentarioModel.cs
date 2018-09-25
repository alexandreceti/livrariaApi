using System;

namespace LivrariaAPI.Models
{
    public class ComentarioModel
    {
        public int IdComentario { get; set; }
        public int IdLivro { get; set; }
        public string Texto { get; set; }
        public string Usuario { get; set; }
        public int Nota { get; set; }
    }
}