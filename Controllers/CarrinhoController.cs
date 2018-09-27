using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaAPI.Models;
using LivrariaAPI.DTOModels;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class CarrinhoController : Controller
    {

        // POST api/values
        [HttpPost]
        [ProducesResponseType(202)]
        public void Post([FromBody]string value)
        {
            
        }
        // GET api/values/5
        [HttpGet("{idCarrinho}")]
        [ProducesResponseType(200)]
        public string Get(int idCarrinho)
        {
            return "idCarrinho: 1, nome: titulo1, sobreNome: 1";
        }

        // PUT api/values/5
        [HttpPut("{idCarrinho}")]
        [ProducesResponseType(202)]
        public string Put(int idCarrinho, [FromBody]string value)
        {
            return "idCarrinho: 1, nome: teste, sobreNome: 4";
        }

        // DELETE api/values/5
        [HttpDelete("{idCarrinho}")]
        [ProducesResponseType(200)]
        public void Delete(int idCarrinho)
        {
        }

        // GET api/values/5
        [HttpGet("{idCarrinho}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<string> GetLivros(int idCarrinho)
        {
            return new string[] { "Isbn: 1, Titulo: api, IdEditora: 1, [ { idCarrinho: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor } ]" };
            // TODO: devolver uri de detalhes dos autores
        }

        [HttpPost("{idCarrinho}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<string> addLivros(int idCarrinho)
        {
            return new string[] { "Isbn: 1, Titulo: api, IdEditora: 1, [ { idCarrinho: 1, Nome: nomeAutor, Sobrenome: sobrenomeAutor } ]" };
            // TODO: devolver uri de detalhes dos autores
        }
    }
}
