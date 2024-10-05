using MediatR;

namespace AuthService.Application.Features.Commands.NetRole.UpdateRole
{
    public class UpdateRoleCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
}
