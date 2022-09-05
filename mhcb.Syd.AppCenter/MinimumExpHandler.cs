using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter
{
    public class MinimumExpHandler :  AuthorizationHandler<MinimumExpRequirement>
    {
        protected override Task HandleRequirementAsync(
                               AuthorizationHandlerContext context,
                               MinimumExpRequirement requirement)
        {
            var user = context.User;
            var claim = context.User.FindFirst("MinExperience");
            if (claim != null)
            {
                var expInYears = int.Parse(claim?.Value);
                if (expInYears >= requirement.MinimumExp)
                    context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public class EmployeeRequirement : IAuthorizationRequirement
    {
        //Write your code here
    }

    //public class EmployeeRoleHandler : AuthorizationHandler<EmployeeRequirement>
    //{
    //    //Write your code here to check if the user is an employee
    //        }
    //public class MinimumAgeHandler :   AuthorizationHandler<EmployeeRequirement>
    //{
    //    //Write your code here to validate min age
    //}
}
