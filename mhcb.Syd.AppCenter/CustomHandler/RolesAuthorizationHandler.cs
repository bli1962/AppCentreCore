//using CookieAuthenticationDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.CustomHandler
{
    public class RolesAuthorizationHandler : AuthorizationHandler<RolesAuthorizationRequirement>, IAuthorizationHandler
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       RolesAuthorizationRequirement requirement)
        {
            if (context.User == null || !context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            var IsValidRole = false;

            if (requirement.AllowedRoles == null ||
                requirement.AllowedRoles.Any() == false)
            {
                IsValidRole = true;
            }
            else
            {
                var claims = context.User.Claims;
                var userName = claims.FirstOrDefault(c => c.Type == "UserName").Value;
                var rolesDemand = requirement.AllowedRoles;

                // code for one role user to multi - claims
                //validRole = new Users().GetUsers().Where(p => rolesDemand.Contains(p.Role) && p.UserName == userName).Any();


                // code for multi-roles user to multi-claims
                string strRolesClaim = new Users().GetUsers()
                                 .Where(p => p.UserName == userName)
                                 .Select(p => p.Role).FirstOrDefault();

                List<string> RolesClaim = strRolesClaim.Split(',').ToList();

                foreach (string role in RolesClaim)
                {
                    IsValidRole = new Users().GetUsers().Where(p => p.UserName == userName && rolesDemand.Contains(role)).Any();
                    if (IsValidRole) break;
                }
            }

            if (IsValidRole)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
