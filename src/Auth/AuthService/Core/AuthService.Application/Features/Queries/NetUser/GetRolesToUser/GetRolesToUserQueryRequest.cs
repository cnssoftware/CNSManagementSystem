using MediatR;

namespace AuthService.Application.Features.Queries.NetUser.GetRolesToUser
{
    public class GetRolesToUserQueryRequest : IRequest<GetRolesToUserQueryResponse>
    {
        public string? UserId { get; set; }
    }
}
