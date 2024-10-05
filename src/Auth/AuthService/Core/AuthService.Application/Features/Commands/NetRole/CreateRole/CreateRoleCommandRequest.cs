using MediatR;

namespace AuthService.Application.Features.Commands.NetRole.CreateRole
{
    public class CreateRoleCommandRequest : IRequest<CommandBaseResponse>
    {
        public string? Name { get; set; }
    }
}
