namespace Livraria_Projeto.Models
{
    /// <summary>
    /// Modelo que compoe um Livro.
    /// </summary>
    public class Book
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
        /// ID do gênero vinculado ao livro.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Preço do livro.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Relacionamento com o gênero do livro.
        /// </summary>
        public Gender Gender { get; set; }
        
    }
}