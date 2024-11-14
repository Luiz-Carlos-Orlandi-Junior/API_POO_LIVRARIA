using Livraria_Projeto.Database;
using Livraria_Projeto.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Livraria_Projeto.Controllers
{
    [ApiController]
    [Route("book/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(DbContextInMemory dbContext)
        {
            _bookService = new BookService(dbContext);
        }
    }
}