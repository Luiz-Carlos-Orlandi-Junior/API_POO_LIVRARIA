using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces;

public interface IMovementRepository
{
    Task<List<Movement>> GetAll();
    Task<Movement> GetByType(string type);
    Task<Movement> Add(Movement movement);
}