using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Models;
using Livraria_Projeto.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livraria_Projeto.Controllers
{
    /// <summary>
    /// Controller para gerenciar operações CRUD de movimentos.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MovementController : ControllerBase
    {
        private readonly MovementService _service;

        /// <summary>
        /// Construtor do controller de movimentos.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public MovementController(AppDbContext context)
        {
            _service = new MovementService(context);
        }

        /// <summary>
        /// Obtém todos os movimentos.
        /// </summary>
        /// <returns>Lista de todos os movimentos.</returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<Movement>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var movements = await _service.GetAll();
            return Ok(movements);
        }

        /// <summary>
        /// Obtém um movimento pelo ID.
        /// </summary>
        /// <param name="id">ID do movimento.</param>
        /// <returns>Movimento encontrado.</returns>
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(typeof(Movement), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(int id)
        {
            var movement = await _service.GetById(id);
            if (movement == null)
                return NotFound();

            return Ok(movement);
        }

        /// <summary>
        /// Cria um novo movimento.
        /// </summary>
        /// <param name="movement">Dados do novo movimento.</param>
        /// <returns>Movimento criado.</returns>
        [HttpPost("Create")]
        [ProducesResponseType(typeof(Movement), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Movement movement)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdMovement = await _service.Add(movement);
            return CreatedAtAction(nameof(GetById), new { id = createdMovement.Id }, createdMovement);
        }

        /// <summary>
        /// Atualiza um movimento existente.
        /// </summary>
        /// <param name="id">ID do movimento.</param>
        /// <param name="movement">Dados do movimento atualizados.</param>
        /// <returns>Movimento atualizado.</returns>
        [HttpPut("Put/{id}")]
        [ProducesResponseType(typeof(Movement), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Update(int id, [FromBody] Movement movement)
        {
            if (!ModelState.IsValid || id != movement.Id)
                return BadRequest(ModelState);

            var updatedMovement = await _service.Update(movement);
            return Ok(updatedMovement);
        }

        /// <summary>
        /// Deleta um movimento pelo ID.
        /// </summary>
        /// <param name="id">ID do movimento a ser deletado.</param>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}