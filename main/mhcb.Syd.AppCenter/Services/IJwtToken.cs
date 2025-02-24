﻿using System.Collections.Generic;
using System.Security.Claims;

namespace mhcb.Syd.AppCenter.Services
{
    public interface IJwtToken
    {
        string GenerateJwtTokenAuth();
        string GenerateJwtTokenByClaims(Claim[] claims);
        string GenerateJwtTokenByMember(string person);
        string GenerateJwtRefreshToken();
    }
}
