using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces;

public interface IPublisherRepository
{
    Task<List<Publisher>> GetAll();
    Task<Publisher> GetById(int id);
    Task<Publisher> Add(Publisher publisher);
    Task<Publisher> Update(Publisher publisher);
    Task Delete(int id);
}