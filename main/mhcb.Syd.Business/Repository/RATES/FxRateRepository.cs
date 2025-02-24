
using mhcb.Syd.Business.DbAccess;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using Dapper;
using System.Data.SqlClient;
using mhcb.Syd.DataAccess.Models.LOAN;
using System.Security.Cryptography;
using AuditLog = mhcb.Syd.DataAccess.Models.GUIDE.AuditLog;

namespace mhcb.Syd.Business.Repository.RATES
{
    public class FxRateRepository : IFxRate
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public FxRateRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<FxRateViewModel> GetFxRates()
        {
            var entry = (from b in appDbContext.FxRates
                         select new FxRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Bid = b.Bid,
                             Offer = b.Offer,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = (DateTime)b.ImportedTime
                         })
                           .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                         .ToList();
            return entry;
        }

        public IEnumerable<FxRateViewModel> GetFxRatesByDate(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.FxRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new FxRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Bid = b.Bid,
                             Offer = b.Offer,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = (DateTime)b.ImportedTime
                         })
                           .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                       .ToList();
            return entry;
        }

        public IEnumerable<FxRateViewModel> GetFxRatesByDateDistinct(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.FxRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new FxRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy
                             //Bid = b.Bid,
                             //Offer = b.Offer,
                             //Rate = b.Rate,
                             //ImportedBy = b.ImportedBy,
                             //RecStatus = b.RecStatus,
                             //ImportedTime = (DateTime)b.ImportedTime
                         })
                         .Distinct()
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                       .ToList();
            return entry;
        }

        public FxRateViewModel GetFxRateByDateCcy(string date, string ccy)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.FxRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         && (b.Ccy == ccy)
                         select new FxRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Bid = b.Bid,
                             Offer = b.Offer,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = (DateTime)b.ImportedTime
                         })
                      .FirstOrDefault();
            return entry;
        }

        public string AddFxRate(FxRate fxRate)
        {
            try
            {
                var entry = appDbContext.FxRates
                     .Where(e => EF.Functions.DateDiffDay(e.DataDate, fxRate.DataDate) == 0
                          && e.Ccy == fxRate.Ccy)
                     .FirstOrDefault();

                if (entry == null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (fxRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = fxRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (fxRate.Ccy),
                        AuditDesc = "Fx Rate INSERT",
                        AppName = "GUIDE",
                        TableName = "FX_RATE",
                        OriginalValue = "",
                        NewValue = fxRate.Bid.ToString() + ";" + fxRate.Offer.ToString() + ";" + fxRate.Rate.ToString(),
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.FxRates.Add(fxRate);
                    appDbContext.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "Found";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string DeleteFxRate(string date, string ccy)
        {
            try
            {
                DateTime dataDate = DateTime.Parse(date);

                var entry = appDbContext.FxRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, dataDate) == 0
                            && e.Ccy == ccy)
                       .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog1 = new()
                    {
                        UserId = (entry.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = entry.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (entry.Ccy),
                        AuditDesc = "FX Rate DELETION",
                        AppName = "GUIDE",
                        TableName = "FX_RATE",
                        OriginalValue = entry.Bid.ToString(),
                        NewValue = "",
                    };
                    appDbContext.AuditLogs.Add(auditLog1);

                    appDbContext.FxRates.Remove(entry);
                    appDbContext.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "NotFound";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string UpdateFxRate(FxRate fxRate)
        {
            try
            {
                var entry = appDbContext.FxRates
                      .Where(e => EF.Functions.DateDiffDay(e.DataDate, fxRate.DataDate) == 0
                           && e.Ccy == fxRate.Ccy)
                      .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog1 = new()
                    {
                        UserId = (fxRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = fxRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (fxRate.Ccy),
                        AuditDesc = "Fx Rate update - BID",
                        AppName = "GUIDE",
                        TableName = "FX_RATE",
                        OriginalValue = entry.Bid.ToString(),
                        NewValue = fxRate.Bid.ToString(),
                    };
                    if (entry.Bid != fxRate.Bid)
                        appDbContext.AuditLogs.Add(auditLog1);

                   AuditLog auditLog2 = new()
                    {
                        UserId = (fxRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = fxRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (fxRate.Ccy),
                        AuditDesc = "Fx Rate update Offer",
                        AppName = "GUIDE",
                        TableName = "FX_RATE",
                        OriginalValue = entry.Offer.ToString(),
                        NewValue = fxRate.Offer.ToString(),
                    };
                    if (entry.Offer != fxRate.Offer)
                        appDbContext.AuditLogs.Add(auditLog2);

                    AuditLog auditLog3 = new()
                    {
                        UserId = (fxRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = fxRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (fxRate.Ccy),
                        AuditDesc = "Fx Rate update Rate",
                        AppName = "GUIDE",
                        TableName = "FX_RATE",
                        OriginalValue = entry.Rate.ToString(),
                        NewValue = fxRate.Rate.ToString(),
                    };
                    if (entry.Rate != fxRate.Rate)
                        appDbContext.AuditLogs.Add(auditLog3);

                    entry.Bid = fxRate.Bid;
                    entry.Offer = fxRate.Offer;
                    entry.Rate = fxRate.Rate;
                    entry.ImportedBy = (fxRate.ImportedBy).ToUpper();
                    entry.ImportedTime = DateTime.Now;  

                    appDbContext.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "NotFound";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        //NDF project - Fx rates
        public FxRate CheckDailyFXRateImportedTime(string SPConnection, DateTime rundate)
        {
            IEnumerable<FxRate> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var parameters = new DynamicParameters();
                parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                query = _dapperAccess.LoadData<FxRate, dynamic>("USP_GUIDE_RATES_DailyExchangeRateLastImported2", parameters);

                return query.FirstOrDefault();
            }
            catch
            {
                return null;
            }
            finally
            {
                _dapperAccess = null;
            }
        }

        public bool UploadFxRate(string SPConnection, DateTime rundate, string user)
        {
            int intRtnValue = 0;
            string strErrMsg = null;

            var parameters = new DynamicParameters();
            parameters.Add("@AffectedID", dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("@RowAffected", dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("@ValidCode", dbType: DbType.Int32, direction: ParameterDirection.Output);

            parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameters.Add("@OPERATOR", user, dbType: DbType.String, direction: ParameterDirection.Input);

            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var blnRtn = _dapperAccess.SaveData("USP_GUIDE_RATES_DailyExchangeRate", parameters);
            }
            catch (Exception ex)
            {
                //LogWriter.ErrorFormat("Exception Caught:\r\n{0}", ex);
                strErrMsg = ex.Message.ToString();
            }
            finally
            {
                intRtnValue = parameters.Get<int>("@ValidCode");
                _dapperAccess = null;
            }

            if (intRtnValue == 0 && string.IsNullOrEmpty(strErrMsg))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
       
      
    }
}
