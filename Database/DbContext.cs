using Livraria_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Projeto.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}