using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace mhcb.Syd.AppCenter.Services
{
    public class JwtToken : IJwtToken
    {
        //private readonly IUserSecurityService _userSecurityService;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IConfiguration _Configuration;
        public JwtToken(IConfiguration config)
        {
            _Configuration = config;
        }

        //***********************
        // 1.  get token by auth
        //***********************
        public string GenerateJwtTokenAuth()
        {
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey"));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                            issuer: _Configuration["Jwt:Issuer"],
                            audience: _Configuration["Jwt:Audience"],
                            expires: DateTime.Now.AddHours(1),
                            signingCredentials: credentials
                            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //***********************
        // 2. get token by claims
        //***********************
        public  string GenerateJwtTokenByClaims(Claim[] claims)
        {
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey"));
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                            issuer: _Configuration["Jwt:Issuer"],
                            audience: _Configuration["Jwt:Audience"],
                            expires: DateTime.Now.AddHours(1),
                            signingCredentials: credentials,
                            claims: claims
                            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        //***********************
        // 3.  get token by member
        //***********************
        public  string GenerateJwtTokenByMember(string person)
        {
            var claims = new[] {
                new Claim("Name", person)
            };

            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey"));
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                            issuer: "https://www.mizuho.com",
                            audience: _Configuration["Jwt:Audience"],
                            expires: DateTime.Now.AddHours(1),
                            signingCredentials: credentials,
                            claims: claims
                            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        //*******************************
        // 4.  get refresh token by auth
        //*******************************
        public string GenerateJwtRefreshToken()
        {
            string refreshKey = CreateRefreshToken();
            SetRefreshTokenCookie(refreshKey);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(refreshKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                            issuer: "https://www.mizuho.com",
                            audience: "https://www.mizuho.com",
                            expires: DateTime.Now.AddMinutes(30),
                            signingCredentials: credentials
                            );

            return new JwtSecurityTokenHandler().WriteToken(token);           
        }

        private string CreateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var generator = new RNGCryptoServiceProvider())
            {
                generator.GetBytes(randomNumber);
                string token = Convert.ToBase64String(randomNumber);
                return token;
            }
        }

        private void SetRefreshTokenCookie(string refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(1), // one day expiry time
            };     
            //Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }
    }
}
