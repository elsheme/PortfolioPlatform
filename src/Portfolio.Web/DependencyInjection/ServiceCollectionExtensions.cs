namespace Portfolio.Web.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register application/service implementations here.
        return services;
    }

    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        // Register DbContext, repositories, and database configuration here.
        return services;
    }
}
