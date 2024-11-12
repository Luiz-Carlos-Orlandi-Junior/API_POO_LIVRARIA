using Livraria_Projeto.Classes;
using Livraria_Projeto.Database.Models;
using Livraria_Projeto.Service.DTOs;

namespace Livraria_Projeto.Service
{
    public class ProductsService
    {
        private readonly DbContext _dbcontext;
        public ProductsService(DbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        
        public List<Classes.Livros> GetLivros()
        {
            return _dbcontext.Livro.ToList();
        }
    }
} 
    

