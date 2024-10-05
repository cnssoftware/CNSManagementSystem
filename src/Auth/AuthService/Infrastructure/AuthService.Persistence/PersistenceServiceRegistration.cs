using AuthService.Application.Abstraction.Services;
using AuthService.Application.Abstraction.Services.Authentications;
using AuthService.Domain.Entities;
using AuthService.Persistence.Contexts;
using AuthService.Persistence.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuthServiceDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"));
            });

            services.AddIdentity<NetUser, NetRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<AuthServiceDbContext>()
           .AddDefaultTokenProviders();

            services.AddScoped<IAuthService, AuthService.Persistence.Services.AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IExternalAuthentication, AuthService.Persistence.Services.AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService.Persistence.Services.AuthService>();

        }
    }
}
