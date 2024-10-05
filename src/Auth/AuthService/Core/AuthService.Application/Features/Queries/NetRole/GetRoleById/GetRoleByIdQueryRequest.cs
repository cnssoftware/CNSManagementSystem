using MediatR;

namespace AuthService.Application.Features.Queries.NetRole.GetRoleById
{
    public class GetRoleByIdQueryRequest : IRequest<GetRoleByIdQueryResponse>
    {
        public string? Id { get; set; }
    }
}
