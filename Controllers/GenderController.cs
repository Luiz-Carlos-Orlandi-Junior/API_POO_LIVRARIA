using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Models;
using Livraria_Projeto.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livraria_Projeto.Controllers
{
    /// <summary>
    /// Controller pra gerenciar operações CRUD de gêneros.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController : ControllerBase
    {
        private readonly GenderService _service;

        /// <summary>
        /// Construtor do controller de gêneros.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public GenderController(AppDbContext context)
        {
            _service = new GenderService(context);
        }

        /// <summary>
        /// Traz todos os gêneros.
        /// </summary>
        /// <returns>Retorna de todos os gêneros.</returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<Gender>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var gender = await _service.GetAll();
            return Ok(gender);
        }

        /// <summary>
        /// Traz um gênero pelo ID.
        /// </summary>
        /// <param name="id">ID do gênero.</param>
        /// <returns>Gênero encontrado.</returns>
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(typeof(Gender), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(int id)
        {
            var gender = await _service.GetById(id);
            if (gender == null)
                return NotFound();

            return Ok(gender);
        }

        /// <summary>
        /// Cria um novo gênero.
        /// </summary>
        /// <param name="gender">Dados do novo gênero.</param>
        /// <returns>Gênero criado.</returns>
        [HttpPost("Create")]
        [ProducesResponseType(typeof(Gender), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Gender gender)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdGender = await _service.Add(gender);
            return CreatedAtAction(nameof(GetById), new { id = createdGender.Id }, createdGender);
        }

        /// <summary>
        /// Atualiza um gênero existente.
        /// </summary>
        /// <param name="id">ID do gênero.</param>
        /// <param name="gender">Dados do gênero atualizados.</param>
        /// <returns>Gênero atualizado.</returns>
        [HttpPut("Put/{id}")]
        [ProducesResponseType(typeof(Gender), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Update(int id, [FromBody] Gender gender)
        {
            if (!ModelState.IsValid || id != gender.Id)
                return BadRequest(ModelState);

            var updatedGenre = await _service.Update(gender);
            return Ok(updatedGenre);
        }

        /// <summary>
        /// Deleta um gênero pelo ID.
        /// </summary>
        /// <param name="id">ID do gênero a ser deletado.</param>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}