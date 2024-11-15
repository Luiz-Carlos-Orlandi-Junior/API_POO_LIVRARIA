using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces
{
    /// <summary>
    /// Interface que concretiza as operações CRUD pra entidade Movimento.
    /// </summary>
    public interface IMovementRepository
    {
        /// <summary>
        /// Traz todos os movimentos.
        /// </summary>
        /// <returns>Retorna de todos os movimentos.</returns>
        Task<List<Movement>> GetAll();

        /// <summary>
        /// Traz um movimento pelo ID.
        /// </summary>
        /// <param name="id">ID do movimento.</param>
        /// <returns>Movimento encontrado.</returns>
        Task<Movement> GetById(int id);

        /// <summary>
        /// Adiciona um novo movimento.
        /// </summary>
        /// <param name="movement">Dados de um novo movimento.</param>
        /// <returns>Movimento adicionado.</returns>
        Task<Movement> Add(Movement movement);

        /// <summary>
        /// Atualiza um movimento existente.
        /// </summary>
        /// <param name="movement">Dados do movimento que vão ser atualizados.</param>
        /// <returns>Movimento atualizado.</returns>
        Task<Movement> Update(Movement movement);

        /// <summary>
        /// Deleta um movimento pelo ID.
        /// </summary>
        /// <param name="id">ID do movimento a ser deletado.</param>
        Task Delete(int id);
    }
}