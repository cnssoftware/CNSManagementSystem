using Microsoft.AspNetCore.Identity;

namespace AuthService.Domain.Entities
{
    public class NetRole : IdentityRole<string>
    {
        public string? Description { get; set; }
    }
}
