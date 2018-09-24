using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaAPI.Models;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class AutoresController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<AutorModel> Get([FromQuery]string nome, string sobrenome)
        {
            List<AutorModel> listaRetorno = new List<AutorModel>();

            AutorModel autorMock = new AutorModel()
            {
                IdAutor = 1,
                Nome = "Homero",
                SobreNome = string.Empty
            };

            AutorModel autorMock1 = new AutorModel()
            {
                IdAutor = 2,
                Nome = "Paulo",
                SobreNome = "Coelho"
            };
            if (string.IsNullOrEmpty(nome))
            {
                listaRetorno.Add(autorMock);
                listaRetorno.Add(autorMock1);
            }
            else if (nome == "Homero")
                listaRetorno.Add(autorMock);

            return listaRetorno;
        }

        // GET api/values/5
        [HttpGet("{idAutor}")]
        [ProducesResponseType(200)]
        public AutorModel Get(int idAutor)
        {
            if (idAutor == 1)
            {
                AutorModel autorMock = new AutorModel()
                {
                    IdAutor = 1,
                    Nome = "Homero",
                    SobreNome = string.Empty
                };
                return autorMock;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("{idAutor}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<LivroModel> GetLivros(int idAutor)
        {
            List<LivroModel> listaRetorno = new List<LivroModel>();

            EditoraModel editoraMock = new EditoraModel()
            {
                IdEditora = 1,
                Nome = "Abril"
            };

            if (idAutor == 1)
            {
                LivroModel livroMock = new LivroModel()
                {
                    Isbn = 654321,
                    Editora = editoraMock,
                    AnoLancamento = DateTime.Now,
                    Titulo = "Odisseia"
                };

                LivroModel livroMock1 = new LivroModel()
                {
                    Isbn = 123456,
                    Editora = editoraMock,
                    AnoLancamento = DateTime.Now,
                    Titulo = "Iliada"
                };

                AutorModel autorMock = new AutorModel()
                {
                    IdAutor = 1,
                    Nome = "Homero",
                    SobreNome = string.Empty
                };

                livroMock.ListaAutores.Add(autorMock);
                livroMock1.ListaAutores.Add(autorMock);

                listaRetorno.Add(livroMock1);
                listaRetorno.Add(livroMock);
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
