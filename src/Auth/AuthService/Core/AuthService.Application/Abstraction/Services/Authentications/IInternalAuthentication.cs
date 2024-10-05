using AuthService.Application.DTOs;

namespace AuthService.Application.Abstraction.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<TokenDto> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<TokenDto> RefreshTokenLoginAsync(string refreshToken);
    }
}
