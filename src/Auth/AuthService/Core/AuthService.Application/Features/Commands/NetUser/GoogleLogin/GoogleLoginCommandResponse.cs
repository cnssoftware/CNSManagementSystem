using AuthService.Application.DTOs;

namespace AuthService.Application.Features.Commands.NetUser.GoogleLogin
{
    public class GoogleLoginCommandResponse
    {
        public TokenDto? Token { get; set; }
    }
}
