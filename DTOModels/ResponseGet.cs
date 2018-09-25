using System;

namespace LivrariaAPI.DTOModels
{
    public class ResponseGet
    {
        public int Limit { get;set; }
        public int Offset { get; set; }
        public string Versao { get; set; }
        public int StatusCode { get;set; }

        public ResponseGet()
        {
            StatusCode = 200;
            Limit = 0;
            Offset = 0;
            Versao = "v1";
        }
    }
}