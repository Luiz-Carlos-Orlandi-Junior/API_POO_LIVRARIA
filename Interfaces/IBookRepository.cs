using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces;

public interface IBookRepository
{
    Task<List<Book>> GetAll();
    Task<Book> GetById(int id);
    Task<Book> Add(Book book);
    Task<Book> Update(Book book);
    Task Delete(int id);
}