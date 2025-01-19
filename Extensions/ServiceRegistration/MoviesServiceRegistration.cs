using MoviesApi.Repositories.Movies;
using MoviesApi.Services.Movies;

namespace MoviesApi.Extensions.ServiceRegistration;

public static class MoviesServiceRegistration
{
    public static void ExecuteMoviesServiceRegistration(this IServiceCollection services)
    {
        AddAuthServices(services);
        AddAuthRepositories(services);
    }

    private static void AddAuthServices(IServiceCollection services)
    {
        services.AddTransient<IMoviesServices, MoviesServices>();
    }

    private static void AddAuthRepositories(IServiceCollection services)
    {
        services.AddTransient<IMoviesRepository, MoviesRepository>();
    }
}
