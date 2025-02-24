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
    public class BisRateRepository : IBisRate
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public BisRateRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<BisRateViewModel> GetBisRates()
        {
            var entry = (from b in appDbContext.BisRates
                         select new BisRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Duration = b.Duration,
                             DurationUnit = b.DurationUnit,
                             BaseRate = b.BaseRate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.DurationUnit).ThenBy(x4 => x4.Duration)
                         .ToList();
            return entry;
        }

        public IEnumerable<BisRateViewModel> GetBisRatesByDate(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.BisRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new BisRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Duration = b.Duration,
                             DurationUnit = b.DurationUnit,
                             BaseRate = b.BaseRate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.DurationUnit).ThenBy(x4 => x4.Duration)
                         .ToList();
            return entry;
        }
        public IEnumerable<BisRateViewModel> GetBisRatesByDateDistinct(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.BisRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new BisRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy
                             //Duration = b.Duration,
                             //DurationUnit = b.DurationUnit,
                             //BaseRate = b.BaseRate,
                             //ImportedBy = b.ImportedBy,
                             //RecStatus = b.RecStatus,
                             //ImportedTime = b.ImportedTime
                         })
                         .Distinct()
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                         .ToList();
            return entry;
        }

        public BisRateViewModel GetBisRatesByDateCcyDuration(string date, string ccy, int duration, string Unit)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.BisRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         && b.Ccy == ccy && b.Duration == duration && b.DurationUnit == Unit
                         select new BisRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Duration = b.Duration,
                             DurationUnit = b.DurationUnit,
                             BaseRate = b.BaseRate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                         .FirstOrDefault();
            return entry;
        }

        public string AddBisRate(BisRate bisRate)
        {
            try
            {
                var entry = appDbContext.BisRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, bisRate.DataDate) == 0
                        && e.Ccy == bisRate.Ccy && e.Duration == bisRate.Duration && e.DurationUnit == bisRate.DurationUnit)
                       .FirstOrDefault();

                if (entry == null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (bisRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = bisRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (bisRate.Ccy) + "-" + bisRate.Duration.ToString() + bisRate.DurationUnit,
                        AuditDesc = "BIS Rate INSERT",
                        AppName = "GUIDE",
                        TableName = "BIS_RATE",
                        OriginalValue = "",
                        NewValue = bisRate.BaseRate.ToString(),
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.BisRates.Add(bisRate);
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

        public string DeleteBisRate(string date, string ccy, int duration, string Unit)
        {
            try
            {
                DateTime dataDate = DateTime.Parse(date);

                var entry = appDbContext.BisRates
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
                        TransNo = (entry.Ccy) + "-" + entry.Duration.ToString() + entry.DurationUnit,
                        AuditDesc = "BIS Rate DELETION",
                        AppName = "GUIDE",
                        TableName = "BIS_RATE",
                        OriginalValue = entry.BaseRate.ToString(),
                        NewValue = "",
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.BisRates.Remove(entry);
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

        public string UpdateBisRate(BisRate bisRate)
        {
            try
            {
                var entry = appDbContext.BisRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, bisRate.DataDate) == 0
                        && e.Ccy == bisRate.Ccy && e.Duration == bisRate.Duration && e.DurationUnit == bisRate.DurationUnit)
                       .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (bisRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = bisRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (bisRate.Ccy) + "-" + bisRate.Duration.ToString() + bisRate.DurationUnit,
                        AuditDesc = "BIS Rate update",
                        AppName = "GUIDE",
                        TableName = "BIS_RATE",
                        OriginalValue = entry.BaseRate.ToString() ,
                        NewValue = bisRate.BaseRate.ToString(),
                    };

                    if (entry.BaseRate != bisRate.BaseRate)
                        appDbContext.AuditLogs.Add(auditLog);

                    entry.BaseRate = bisRate.BaseRate;
                    entry.ImportedBy = (bisRate.ImportedBy).ToUpper();
                    entry.ImportedTime = DateTime.Now;  //bisRate.ImportedTime;

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


        //NDF project - BIS Rate
        public BisRate CheckBisRateImportedTime(string SPConnection, DateTime rundate)
        {
            IEnumerable<BisRate> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var parameters = new DynamicParameters();
                parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                query = _dapperAccess.LoadData<BisRate, dynamic>("USP_GUIDE_RATES_EOMBisRateLastImported2", parameters);

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

        public bool UploadBis(string SPConnection, DateTime rundate, string user)
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
                var blnRtn = _dapperAccess.SaveData("USP_GUIDE_RATES_EOMBisRate", parameters);
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
