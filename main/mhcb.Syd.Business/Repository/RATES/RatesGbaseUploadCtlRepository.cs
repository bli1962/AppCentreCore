using Dapper;
using mhcb.Syd.Business.DbAccess;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;

namespace mhcb.Syd.Business.Repository.RATES
{
	public class RatesGbaseUploadCtlRepository : IRatesGbaseUploadCtl
	{
		private readonly GUIDEDbContext appDbContext;
		private SqlDataAccess _dapperAccess;

		public RatesGbaseUploadCtlRepository()
		{
		}

		public RatesGbaseUploadCtlRepository(GUIDEDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
		}

        public Boolean Create_GbaseRates_Upload_Ctrl(string SPConnection, string SP, DateTime rundate, string Operator) //RateTypes rateType)
        {
			_dapperAccess = new SqlDataAccess(SPConnection);
			var parameters = new DynamicParameters();
			parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
			parameters.Add("@Operator", Operator, dbType: DbType.String, direction: ParameterDirection.Input);

			int intRowCount = _dapperAccess.SaveData(SP, parameters);
            return (intRowCount > 0) ? true : false;
        }

        public List<RatesGbaseUploadCtl> SelectRateCtlByRateType(string SPConnection, DateTime rundate, RateTypes rateType)
		{
			List<RatesGbaseUploadCtl> query;
			try
			{
                //_dapperAccess = new SqlDataAccess(SPConnection);
                //var parameters = new DynamicParameters();
                //parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                //parameters.Add("@RATE_TYPE", rateType, dbType: DbType.String, direction: ParameterDirection.Input);

                //query = _dapperAccess.LoadData<RatesGbaseUploadCtl, dynamic>("USP_GUIDE_SELECT_RATES_CTL_BY_RATE_TYPE", parameters);

                //List<RatesGbaseUploadCtl> lstReturn = query.ToList();
                //return lstReturn;

                //var entry = appDbContext.AuditLogs
                //               .Where(e => EF.Functions.DateDiffDay(e.AuditDate, date) == 0)
                //               .OrderByDescending(e => e.AuditId)
                //               //.Take(50)
                //               .ToList();
                //return entry;


                //--Flag value defination
                //--ACU_XXX for 751
                //--BU_XXX for 784

                if (rateType.ToString() != "BIS_Rate")
                    query =(from b in appDbContext.RatesGbaseUploadCtls
							.Where(e => e.RateType == rateType.ToString()
									&& EF.Functions.DateDiffDay(e.OprDate, rundate) == 0)
							select new RatesGbaseUploadCtl()
							{
								RateType = b.RateType,
								OprDate = (DateTime)b.OprDate,
								Ccy = b.Ccy,
								UploadedBy = b.UploadedBy,
								AcuStatus = b.AcuStatus ?? "P",
								BuStatus = b.BuStatus ?? "P",
								GbaseMsg = b.GbaseMsg ?? "",
								AcuTransStatus = b.AcuTransStatus ?? "N",
								BuTransStatus = b.BuTransStatus ?? "N",
                                NavigatorLink =
                                (
                                    b.RateType == "FX_RATE" ? "./ListFxRate/" + b.OprDate.ToString("yyyy-MM-dd") :
                                    b.RateType == "REVALUATION_RATE" ? "./ListRevaluationRate/" + b.OprDate.ToString("yyyy-MM-dd") :
                                    b.RateType == "SWAP_RATE" ? "./ListSwapRate/" + b.OprDate.ToString("yyyy-MM-dd") :
                                    b.RateType == "DEPOSITS_RATE" ? "./ListDepositsRate/" + b.OprDate.ToString("yyyy-MM-dd") : ""
                                )
                               
                            })
							.OrderBy(x1 => x1.OprDate).ThenBy(x2 => x2.RateType).ThenBy(x3 => x3.Ccy)
							.ToList();
				else
					query = (from b in appDbContext.RatesGbaseUploadCtls
							.Where(e => e.RateType == rateType.ToString()
										&& EF.Functions.DateDiffDay(e.OprDate,
										new DateTime(rundate.Year, rundate.Month, DateTime.DaysInMonth(rundate.Year, rundate.Month)))
										 == 0)
							select new RatesGbaseUploadCtl()
							{
								RateType = b.RateType,
								OprDate = (DateTime)b.OprDate,
								Ccy = b.Ccy,
								UploadedBy = b.UploadedBy,
								AcuStatus = b.AcuStatus ?? "P",
								BuStatus = b.BuStatus ?? "P",
								GbaseMsg = b.GbaseMsg ?? "",
								AcuTransStatus = b.AcuTransStatus ?? "N",
								BuTransStatus = b.BuTransStatus ?? "N",
                                NavigatorLink = "./ListBisRate/" + b.OprDate.ToString("yyyy-MM-dd")
                            })
							.OrderBy(x1 => x1.OprDate).ThenBy(x2 => x2.RateType).ThenBy(x3 => x3.Ccy)
							.ToList();
			}
			catch
			{
				return null;
			}
			finally
			{
				//_dapperAccess = null;				
			}
            return query;
        }


        // Call when sending message unsuccessfully.
        public bool UpdateRatesGbaseUploadCtlStatus(RatesUploadCtrl ratesUploadCtrl)
		{
			//using (GUIDEEntities guideContext = new GUIDEEntities())
			//{
			//guideContext.Database.Log = s => _BusiLogWriter.DebugFormat("EF6 SQL Logging ={0}", s);

			var query = appDbContext.RatesGbaseUploadCtls
						.Where(s => s.RateType == ratesUploadCtrl.RateType.ToString()
								//&& s.CCY == ratesSearchDto.CcyId	  // there was bug in the current system, CcyID is empty here
								//&& SqlFunctions.DateDiff("DAY", s.OPR_DATE, ratesSearchDto.OperatedDate) == 0);	 
								//SqlFunctions.DateDiff is not supported in Dbcontext object
								&& s.OprDate == ratesUploadCtrl.OperatedDate);
			try
			{
				foreach (var rates in query)
				{
					if (ratesUploadCtrl.BranchNo == "751")
					{
						rates.AcuStatus = ratesUploadCtrl.InputStatus;
					}
					else
						rates.BuStatus = ratesUploadCtrl.InputStatus;

					appDbContext.Entry(rates).State = (EntityState)System.Data.Entity.EntityState.Modified;
				}
				appDbContext.SaveChanges();
			}
			catch (DbEntityValidationException ex)
			{
				foreach (var eve in ex.EntityValidationErrors)
				{
					//log.DebugFormat("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
					//				eve.Entry.Entity.GetType().Name, eve.Entry.State);

					foreach (var ve in eve.ValidationErrors)
					{
						//log.DebugFormat("- Property: \"{0}\", Error: \"{1}\"",
						//			ve.PropertyName, ve.ErrorMessage);
					}
				}
			}
			return true;
		}

	}
}
