namespace Livraria_Projeto.DTOs
{
    /// <summary>
    /// Data Transfer Object pra entidade Gênero.
    /// </summary>
    public class GenderDTO
    {
        /// <summary>
        /// ID do gênero.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do gênero.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descrição do gênero.
        /// </summary>
        public string Description { get; set; }
    }
}