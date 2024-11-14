using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Repositories;

namespace Livraria_Projeto.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(DbContextInMemory dbContext)
        {
            _bookRepository = new BookRepository(dbContext);
        }
    }
}