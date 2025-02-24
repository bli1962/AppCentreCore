using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace mhcb.Syd.Api.Data
{
	public class AppIdentityDbContext : IdentityDbContext
	{
		public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
			: base(options)
		{
		}
	}
}
