
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
using System.Linq;

namespace mhcb.Syd.Business.Repository.RATES
{
    public class SwapRateRepository : ISwapRate
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public SwapRateRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<SwapRateViewModel> GetSwapRates()
        {
            var entry = (from b in appDbContext.SwapRates
                         select new SwapRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Duration = b.Duration,
                             DurationUnit = b.DurationUnit,
                             BidRate = b.BidRate,
                             OfferRate = b.OfferRate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                          .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.DurationUnit).ThenBy(x4 => x4.Duration)
                         .ToList();
            return entry;
        }

        public IEnumerable<SwapRateViewModel> GetSwapRatesByDate(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.SwapRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new SwapRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Duration = b.Duration,
                             DurationUnit = b.DurationUnit,
                             BidRate = b.BidRate,
                             OfferRate = b.OfferRate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.DurationUnit).ThenBy(x4 => x4.Duration)
                         .ToList();
            return entry;
        }

        public IEnumerable<SwapRateViewModel> GetSwapRatesByDateDistinct(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.SwapRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new SwapRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy
                             //Duration = b.Duration,
                             //DurationUnit = b.DurationUnit,
                             //BidRate = b.BidRate,
                             //OfferRate = b.OfferRate,
                             //ImportedBy = b.ImportedBy,
                             //RecStatus = b.RecStatus,
                             //ImportedTime = b.ImportedTime
                         })
                         .Distinct()
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                         .ToList();
            return entry;
        }
        public SwapRateViewModel GetSwapRateByDateCcyDuration(string date, string ccy, int duration, string Unit)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.SwapRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                          && (b.Ccy == ccy) && (b.Duration == duration) && (b.DurationUnit == Unit)
                         select new SwapRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Duration = b.Duration,
                             DurationUnit = b.DurationUnit,
                             BidRate = b.BidRate,
                             OfferRate = b.OfferRate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                         .FirstOrDefault();
            return entry;
        }


        public string AddSwapRate(SwapRate swapRate)
        {
            try
            {
                var entry = appDbContext.SwapRates
                     .Where(e => EF.Functions.DateDiffDay(e.DataDate, swapRate.DataDate) == 0
                      && e.Ccy == swapRate.Ccy && e.Duration == swapRate.Duration && e.DurationUnit == swapRate.DurationUnit)
                     .FirstOrDefault();

                if (entry == null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (swapRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = swapRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (swapRate.Ccy),
                        AuditDesc = "SWAP Rate INSERT",
                        AppName = "GUIDE",
                        TableName = "SWAP_RATE",
                        OriginalValue = "",
                        NewValue = swapRate.BidRate.ToString() + ";" + swapRate.OfferRate.ToString(),
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.SwapRates.Add(swapRate);
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

        public string DeleteSwapRate(string date, string ccy, int duration, string Unit)
        {
            try
            {
                DateTime dataDate = DateTime.Parse(date);

                var entry = appDbContext.SwapRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, dataDate) == 0
                        && e.Ccy == ccy && e.Duration == duration && e.DurationUnit == Unit)
                       .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (entry.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = entry.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (entry.Ccy),
                        AuditDesc = "SWAP Rate DELETION",
                        AppName = "GUIDE",
                        TableName = "SWAP_RATE",
                        OriginalValue = entry.BidRate.ToString() + ";" + entry.OfferRate.ToString(),
                        NewValue = "",
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.SwapRates.Remove(entry);
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

        public string UpdateSwapRate(SwapRate swapRate)
        {
            try
            {
                var entry = appDbContext.SwapRates
                      .Where(e => EF.Functions.DateDiffDay(e.DataDate, swapRate.DataDate) == 0
                       && e.Ccy == swapRate.Ccy && e.Duration == swapRate.Duration && e.DurationUnit == swapRate.DurationUnit)
                      .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog1 = new()
                    {
                        UserId = (swapRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = swapRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (swapRate.Ccy) + "-" + swapRate.Duration.ToString() + "-" + swapRate.DurationUnit,
                        AuditDesc = "SWAP Rate UPDATE",
                        AppName = "GUIDE",
                        TableName = "SWAP_RATE",
                        OriginalValue = entry.BidRate.ToString(),
                        NewValue = swapRate.BidRate.ToString(),
                    };

                    if (entry.BidRate != swapRate.BidRate)
                        appDbContext.AuditLogs.Add(auditLog1);

                    AuditLog auditLog2 = new()
                    {
                        UserId = (swapRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = swapRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (swapRate.Ccy) + "-" + swapRate.Duration.ToString() + "-" + swapRate.DurationUnit,
                        AuditDesc = "SWAP Rate UPDATE",
                        AppName = "GUIDE",
                        TableName = "SWAP_RATE",
                        OriginalValue = entry.OfferRate.ToString(),
                        NewValue = swapRate.OfferRate.ToString(),
                    };

                    if (entry.OfferRate != swapRate.OfferRate)
                        appDbContext.AuditLogs.Add(auditLog2);

                    entry.BidRate = swapRate.BidRate;
                    entry.OfferRate = swapRate.OfferRate;
                    entry.ImportedBy = (swapRate.ImportedBy).ToUpper();
                    entry.ImportedTime = DateTime.Now;      //swapRate.ImportedTime;
              
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


        //NDF project - Market rate for NPV
        public SwapRate CheckSwapRateImportedTime(string SPConnection, DateTime rundate)
        {
            IEnumerable<SwapRate> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var parameters = new DynamicParameters();
                parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                query = _dapperAccess.LoadData<SwapRate, dynamic>("USP_GUIDE_RATES_DailyMarketRateForNPVLastImported2", parameters);

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

        public bool UploadSwapRate(string SPConnection, DateTime rundate, string user)
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
                var blnRtn = _dapperAccess.SaveData("USP_GUIDE_RATES_DailyMarketRateForNPVRate", parameters);
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
