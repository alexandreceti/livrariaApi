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

            AutorModel autorMock = new AutorModel()
            {
                IdAutor = 1,
                Nome = "Homero",
                SobreNome = string.Empty
            };

            EditoraModel editoraMock = new EditoraModel()
            {
                IdEditora = 1,
                Nome = "Abril"
            };

            LivroModel livroMock1 = new LivroModel()
            {
                Isbn = 123456,
                AnoLancamento = DateTime.Now,
                Editora = editoraMock,
                Titulo = "Iliada"
            };

            LivroModel livroMock = new LivroModel()
            {
                Isbn = 654321,
                Editora = editoraMock,
                AnoLancamento = DateTime.Now,
                Titulo = "Odisseia"
            };

            livroMock1.ListaAutores.Add(autorMock);
            livroMock.ListaAutores.Add(autorMock);

            if (string.IsNullOrEmpty(titulo))
            {
                listaRetorno.Add(livroMock);
                listaRetorno.Add(livroMock1);
            }
            else if (titulo == "Iliada")
                listaRetorno.Add(livroMock1);

            return listaRetorno;
        }

        // GET api/values/5
        [HttpGet("{isbn}")]
        [ProducesResponseType(200)]
        public LivroModel Get(int isbn)
        {
            EditoraModel editoraMock = new EditoraModel()
            {
                IdEditora = 1,
                Nome = "Abril"
            };

            LivroModel livroMock = new LivroModel()
            {
                Isbn = 654321,
                Editora = editoraMock,
                AnoLancamento = DateTime.Now,
                Titulo = "Odisseia"
            };

            AutorModel autorMock = new AutorModel()
            {
                IdAutor = 1,
                Nome = "Homero",
                SobreNome = string.Empty
            };

            livroMock.ListaAutores.Add(autorMock);

            if (isbn == 654321)
                return livroMock;
            else
                return null;
        }

        // GET api/values/5
        [HttpGet("{Isbn}/Autores")]
        [ProducesResponseType(200)]
        public IEnumerable<AutorModel> GetAutores(int isbn)
        {
            List<AutorModel> listaRetorno = new List<AutorModel>();

            if (isbn == 654321 || isbn == 123456)
            {
                AutorModel autorMock = new AutorModel()
                {
                    IdAutor = 1,
                    Nome = "Homero",
                    SobreNome = string.Empty
                };

                listaRetorno.Add(autorMock);
            }
            return listaRetorno;
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
