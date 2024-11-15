using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Projeto.Repositories
{
    /// <summary>
    /// Repositório para gerenciar operações CRUD de editoras.
    /// </summary>
    public class PublisherRepository : IPublisherRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor do repositório de editoras.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public PublisherRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<List<Publisher>> GetAll()
        {
            return await _context.Publishers.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<Publisher> GetById(int id)
        {
            return await _context.Publishers.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<Publisher> Add(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();
            return publisher;
        }

        /// <inheritdoc />
        public async Task<Publisher> Update(Publisher publisher)
        {
            _context.Publishers.Update(publisher);
            await _context.SaveChangesAsync();
            return publisher;
        }

        /// <inheritdoc />
        public async Task Delete(int id)
        {
            var publisher = await GetById(id);
            if (publisher != null)
            {
                _context.Publishers.Remove(publisher);
                await _context.SaveChangesAsync();
            }
        }
    }
}