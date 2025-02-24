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
    public class RevaluationRateRepository : IRevaluationRate
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public RevaluationRateRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<RevaluationRateViewModel> GetRevaluationRates()
        {
            var entry = (from b in appDbContext.RevaluationRates
                         select new RevaluationRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Days = b.Days,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             GbaseMsg = b.GbaseMsg,
                             ImportedTime = b.ImportedTime
                         })
                           .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.Days)
                        .ToList();
            return entry;
        }

        public IEnumerable<RevaluationRateViewModel> GetRevaluationRatesByDate(string date)
        {
            DateTime dataDate = DateTime.Parse(date);
            var entry = (from b in appDbContext.RevaluationRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new RevaluationRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Days = b.Days,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             GbaseMsg = b.GbaseMsg,
                             ImportedTime = b.ImportedTime
                         })
                           .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.Days)
                         .ToList();
            return entry;
        }

        public IEnumerable<RevaluationRateViewModel> GetRevaluationRatesByDateDistinct(string date)
        {
            DateTime dataDate = DateTime.Parse(date);
            var entry = (from b in appDbContext.RevaluationRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new RevaluationRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy
                             //Days = b.Days,
                             //Rate = b.Rate,
                             //ImportedBy = b.ImportedBy,
                             //RecStatus = b.RecStatus,
                             //GbaseMsg = b.GbaseMsg,
                             //ImportedTime = b.ImportedTime
                         })
                         .Distinct()
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                         .ToList();
            return entry;
        }

        public RevaluationRateViewModel GetRevaluationRateByDateCcyDay(string date, string ccy, int days)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.RevaluationRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                          && (b.Ccy == ccy) && (b.Days == days)
                         select new RevaluationRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Days = b.Days,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             GbaseMsg = b.GbaseMsg,
                             ImportedTime = b.ImportedTime
                         })
                         .FirstOrDefault();
            return entry;
        }

        public string AddRevaluationRate(RevaluationRate revaluationRate)
        {
            try
            {
                var entry = appDbContext.RevaluationRates
                      .Where(e => EF.Functions.DateDiffDay(e.DataDate, revaluationRate.DataDate) == 0
                       && e.Ccy == revaluationRate.Ccy && e.Days == revaluationRate.Days)
                      .FirstOrDefault();

                if (entry == null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (revaluationRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = revaluationRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (revaluationRate.Ccy) + "-" + revaluationRate.Days.ToString() + " Days",
                        AuditDesc = "Revaluation Rate INSERT",
                        AppName = "GUIDE",
                        TableName = "REVALUATION_RATE",
                        OriginalValue = "",
                        NewValue = revaluationRate.Rate.ToString(),
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.RevaluationRates.Add(revaluationRate);
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

        public string DeleteRevaluationRate(string date, string ccy, int days)
        {
            try
            {
                DateTime dataDate = DateTime.Parse(date);
                var entry = appDbContext.RevaluationRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, dataDate) == 0
                        && e.Ccy == ccy  && e.Days == days)
                       .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (entry.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = entry.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (entry.Ccy) + "-" + entry.Days.ToString() + " Days",
                        AuditDesc = "Revaluation Rate DELETION",
                        AppName = "GUIDE",
                        TableName = "REVALUATION_RATE",
                        OriginalValue = entry.Rate.ToString(),
                        NewValue = "",
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.RevaluationRates.Remove(entry);
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
    
        public string UpdateRevaluationRate(RevaluationRate revaluationRate)
        {
            try
            {
                var entry = appDbContext.RevaluationRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, revaluationRate.DataDate) == 0
                        && e.Ccy == revaluationRate.Ccy &&  e.Days == revaluationRate.Days)
                       .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (revaluationRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = revaluationRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (revaluationRate.Ccy) + "-" + revaluationRate.Days.ToString() + " Days",
                        AuditDesc = "Revaluation Rate update",
                        AppName = "GUIDE",
                        TableName = "REVALUATION_RATE",
                        OriginalValue = entry.Rate.ToString(),
                        NewValue = revaluationRate.Rate.ToString(),
                    };

                    if (entry.Rate != revaluationRate.Rate)
                        appDbContext.AuditLogs.Add(auditLog);

                    entry.Rate = revaluationRate.Rate;
                    entry.ImportedBy = (revaluationRate.ImportedBy).ToUpper();
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

        //NDF project - Revaluation Rate
        public RevaluationRate CheckRevaluationRateImportedTime(string SPConnection, DateTime rundate)
        {
            IEnumerable<RevaluationRate> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var parameters = new DynamicParameters();
                parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                query = _dapperAccess.LoadData<RevaluationRate, dynamic>("USP_GUIDE_RATES_DailyRevaluationRateLastImported2", parameters);

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

        public bool UploadRevaluationRate(string SPConnection, DateTime rundate, string user)
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
                var blnRtn = _dapperAccess.SaveData("USP_GUIDE_RATES_DailyRevaluationRate", parameters);
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
