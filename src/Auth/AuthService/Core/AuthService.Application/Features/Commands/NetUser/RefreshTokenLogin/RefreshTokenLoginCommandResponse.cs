using AuthService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Application.Features.Commands.NetUser.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandResponse
    {
        public TokenDto? Token { get; set; }
    }
}
