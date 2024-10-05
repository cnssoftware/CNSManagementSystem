using Microsoft.AspNetCore.Identity;

namespace AuthService.Domain.Entities
{
    public  class NetUser : IdentityUser
    {
        public string? NameSurname { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }

    }
}
