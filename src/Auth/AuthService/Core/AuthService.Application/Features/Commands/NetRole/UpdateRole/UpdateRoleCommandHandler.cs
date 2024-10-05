using AuthService.Application.Abstraction.Services;
using MediatR;

namespace AuthService.Application.Features.Commands.NetRole.UpdateRole
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommandRequest, CommandBaseResponse>
    {
        readonly IRoleService _roleService;

        public UpdateRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CommandBaseResponse> Handle(UpdateRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _roleService.UpdateRole(request.Id!, request.Name!);

            return new()
            {
                Success = result,
                Message = result ? "Role updated successfully" : "Role not found"
            };
        }
    }
}
