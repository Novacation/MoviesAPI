using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesApi.Entities;

namespace MoviesApi.Configuratons;

public class UsuarioFilmeConfigurations : IEntityTypeConfiguration<UsuarioFilme>
{
    public void Configure(EntityTypeBuilder<UsuarioFilme> builder)
    {
        builder
            .ToTable("TB_USUARIO_FILME");
        builder
            .HasKey(x => x.Id);
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();


        //Define que vai ter um usuário ligado a linha dessa tabela, porém o mesmo usuário pode aparecer várias vezes (WithMany) e a chave estrangeira  é a propriedade IdUsuario
        builder
            .HasOne(x => x.Usuario)
            .WithMany()
            .HasForeignKey(x => x.IdUsuario)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
