namespace Livraria_Projeto.Models
{
    /// <summary>
    /// Modelo que compoe uma Editora.
    /// </summary>
    public class Publisher
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