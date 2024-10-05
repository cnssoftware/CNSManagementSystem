using MediatR;

namespace AuthService.Application.Features.Commands.NetUser.AssignRoleToUser
{
    public class AssignRoleToUserCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? UserId { get; set; }
        public string[]? Roles { get; set; }
    }
}
