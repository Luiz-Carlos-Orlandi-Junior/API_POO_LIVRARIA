using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Projeto.Repositories
{
    /// <summary>
    /// Repositório para gerenciar operações CRUD de livros.
    /// </summary>
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor do repositório de livros.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<Book> GetById(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<Book> Add(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        /// <inheritdoc />
        public async Task<Book> Update(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }

        /// <inheritdoc />
        public async Task Delete(int id)
        {
            var book = await GetById(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}