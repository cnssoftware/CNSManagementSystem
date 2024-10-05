using AuthService.Application.Abstraction.Services;
using MediatR;

namespace AuthService.Application.Features.Commands.NetRole.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommandRequest, CommandBaseResponse>
    {
        private readonly IRoleService _roleService;

        public CreateRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CommandBaseResponse> Handle(CreateRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _roleService.CreateRole(request.Name!);

            return new()
            {
                Success = result,
                Message = result ? "Role created successfully" : "Role creation failed"
            };
        }
    }
}
