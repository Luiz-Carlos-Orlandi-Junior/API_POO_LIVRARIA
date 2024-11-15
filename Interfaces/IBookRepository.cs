using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Models;

namespace Livraria_Projeto.Interfaces
{
    /// <summary>
    /// Interface que concretiza as operações CRUD pra entidade Livro.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Traz todos os livros.
        /// </summary>
        /// <returns>Retorna de todos os livros.</returns>
        Task<List<Book>> GetAll();

        /// <summary>
        /// Traz um livro pelo ID.
        /// </summary>
        /// <param name="id">ID do livro.</param>
        /// <returns>Livro encontrado.</returns>
        Task<Book> GetById(int id);

        /// <summary>
        /// Adiciona um novo livro.
        /// </summary>
        /// <param name="book">Dados do novo livro.</param>
        /// <returns>Livro adicionado.</returns>
        Task<Book> Add(Book book);

        /// <summary>
        /// Atualiza um livro existente.
        /// </summary>
        /// <param name="book">Dados do livro a serem atualizados.</param>
        /// <returns>Livro atualizado.</returns>
        Task<Book> Update(Book book);

        /// <summary>
        /// Deleta um livro pelo ID.
        /// </summary>
        /// <param name="id">ID do livro a ser deletado.</param>
        Task Delete(int id);
    }
}