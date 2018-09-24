using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaAPI.Models;

namespace LivrariaAPI.Controllers
{
    [Route("LivrariaAPI/v1/[controller]")]
    public class EditorasController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<EditoraModel> Get([FromQuery]string nome)
        {
            List<EditoraModel> listaRetorno = new List<EditoraModel>();

            EditoraModel editoraMock = new EditoraModel()
            {
                IdEditora = 1,
                Nome = "Abril"
            };

            EditoraModel editoraMock1 = new EditoraModel()
            {
                IdEditora = 2,
                Nome = "Irmaos Vitalle"
            };

            if (string.IsNullOrEmpty(nome))
            {
                listaRetorno.Add(editoraMock);
                listaRetorno.Add(editoraMock1);
            }
            else if (nome == "Abril")
                listaRetorno.Add(editoraMock);

            return listaRetorno;
        }

        // GET api/values/5
        [HttpGet("{idEditora}")]
        [ProducesResponseType(200)]
        public EditoraModel Get(int idEditora)
        {
            if (idEditora == 1)
                return new EditoraModel()
                {
                    IdEditora = 1,
                    Nome = "Abril"
                };
            else if (idEditora == 2)
                return new EditoraModel()
                {
                    IdEditora = 2,
                    Nome = "Irmaos Vitalle"
                };
            else
                return null;
        }

        // GET api/values/5
        [HttpGet("{idEditora}/Livros")]
        [ProducesResponseType(200)]
        public IEnumerable<LivroModel> GetLivros(int idEditora)
        {
            List<LivroModel> listaRetorno = new List<LivroModel>();

            if (idEditora == 1)
            {
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

                listaRetorno.Add(livroMock);
                listaRetorno.Add(livroMock1);

            }
            return listaRetorno;
        }

        // GET api/values/5
        [HttpGet("{idEditora}/Autores")]
        [ProducesResponseType(200)]
        public IEnumerable<AutorModel> GetAutores(int idEditora)
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

            if (idEditora == 1)
            {
                listaRetorno.Add(autorMock);
                listaRetorno.Add(autorMock1);
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
