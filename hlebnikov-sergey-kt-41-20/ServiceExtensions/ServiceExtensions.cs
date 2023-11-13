using hlebnikov_sergey_kt_41_20.Interfaces.TeachersInterfaces;
namespace hlebnikov_sergey_kt_41_20.ServiceExtensions
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
