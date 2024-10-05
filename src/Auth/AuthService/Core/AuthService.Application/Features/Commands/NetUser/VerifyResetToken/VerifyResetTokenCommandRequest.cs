using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.VerifyResetToken
{
    public class VerifyResetTokenCommandRequest : IRequest<VerifyResetTokenCommandResponse>
    {
        public string? ResetToken { get; set; }
        public string? UserId { get; set; }
    }
}
