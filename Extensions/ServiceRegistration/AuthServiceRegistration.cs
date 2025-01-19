using MoviesApi.Services.Auth;

namespace MoviesApi.Extensions.ServiceRegistration;

public static class AuthServiceRegistration
{
    public static void ExecuteAuthServiceRegistration(this IServiceCollection services)
    {
        AddAuthServices(services);
        AddAuthRepositories(services);
    }

    private static void AddAuthServices(IServiceCollection services)
    {
        services.AddTransient<IAuthServices, AuthServices>();
    }

    private static void AddAuthRepositories(IServiceCollection services)
    {
    }
}
