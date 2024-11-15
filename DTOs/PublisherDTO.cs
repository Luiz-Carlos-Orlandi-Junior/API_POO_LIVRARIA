namespace Livraria_Projeto.DTOs
{
    /// <summary>
    /// Data Transfer Object pra entidade Editora.
    /// </summary>
    public class PublisherDTO
    {
        /// <summary>
        /// ID da editora.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da editora.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Endereço da editora.
        /// </summary>
        public string Address { get; set; }
    }
}