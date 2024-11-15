using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Projeto.Repositories
{
    /// <summary>
    /// Repositório para gerenciar operações CRUD de gêneros.
    /// </summary>
    public class GenderRepository : IGenderRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor do repositório de gêneros.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public GenderRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<List<Gender>> GetAll()
        {
            return await _context.Genders.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<Gender> GetById(int id)
        {
            return await _context.Genders.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<Gender> Add(Gender gender)
        {
            _context.Genders.Add(gender);
            await _context.SaveChangesAsync();
            return gender;
        }

        /// <inheritdoc />
        public async Task<Gender> Update(Gender gender)
        {
            _context.Genders.Update(gender);
            await _context.SaveChangesAsync();
            return gender;
        }

        /// <inheritdoc />
        public async Task Delete(int id)
        {
            var gender = await GetById(id);
            if (gender != null)
            {
                _context.Genders.Remove(gender);
                await _context.SaveChangesAsync();
            }
        }
    }
}