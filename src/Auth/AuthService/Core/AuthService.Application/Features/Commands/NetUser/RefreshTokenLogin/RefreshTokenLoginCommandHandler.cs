using AuthService.Application.Abstraction.Services;
using AuthService.Application.DTOs;
using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandHandler : IRequestHandler<RefreshTokenLoginCommandRequest, RefreshTokenLoginCommandResponse>
    {
        readonly IAuthService _authService;
        public RefreshTokenLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<RefreshTokenLoginCommandResponse> Handle(RefreshTokenLoginCommandRequest request, CancellationToken cancellationToken)
        {
            TokenDto token = await _authService.RefreshTokenLoginAsync(request.RefreshToken!);

            return new()
            {
                Token = token
            };
        }
    }
}
