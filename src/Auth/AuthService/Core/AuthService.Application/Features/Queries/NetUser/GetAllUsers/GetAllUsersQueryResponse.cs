namespace AuthService.Application.Features.Queries.NetUser.GetAllUsers
{
    public class GetAllUsersQueryResponse
    {
        public object? Users { get; set; }
        public int TotalUsersCount { get; set; }
    }
}
