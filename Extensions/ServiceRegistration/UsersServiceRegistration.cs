using MoviesApi.Repositories.Users;
using MoviesApi.Services.Users;

namespace MoviesApi.Extensions.ServiceRegistration;

public static class UsersServiceRegistration
{
    public static void ExecuteUsersServiceRegistration(this IServiceCollection services)
    {
        AddAuthServices(services);
        AddAuthRepositories(services);
    }

    private static void AddAuthServices(IServiceCollection services)
    {
        services.AddTransient<IUsersServices, UsersServices>();
    }

    private static void AddAuthRepositories(IServiceCollection services)
    {
        services.AddTransient<IUsersRepository, UsersRepository>();
    }
}
