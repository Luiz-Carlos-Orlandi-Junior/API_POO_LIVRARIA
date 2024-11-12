using Livraria_Projeto.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Livraria_Projeto.Database
{

    public partial class LDbcontext : DbContext
    {
        public LDbcontext()
        {

        }


        public LDbcontext(DbContextOptions<LDbcontext> options)
         : base(options)
        {

        }

        public virtual DbSet<Products> Livros { get; set; }
        public virtual DbSet<Gender> Generos { get; set; }
        public virtual DbSet<Funcionarios> Funcionarios { get; set; }
    }
}

