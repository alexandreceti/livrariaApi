using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class PedidosController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<string> Get([FromQuery]string nome, int sobrenome)
        {
            return new string[] { "idPedido: 1, nome: titulo1, sobreNome: 1" };
        }

        // GET api/values/5
        [HttpGet("{idPedido}")]
        [ProducesResponseType(200)]
        public string Get(int idPedido)
        {
            return "idPedido: 1, nome: titulo1, sobreNome: 1";
        }

        // GET api/values/5
        [HttpGet("{idPedido}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<string> GetLivros(int idPedido)
        {
            return new string[] { "Isbn: 1, Titulo: api, IdEditora: 1, [ { idPedido: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor } ]" };
            // TODO: devolver uri de detalhes dos autores
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(202)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{idPedido}")]
        [ProducesResponseType(202)]
        public string Put(int idPedido, [FromBody]string value)
        {
            return "idPedido: 1, nome: teste, sobreNome: 4";
        }

        // DELETE api/values/5
        [HttpDelete("{idPedido}")]
        [ProducesResponseType(200)]
        public void Delete(int idPedido)
        {
        }
    }
}
