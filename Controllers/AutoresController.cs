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
    public class AutoresController : Controller
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        public AutoresGet Get([FromQuery]string nome, string sobrenome)
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

            if (string.IsNullOrEmpty(nome))
            {
                result.Autores.Add(autorMock);
                result.Autores.Add(autorMock1);
            }
            else if (nome == "Homero")
                result.Autores.Add(autorMock);

            if (result.Autores.Count == 0)
                result.StatusCode = 204;
            else
                result.StatusCode = 200;

            return result;
        }

        // GET api/values/5
        [HttpGet("{idAutor}")]
        [ProducesResponseType(200)]
        public AutoresGet Get(int idAutor)
        {
            AutoresGet result = new AutoresGet();

            if (idAutor == 1)
            {
                AutorModel autorMock = new AutorModel()
                {
                    IdAutor = 1,
                    Nome = "Homero",
                    SobreNome = string.Empty
                };
                
                result.Autores.Add(autorMock);
                result.StatusCode = 200;
            }
            
            if (result.Autores.Count == 0)
                result.StatusCode = 204;
            else
                result.StatusCode = 200;

            return result;
        }

        // GET api/values/5
        [HttpGet("{idAutor}/Livros")]
        [ProducesResponseType(200)]
        public LivrosGet GetLivros(int idAutor)
        {
            LivrosGet result = new LivrosGet();

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

                result.Livros.Add(livroMock1);
                result.Livros.Add(livroMock);
            }

            if (result.Livros.Count == 0)
                result.StatusCode = 204;
            else
                result.StatusCode = 200;

            return result;
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
