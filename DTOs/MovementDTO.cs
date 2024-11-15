using System;

namespace Livraria_Projeto.DTOs
{
    /// <summary>
    /// Data Transfer Object pra entidade Movimento.
    /// </summary>
    public class MovementDTO
    {
        /// <summary>
        /// ID do movimento.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID do livro vinculada ao movimento.
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
    }
}