using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models.Dashboard;

namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class RateCountRepository
    {
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<RateCountRepository> _logger;

		public RateCountRepository(ILogger<RateCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}
	}
}
