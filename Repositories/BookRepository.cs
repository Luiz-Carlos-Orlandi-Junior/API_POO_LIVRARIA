using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Projeto.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DbContextInMemory _context;

        public BookRepository(DbContextInMemory context)
        {
            _context = context;
        }

        public async Task<List<Book>> FindAllAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}