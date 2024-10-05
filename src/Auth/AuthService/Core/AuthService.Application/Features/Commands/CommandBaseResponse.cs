using Newtonsoft.Json;

namespace AuthService.Application.Features.Commands
{
    public class CommandBaseResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
