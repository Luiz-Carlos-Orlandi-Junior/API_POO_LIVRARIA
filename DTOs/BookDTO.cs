namespace Livraria_Projeto.DTOs
{
    /// <summary>
    /// Data Transfer Object pra entidade Livro.
    /// </summary>
    public partial class BookDTO
    {
        /// <summary>
        /// ID do livro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título do livro.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Autor do livro.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// ID do gênero associado ao livro.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Preço do livro.
        /// </summary>
        public decimal Price { get; set; }
    }
}