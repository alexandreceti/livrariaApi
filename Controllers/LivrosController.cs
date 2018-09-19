using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaAPI.Models;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class LivrosController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<LivroModel> Get([FromQuery]string titulo, int idEditora, DateTime anoLancamento)
        {
            List<LivroModel> listaRetorno = new List<LivroModel>();
            
            if (titulo == "titulo1")
            {
                LivroModel livro1 = new LivroModel();
                livro1.Isbn = 123456;
                livro1.IdEditora = 1;
                livro1.AnoLancamento = DateTime.Now;
                livro1.Titulo = "titulo1";

                listaRetorno.Add(livro1);
            }
            return listaRetorno;
        }

        // GET api/values/5
        [HttpGet("{isbn}")]
        [ProducesResponseType(200)]
        public string Get(int isbn)
        {
            return "Isbn: 1, Titulo: api, IdEditora: 1, [ { idAutor: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor } ]";
        }

        // GET api/values/5
        [HttpGet("{Isbn}/Autores")]
        [ProducesResponseType(200)]
        public IEnumerable<string> GetAutores(int Isbn)
        {
            return new string[] { "idAutor: 1, Nome: autor1, Sobrenome: Sobrenome1", "idAutor: 2, Nome: autor2, Sobrenome: Sobrenome2" };
            // TODO: devolver uri de detalhes dos autores
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(202)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{isbn}")]
        [ProducesResponseType(202)]
        public string Put(int isbn, [FromBody]string value)
        {
            return "Isbn: 4, Titulo: teste, IdEditora: 4";
        }

        // DELETE api/values/5
        [HttpDelete("{Isbn}")]
        [ProducesResponseType(200)]
        public void Delete(int id)
        {
        }
    }
}
