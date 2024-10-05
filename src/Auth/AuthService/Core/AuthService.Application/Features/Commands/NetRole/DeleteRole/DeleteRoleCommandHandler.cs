using AuthService.Application.Abstraction.Services;
using MediatR;

namespace AuthService.Application.Features.Commands.NetRole.DeleteRole
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommandRequest, CommandBaseResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public async Task<CommandBaseResponse> Handle(DeleteRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await  _roleService.DeleteRole(request.Id!);
            return new()
            {
                Success = result,
                Message = result ? "Role deleted successfully" : "Role not found"
            };
        }
    }
}
