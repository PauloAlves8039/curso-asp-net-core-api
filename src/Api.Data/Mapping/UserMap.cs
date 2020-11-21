using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.Api.Domain.Entities;

namespace src.Api.Data.Mapping
{
    /// <summary>
    /// Classe responsável pelo mapeamento de entidade usuário no banco de dados.
    /// </summary>
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email)
                   .IsUnique();

            builder.Property(u => u.Nome)
                   .IsRequired()
                   .HasMaxLength(60);

            builder.Property(u => u.Email)
                   .HasMaxLength(100);
        }
    }
}
