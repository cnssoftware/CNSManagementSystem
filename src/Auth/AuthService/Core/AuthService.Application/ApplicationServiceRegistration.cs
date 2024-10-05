using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AuthService.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

        }
    }
}
