using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.UpdatePassword
{
    public class UpdatePasswordCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? UserId { get; set; }
        public string? ResetToken { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
    }
}
