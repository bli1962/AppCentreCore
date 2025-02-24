using mhcb.Syd.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Transactions;


namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class TempRepository
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<TempRepository> _logger;

		public TempRepository(ILogger<TempRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

        public List<object> CountFxTransactionStatus(string strDate)
		{
            if (!(strDate != null)) return new List<object>();
            DateTime dtDate = DateTime.Parse(strDate);

            // Create a new Stopwatch instance
            Stopwatch stopwatch = new Stopwatch();

            // Start the Stopwatch before executing the query
            stopwatch.Start();

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

			using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
			{
                var query = from cust in appDbContext.CustomerMasters
                            join fx in appDbContext.FxTransactions on cust.CustAbbr equals fx.CustAbbr
                            where fx.TranNo == ""
									&& (EF.Functions.DateDiffDay(fx.AddOn, dtDate) == 0)
                            group fx by cust.CustAbbr into customerGroup
                            select new
                            {
                                CustAbbr = customerGroup.Key,
                                TotalOrders = customerGroup.Count(),
                                TotalAmount = customerGroup.Sum(o => o.ContractCcyAmt),
                                Transactions = customerGroup
                            };

				// Execute the query (e.g., by iterating over the results)
				var results = query.ToList().ConvertAll(i => (object)i);

                // Stop the Stopwatch after the query execution
                stopwatch.Stop();

                // Display the elapsed time
                //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
                _logger.LogInformation($"Execution Time of CountFxTransactionStatus(): {stopwatch.ElapsedMilliseconds} ms");

				return results;
            }
		}




		//url: "<%= GetFXWebServiceURL() %>" + "/CountFxTransactionsInStatus",
		//[WebMethod]
		//public List<StatusCounterDTO> CountFxTransactionsInStatusByDate(DateTime date)
		//{
		//    LogHelper.LogParams(_logWriter, MethodBase.GetCurrentMethod(), date);

		//    try
		//    {
		//        _logWriter.DebugFormat("Begin CountFxTransactionsInStatus");
		//        List<StatusCounterDTO> counter = new ForeignExchangeBusSev().CountFxTransactionsInStatusByDate(date);
		//        _logWriter.DebugFormat("End CountFxTransactionsInStatus");
		//        return counter;
		//    }
		//    catch (Exception ex)
		//    {
		//        _logWriter.ErrorFormat("Exception Caught:\r\n{0}", ex);
		//    }
		//    return null;
		//}


		//url: "<%= GetFXWebServiceURL() %>" + "/CountFxTransactionConfirmationInStatus",
		//[WebMethod]
		//[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
		//public List<TransactionConfirmationStatusCountDTO> CountFxTransactionConfirmationInStatusDate(DateTime date)
		//{
		//    LogHelper.LogParams(_logWriter, MethodBase.GetCurrentMethod(), date);

		//    try
		//    {
		//        _logWriter.DebugFormat("Begin CountFxTransactionConfirmationInStatus");
		//        List<TransactionConfirmationStatusCountDTO> counter = new ForeignExchangeBusSev().CountTransactionConfirmationStatus(date);
		//        _logWriter.DebugFormat("End CountFxTransactionConfirmationInStatus");
		//        return counter;
		//    }
		//    catch (Exception ex)
		//    {
		//        _logWriter.ErrorFormat("Exception Caught:\r\n{0}", ex);
		//    }
		//    return null;
		//}


		//url: "<%= GetFXWebServiceURL() %>" + "/CountFxDeliveriesInStatus",
		//[WebMethod]
		//[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
		//public List<StatusCounterDTO> CountFxDeliveriesInStatus()
		//{
		//    LogHelper.LogParams(_logWriter, MethodBase.GetCurrentMethod());

		//    DateTime date = GetDate();
		//    return CountFxDeliveriesInStatusByDate(date);
		//}




		//url: "<%= GetDistributionWebServiceURL() %>" + "/CountDistributionsByStatus",



		//url: "<%= GetDocumentationWebServiceURL() %>" + "/CountErroredDocuments",


		//url: "<%= GetCustomerWebServiceURL() %>" + "/CountCustomersInStatus",
		//[WebMethod]
		//[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
		//public List<StatusCounterDTO> CountCustomersInStatus()
		//{
		//    LogHelper.LogParams(_logWriter, MethodBase.GetCurrentMethod());

		//    try
		//    {
		//        _logWriter.DebugFormat("Begin CountCustomersInStatus ");

		//        List<StatusCounterDTO> list = new Customer_Master_BusServ().CountCustomersInStatus();

		//        _logWriter.DebugFormat("End CountCustomersInStatus ");
		//        return list;
		//    }
		//    catch (Exception ex)
		//    {
		//        _logWriter.ErrorFormat("Exception Caught:\r\n{0}", ex);
		//        return null;
		//    }
		//}


		//url: "<%= GetSIFWebServiceURL() %>" + "/CountSifsInStatus",
		//[WebMethod]
		//[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
		//public List<StatusCounterDTO> CountSifsInStatus()
		//{
		//    LogHelper.LogParams(_logWriter, MethodBase.GetCurrentMethod());

		//    try
		//    {
		//        _logWriter.DebugFormat("Begin CountSIFSInStatus ");
		//        List<StatusCounterDTO> list = new SETTLEMENT_INF_BusSev().CountSIFSInStatus();
		//        _logWriter.DebugFormat("End CountSIFSInStatus ");
		//        return list;
		//    }
		//    catch (Exception ex)
		//    {
		//        _logWriter.ErrorFormat("Exception Caught:\r\n{0}", ex);
		//        return null;
		//    }
		//}



		//	url: "<%= GetBIFWebServiceURL() %>" + "/CountBIFSInStatus",
		//[WebMethod]
		//[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
		//public List<StatusCounterDTO> CountBIFSInStatus()
		//{
		//    List<StatusCounterDTO> list = new BANK_INF_BusSev().CountBIFSInStatus();
		//    return list;
		//}


		// Payment Control - Go payment controller  in GUIDE.web
		//url: "<%= GetPaymentsWebServiceURL() %>" + "/Payment/Queue?Token=<%= Session["Token"] %>" + "&date=" + new Date().getFullYear() + "-" + (new Date().getMonth() + 1) + "-" + new Date().getDate() ,


		// Money market - GUIDE.WebApi Controllers/ api/MoneyMarket
		//url: "<%= GetGuideWebServiceURL() %>" + "/api/MoneyMarket/Dashboard?Token=<%= Session["Token"] %>",

	}
}
