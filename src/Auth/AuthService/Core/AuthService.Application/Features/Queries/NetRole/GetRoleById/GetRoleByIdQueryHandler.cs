﻿using AuthService.Application.Abstraction.Services;
using MediatR;

namespace AuthService.Application.Features.Queries.NetRole.GetRoleById
{
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQueryRequest, GetRoleByIdQueryResponse>
    {
        readonly IRoleService _roleService;

        public GetRoleByIdQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetRoleByIdQueryResponse> Handle(GetRoleByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _roleService.GetRoleById(request.Id!);

            return new()
            {
                Id = data.id,
                Name = data.name
            };
        }
    }
}
