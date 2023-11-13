using Git.Interfaces.TeachersInterfaces;
namespace Git.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<ITeachersService, TeachersService>();
            return services;         
        }

    }
}
