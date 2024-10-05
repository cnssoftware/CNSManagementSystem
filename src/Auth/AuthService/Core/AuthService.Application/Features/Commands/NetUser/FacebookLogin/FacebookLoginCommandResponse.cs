using AuthService.Application.DTOs;

namespace AuthService.Application.Features.Commands.NetUser.FacebookLogin
{
    public class FacebookLoginCommandResponse
    {
        public TokenDto? Token { get; set; }
    }
}
