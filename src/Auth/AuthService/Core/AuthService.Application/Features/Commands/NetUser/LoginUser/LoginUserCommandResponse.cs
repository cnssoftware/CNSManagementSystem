using AuthService.Application.DTOs;
using Newtonsoft.Json;

namespace AuthService.Application.Features.Commands.NetUser.LoginUser
{
    public class LoginUserCommandResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
    public class LoginUserSuccessCommandResponse : LoginUserCommandResponse
    {
        public TokenDto? Token { get; set; }
    }
    public class LoginUserErrorCommandResponse : LoginUserCommandResponse
    {
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
