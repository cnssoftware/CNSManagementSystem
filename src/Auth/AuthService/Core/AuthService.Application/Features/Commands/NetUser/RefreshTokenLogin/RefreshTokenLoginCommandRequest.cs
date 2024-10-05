using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandRequest : IRequest<RefreshTokenLoginCommandResponse>
    {
        public string? RefreshToken { get; set; }
    }
}
