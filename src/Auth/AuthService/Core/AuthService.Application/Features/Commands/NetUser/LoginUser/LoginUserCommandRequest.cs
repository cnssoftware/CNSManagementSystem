using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string? UsernameOrEmail { get; set; }
        public string? Password { get; set; }
    }
}
