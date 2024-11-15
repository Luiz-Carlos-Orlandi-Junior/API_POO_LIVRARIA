using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Models;
using Livraria_Projeto.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace Livraria_Projeto.Controllers
{
    /// <summary>
    /// Controller para gerenciar operações CRUD de editoras.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly PublisherService _service;

        /// <summary>
        /// Construtor do controller de editoras.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public PublisherController(AppDbContext context)
        {
            _service = new PublisherService(context);
        }

        /// <summary>
        /// Obtém todas as editoras.
        /// </summary>
        /// <returns>Lista de todas as editoras.</returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<Publisher>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var publishers = await _service.GetAll();
            return Ok(publishers);
        }

        /// <summary>
        /// Obtém uma editora pelo ID.
        /// </summary>
        /// <param name="id">ID da editora.</param>
        /// <returns>Editora encontrada.</returns>
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(typeof(Publisher), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(int id)
        {
            var publisher = await _service.GetById(id);
            if (publisher == null)
                return NotFound();

            return Ok(publisher);
        }

        /// <summary>
        /// Cria uma nova editora.
        /// </summary>
        /// <param name="publisher">Dados da nova editora.</param>
        /// <returns>Editora criada.</returns>
        [HttpPost("Create")]
        [ProducesResponseType(typeof(Publisher), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdPublisher = await _service.Add(publisher);
            return CreatedAtAction(nameof(GetById), new { id = createdPublisher.Id }, createdPublisher);
        }

        /// <summary>
        /// Atualiza uma editora existente.
        /// </summary>
        /// <param name="id">ID da editora.</param>
        /// <param name="publisher">Dados da editora atualizados.</param>
        /// <returns>Editora atualizada.</returns>
        [HttpPut("Put/{id}")]
        [ProducesResponseType(typeof(Publisher), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Update(int id, [FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid || id != publisher.Id)
                return BadRequest(ModelState);

            var updatedPublisher = await _service.Update(publisher);
            return Ok(updatedPublisher);
        }

        /// <summary>
        /// Deleta uma editora pelo ID.
        /// </summary>
        /// <param name="id">ID da editora a ser deletada.</param>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}