using AuthService.Application.Abstraction.Services;
using AuthService.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Infrastructure
{
    public static class InfrastructureServiceRegistration 
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            serviceCollection.AddScoped<IMailService, MailService>();
        }
    }
}
