using System;

namespace LivrariaAPI.DTOModels
{
    public class ResponseGet
    {
        public int Limit { get;set; }
        public int Offset { get; set; }
        public string Versao { get; set; }

        public ResponseGet()
        {
            Limit = 0;
            Offset = 0;
            Versao = "v1";
        }
    }
}