using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? NameSurname { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
    }
}
