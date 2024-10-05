using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.PasswordReset
{
    public class PasswordResetCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? Email { get; set; }
    }
}
