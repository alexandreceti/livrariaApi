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
    public class EditorasController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public EditorasGet Get([FromQuery]string nome, int limit, int offset)
        {
            EditorasGet result = new EditorasGet(limit, offset);

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
                result.Editoras.Add(editoraMock);
                result.Editoras.Add(editoraMock1);
            }
            else if (nome == "Abril")
                result.Editoras.Add(editoraMock);

            return result;
        }

        // GET api/values/5
        [HttpGet("{idEditora}")]
        [ProducesResponseType(200)]
        public EditorasGet Get(int idEditora)
        {
            EditorasGet result = new EditorasGet();

            if (idEditora == 1)
                result.Editoras.Add(new EditoraModel()
                {
                    IdEditora = 1,
                    Nome = "Abril"
                });
            else if (idEditora == 2)
                result.Editoras.Add(new EditoraModel()
                {
                    IdEditora = 2,
                    Nome = "Irmaos Vitalle"
                });

            return result;
        }

        // GET api/values/5
        [HttpGet("{idEditora}/Livros")]
        [ProducesResponseType(200)]
        public LivrosGet GetLivros(int idEditora, int limit, int offset)
        {
            LivrosGet result = new LivrosGet(limit, offset);

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

                result.Livros.Add(livroMock);
                result.Livros.Add(livroMock1);

            }
            return result;
        }

        // GET api/values/5
        [HttpGet("{idEditora}/Autores")]
        [ProducesResponseType(200)]
        public AutoresGet GetAutores(int idEditora)
        {
            AutoresGet result = new AutoresGet();

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
                result.Autores.Add(autorMock);
                result.Autores.Add(autorMock1);
            }
            return result;
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
