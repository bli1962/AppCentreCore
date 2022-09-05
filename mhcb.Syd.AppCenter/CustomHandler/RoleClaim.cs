using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.CustomHandler
{
    public class RoleClaim
    {
        public ClaimsPrincipal CreateClaims(Users users, List<string> roles)
        {
            var validUser = new Users().GetUsers().Where(u => u.UserName == users.UserName).SingleOrDefault();

            if (validUser != null)
            {
                var userClaims = new List<Claim>()
                {
                    new Claim("UserName", validUser.UserName),
                    new Claim(ClaimTypes.Name, validUser.Name),
                    //new Claim(ClaimTypes.Email, user.EmailId),
                    //new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth),
                    new Claim(ClaimTypes.Role, validUser.Role)
                 };

                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });

                return userPrincipal;
                //HttpContext.SignInAsync(userPrincipal);
                //return RedirectToAction("Index", "Home");
            }
            return null;
        }
    }
}
