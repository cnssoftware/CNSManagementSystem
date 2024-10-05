using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.FacebookLogin
{
    public class FacebookLoginCommandRequest : IRequest<FacebookLoginCommandResponse>
    {
        public string? AuthToken { get; set; }
    }
}
