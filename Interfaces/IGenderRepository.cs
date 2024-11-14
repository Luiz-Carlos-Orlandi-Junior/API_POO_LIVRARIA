using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces;

public interface IGenderRepository
{
    Task<List<Gender>> GetAll();
    Task<Gender> GetById(int id);
    Task<Gender> Add(Gender gender);
    Task<Gender> Update(Gender gender);
    Task Delete(int id);
}