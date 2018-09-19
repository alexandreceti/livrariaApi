using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class AutoresController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<string> Get([FromQuery]string nome, int sobrenome)
        {
            return new string[] { "idAutor: 1, nome: titulo1, sobreNome: 1" };
        }

        // GET api/values/5
        [HttpGet("{idAutor}")]
        [ProducesResponseType(200)]
        public string Get(int idAutor)
        {
            return "idAutor: 1, nome: titulo1, sobreNome: 1";
        }

        // GET api/values/5
        [HttpGet("{idAutor}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<string> GetLivros(int idAutor)
        {
            return new string[] { "Isbn: 1, Titulo: api, IdEditora: 1, [ { idAutor: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor } ]" };
            // TODO: devolver uri de detalhes dos autores
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(202)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{idAutor}")]
        [ProducesResponseType(202)]
        public string Put(int idAutor, [FromBody]string value)
        {
            return "idAutor: 1, nome: teste, sobreNome: 4";
        }

        // DELETE api/values/5
        [HttpDelete("{idAutor}")]
        [ProducesResponseType(200)]
        public void Delete(int idAutor)
        {
        }
    }
}
