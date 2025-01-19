using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesApi.Entities;

namespace MoviesApi.Configuratons;

public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder
            .ToTable("TB_USUARIOS");
        builder
            .HasKey(x => x.Id);
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder
            .Property(x => x.Nome)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .Property(x => x.Email)
            .HasMaxLength(80)
            .IsRequired();

        builder
            .HasIndex(x => x.Email)
            .IsUnique();

        builder
            .Property(x => x.Status)
            .IsRequired();

        builder
            .Property(x => x.Senha)
            .HasMaxLength(20)
            .IsRequired();

        builder
            .Property(x => x.Jwt)
            .HasMaxLength(500);
    }
}
