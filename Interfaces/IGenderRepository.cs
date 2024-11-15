using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces
{
    /// <summary>
    /// Interface que define as operações CRUD para a entidade Gênero.
    /// </summary>
    public interface IGenderRepository
    {
        /// <summary>
        /// Traz de  todos os gêneros.
        /// </summary>
        /// <returns>Retorna todos os gêneros.</returns>
        Task<List<Gender>> GetAll();

        /// <summary>
        /// Traz um gênero pelo ID.
        /// </summary>
        /// <param name="id">ID do gênero.</param>
        /// <returns>Gênero encontrado.</returns>
        Task<Gender> GetById(int id);

        /// <summary>
        /// Inseri um novo gênero.
        /// </summary>
        /// <param name="genre">Dados do novo gênero.</param>
        /// <returns>Gênero adicionado.</returns>
        Task<Gender> Add(Gender gender);

        /// <summary>
        /// Atualiza um gênero existente.
        /// </summary>
        /// <param name="gender">Dados do gênero a serem atualizados.</param>
        /// <returns>Gênero atualizado.</returns>
        Task<Gender> Update(Gender gender);

        /// <summary>
        /// Deleta um gênero pelo ID.
        /// </summary>
        /// <param name="id">ID do gênero que vai ser deletado.</param>
        Task Delete(int id);
    }
}