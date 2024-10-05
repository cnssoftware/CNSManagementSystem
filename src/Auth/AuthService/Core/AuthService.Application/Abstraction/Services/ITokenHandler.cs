using AuthService.Application.DTOs;
using AuthService.Domain.Entities;

namespace AuthService.Application.Abstraction.Services
{
    public interface ITokenHandler
    {
        TokenDto CreateAccessToken(int second, NetUser appUser);
        string CreateRefreshToken();
    }
}
