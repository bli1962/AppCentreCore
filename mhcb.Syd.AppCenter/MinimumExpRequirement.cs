using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter
{
    public class MinimumExpRequirement : IAuthorizationRequirement
    {
        public int MinimumExp { get; set; }
        public MinimumExpRequirement(int experience)
        {
            MinimumExp = experience;
        }
    }
}
