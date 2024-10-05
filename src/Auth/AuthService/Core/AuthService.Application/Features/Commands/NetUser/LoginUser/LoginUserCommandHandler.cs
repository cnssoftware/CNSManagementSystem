using AuthService.Application.Abstraction.Services;
using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IAuthService _authService;
        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.LoginAsync(request.UsernameOrEmail!, request.Password!, 900);

            if (token == null)
            {
                return new LoginUserErrorCommandResponse()
                {
                    Success = false,
                    Message = "Invalid username or password"
                };
            }

            return new LoginUserSuccessCommandResponse()
            {
                Token = token,
                Success = true
            };
        }
    }
}
