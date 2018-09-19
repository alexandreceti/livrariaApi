using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class EditorasController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<string> Get([FromQuery]string nome)
        {
            return new string[] { "idEditora: 1, editora: titulo1" };
        }

        // GET api/values/5
        [HttpGet("{idEditora}")]
        [ProducesResponseType(200)]
        public string Get(int idAutor)
        {
            return "idEditora: 1, editora: titulo1";
        }

        // GET api/values/5
        [HttpGet("{idEditora}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<string> GetLivros(int idEditora)
        {
            return new string[] { "Isbn: 1, Titulo: api, IdEditora: 1, [ { idAutor: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor } ]" };
            // TODO: devolver uri de detalhes dos autores
        }

        // GET api/values/5
        [HttpGet("{idEditora}/Autores")]
        [ProducesResponseType(200)]
        public IEnumerable<string> GetAutores(int idEditora)
        {
            return new string[] { "{ idAutor: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor }" };
            // TODO: devolver uri de detalhes dos autores
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(202)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{idEditora}")]
        [ProducesResponseType(202)]
        public string Put(int idEditora, [FromBody]string value)
        {
            return "idEditora: 1, nome: teste";
        }

        // DELETE api/values/5
        [HttpDelete("{idEditora}")]
        [ProducesResponseType(200)]
        public void Delete(int idEditora)
        {
        }
    }
}
