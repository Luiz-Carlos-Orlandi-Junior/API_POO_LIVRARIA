using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces
{
    /// <summary>
    /// Interface que concretiza as operações CRUD pra entidade Editora.
    /// </summary>
    public interface IPublisherRepository
    {
        /// <summary>
        /// Traz todas as editoras.
        /// </summary>
        /// <returns>Retorna de todas as editoras.</returns>
        Task<List<Publisher>> GetAll();

        /// <summary>
        /// Traz uma editora pelo ID.
        /// </summary>
        /// <param name="id">ID da editora.</param>
        /// <returns>Editora encontrada.</returns>
        Task<Publisher> GetById(int id);

        /// <summary>
        /// Adiciona uma nova editora.
        /// </summary>
        /// <param name="publisher">Dados da nova editora.</param>
        /// <returns>Editora adicionada.</returns>
        Task<Publisher> Add(Publisher publisher);

        /// <summary>
        /// Atualiza uma editora existente.
        /// </summary>
        /// <param name="publisher">Dados da editora a serem atualizados.</param>
        /// <returns>Editora atualizada.</returns>
        Task<Publisher> Update(Publisher publisher);

        /// <summary>
        /// Deleta uma editora pelo ID.
        /// </summary>
        /// <param name="id">ID da editora a ser deletada.</param>
        Task Delete(int id);
    }
}