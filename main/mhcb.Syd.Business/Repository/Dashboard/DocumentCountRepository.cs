using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Models.Dashboard;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using mhcb.Syd.Interface.Dashboard;

namespace mhcb.Syd.Business.Repository.Dashboard
{
	public class DocumentCountRepository : IDocumentCount
	{
		private readonly EDocumentDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<DocumentCountRepository> _logger;

		public DocumentCountRepository(ILogger<DocumentCountRepository> logger,
										IConfiguration configuration,
										EDocumentDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

		public List<StatusCounterDTO> GetDocumentStatusCount(string strDate)
		{
			DateTime dtDate = DateTime.Parse(strDate);

			var query = appDbContext.GBaseDocuments.Where(t => 
						EF.Functions.DateDiffDay(t.DateProcessed, dtDate) == 0 && t.Errored == true)
						.GroupBy(x => x.Errored)
						.Select(g => new StatusCounterDTO
						{
							Status = "Error",
							Count = g.Count(),
							Description = "Error in process"
						})
						.ToList();

			return query;
		}
	}

}
