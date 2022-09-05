using mhcb.Syd.AppCenter.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter
{
    public class JwtToken
    {
        //private readonly IUserSecurityService _userSecurityService;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public JwtToken(IUserSecurityService userSecurityService,
        //                IHttpContextAccessor httpContextAccessor)
        //{
        //    _userSecurityService = userSecurityService;
        //    _httpContextAccessor = httpContextAccessor;
        //}

        //private readonly IConfiguration _config;
        //public JwtToken(IConfiguration config)
        //{
        //    _config = config;
        //}
        public JwtToken()
        {
        }

        //****************
        // 1.
        //****************
        public static string GenerateJwtTokenByClaims(Claim[] claims)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey"));
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                                issuer: "https://www.mizuho.com",
                                audience: "https://www.mizuho.com",
                                expires: DateTime.Now.AddHours(3),
                                signingCredentials: credentials,
                                claims: claims
                                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        //****************
        // 2.
        //****************
        public static string GenerateJwtTokenAuth()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey"));
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                            issuer: "https://www.mizuho.com",
                            audience: "https://www.mizuho.com",
                            expires: DateTime.Now.AddMinutes(1),
                            signingCredentials: credentials
                            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        //****************
        // 3.
        //****************
        public static string GenerateJwtTokenByKey(string key, string person)
        {
            var claims = new[] {
                new Claim("Name", person)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                        issuer: "https://www.mizuho.com",
                        audience: "https://www.mizuho.com",
                        expires: DateTime.Now.AddHours(3),
                        signingCredentials: credentials,
                        claims: claims
                        );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }


}
