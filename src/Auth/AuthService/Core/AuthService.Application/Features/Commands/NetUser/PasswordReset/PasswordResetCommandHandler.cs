using AuthService.Application.Abstraction.Services;
using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.PasswordReset
{
    public class PasswordResetCommandHandler : IRequestHandler<PasswordResetCommandRequest, CommandBaseResponse>
    {
        private readonly IAuthService _authService;
        public PasswordResetCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<CommandBaseResponse> Handle(PasswordResetCommandRequest request, CancellationToken cancellationToken)
        {
            await _authService.PasswordResetAsnyc(request.Email!);

            return new CommandBaseResponse()
            {
                Success = true,
                Message = "Password reset email sent"
            };
        }
    }
}
