using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Livraria_Projeto.Repositories;

namespace Livraria_Projeto.Services
{
    /// <summary>
    /// Serviço pra concretizar operações CRUD de livros.
    /// </summary>
    public class BookService : IBookRepository
    {
        private readonly IBookRepository _repository;

        /// <summary>
        /// Construtor do serviço de livros.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public BookService(AppDbContext context)
        {
            _repository = new BookRepository(context);
        }

        /// <GetAll />
        public async Task<List<Book>> GetAll()
        {
            return await _repository.GetAll();
        }

        /// <GetById />
        public async Task<Book> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        /// <Insert />
        public async Task<Book> Add(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            return await _repository.Add(book);
        }

        /// <Put />
        public async Task<Book> Update(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            return await _repository.Update(book);
        }

        /// <Delete />
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}