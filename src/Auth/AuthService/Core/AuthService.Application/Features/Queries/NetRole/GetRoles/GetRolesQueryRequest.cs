using MediatR;

namespace AuthService.Application.Features.Queries.NetRole.GetRoles
{
    public class GetRolesQueryRequest : IRequest<GetRolesQueryResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
