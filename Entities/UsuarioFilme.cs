namespace MoviesApi.Entities;

public class UsuarioFilme(int idUsuario, int idFilme)
{
    public int Id { get; private set; }

    public int IdUsuario { get; private set; } = idUsuario;

    public int IdFilme { get; private set; } = idFilme;

    //propriedade de navegação
    public Usuario Usuario { get; private set; }
}
