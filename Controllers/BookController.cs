using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Models;
using Livraria_Projeto.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livraria_Projeto.Controllers
{
    /// <summary>
    /// Controller pra concretizar operações CRUD de livros.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService _service;

        /// <summary>
        /// Construtor do controller de livros.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public BookController(AppDbContext context)
        {
            _service = new BookService(context);
        }

        /// <summary>
        /// Traz todos os livros.
        /// </summary>
        /// <returns>Retorna de todos os livros.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Book>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var books = await _service.GetAll();
            return Ok(books);
        }

        /// <summary>
        /// Traz um livro pelo ID.
        /// </summary>
        /// <param name="id">ID do livro.</param>
        /// <returns>Livro encontrado.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Book), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _service.GetById(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }

        /// <summary>
        /// Cria um novo livro.
        /// </summary>
        /// <param name="book">Dados do novo livro.</param>
        /// <returns>Livro criado.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(Book), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdBook = await _service.Add(book);
            return CreatedAtAction(nameof(GetById), new { id = createdBook.Id }, createdBook);
        }

        /// <summary>
        /// Atualiza um livro existente.
        /// </summary>
        /// <param name="id">ID do livro.</param>
        /// <param name="book">Dados do livro atualizados.</param>
        /// <returns>Livro atualizado.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Book), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Update(int id, [FromBody] Book book)
        {
            if (!ModelState.IsValid || id != book.Id)
                return BadRequest(ModelState);

            var updatedBook = await _service.Update(book);
            return Ok(updatedBook);
        }

        /// <summary>
        /// Deleta um livro pelo ID.
        /// </summary>
        /// <param name="id">ID do livro a ser deletado.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}