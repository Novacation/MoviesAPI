using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesApi.Entities;

namespace MoviesApi.Configuratons;

public class FilmeConfigurations : IEntityTypeConfiguration<Filme>
{
    public void Configure(EntityTypeBuilder<Filme> builder)
    {
        builder
            .ToTable("TB_FILMES");
        builder
            .HasKey(x => x.Id);
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder
            .Property(x => x.Nome)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .HasIndex(x => x.Nome)
            .IsUnique();

        builder
            .Property(x => x.AnoLancamento)
            .HasColumnName("Ano_Lancamento")
            .IsRequired();

        builder
            .Property(x => x.Diretor)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .Property(x => x.Status)
            .HasMaxLength(10)
            .IsRequired();

        builder
            .Property(x => x.Likes)
            .HasDefaultValue(0)
            .IsRequired();

        builder
            .Property(x => x.Dislikes)
            .HasDefaultValue(0)
            .IsRequired();
    }
}
