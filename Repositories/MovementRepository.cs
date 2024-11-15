using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Projeto.Repositories
{
    /// <summary>
    /// Repositório para gerenciar operações CRUD de movimentos.
    /// </summary>
    public class MovementRepository : IMovementRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor do repositório de movimentos.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public MovementRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<List<Movement>> GetAll()
        {
            return await _context.Movements.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<Movement> GetById(int id)
        {
            return await _context.Movements.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<Movement> Add(Movement movement)
        {
            _context.Movements.Add(movement);
            await _context.SaveChangesAsync();
            return movement;
        }

        /// <inheritdoc />
        public async Task<Movement> Update(Movement movement)
        {
            _context.Movements.Update(movement);
            await _context.SaveChangesAsync();
            return movement;
        }

        /// <inheritdoc />
        public async Task Delete(int id)
        {
            var movement = await GetById(id);
            if (movement != null)
            {
                _context.Movements.Remove(movement);
                await _context.SaveChangesAsync();
            }
        }
    }
}