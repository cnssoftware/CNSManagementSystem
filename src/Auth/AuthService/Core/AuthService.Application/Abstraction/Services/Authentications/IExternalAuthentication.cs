using AuthService.Application.DTOs;

namespace AuthService.Application.Abstraction.Services.Authentications
{
    public interface IExternalAuthentication
    {
        Task<TokenDto> FacebookLoginAsync(string authToken, int accessTokenLifeTime);
        Task<TokenDto> GoogleLoginAsync(string idToken, int accessTokenLifeTime);
    }
}
