using MediatR;

namespace AuthService.Application.Features.Commands.NetRole.DeleteRole
{
    public class DeleteRoleCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? Id { get; set; }
    }
}
