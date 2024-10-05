using AuthService.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Persistence.Contexts
{
    public class AuthServiceDbContext : IdentityDbContext<NetUser, NetRole, string>
    {
        public AuthServiceDbContext(DbContextOptions options) : base(options) { }

    }
}
