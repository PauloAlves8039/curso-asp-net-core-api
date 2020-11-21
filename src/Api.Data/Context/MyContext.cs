using Microsoft.EntityFrameworkCore;
using src.Api.Data.Mapping;
using src.Api.Domain.Entities;

namespace src.Api.Data.Context
{
    /// <summary>
    /// Classe responsável pelo mapeamento e configurações das entidades com o banco de dados através de herança da classe de contexto DbContext.
    /// </summary>
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }
    }
}
