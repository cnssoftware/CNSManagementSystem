using AuthService.Application.Abstraction.Services;
using AuthService.Application.Exceptions;
using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.UpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, CommandBaseResponse>
    {
        private readonly IUserService _userService;

        public UpdatePasswordCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CommandBaseResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            if (!request.Password!.Equals(request.PasswordConfirm))
                throw new PasswordChangeFailedException("Passwords do not match");

            await _userService.UpdatePasswordAsync(request.UserId!, request.ResetToken!, request.Password!);

            return new CommandBaseResponse() { Message = "Password updated successfully", Success = true };
        }
    }
}
