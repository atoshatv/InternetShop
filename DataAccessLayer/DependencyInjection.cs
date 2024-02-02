#define Moq

using DataAccessLayer.Interfaces;
using DataAccessLayer.Reposetories;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services) 
        {
#if Moq
            services.AddScoped<IUserRepository, UserRepositoryMoq>();
#else
            services.AddScoped<IUserRepository, UserRepository>();
#endif
            return services;
        }
    }
}
