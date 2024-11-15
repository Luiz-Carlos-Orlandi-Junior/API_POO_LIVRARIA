using System;

namespace Livraria_Projeto.Models
{
    /// <summary>
    /// Modelo que compoe um Movimento.
    /// </summary>
    public class Movement
    {
        /// <summary>
        /// ID do movimento.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID do livro vinculado ao movimento.
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Tipo do movimento (por exemplo, Empréstimo, Devolução).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Data do movimento.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Relacionamento com o livro do movimento.
        /// </summary>
        public Book Book { get; set; }
        
    }
}