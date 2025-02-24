
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
    public class DepositRateRepository : IDepositsRate
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public DepositRateRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<DepositsRateViewModel> GetDepositsRates()
        {
            var entry = (from b in appDbContext.DepositsRates
                         select new DepositsRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Period = b.Period,
                             Bid = b.Bid,
                             Offer = b.Offer,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.Period)
                       .ToList();

            return entry;
        }

        public IEnumerable<DepositsRateViewModel> GetDepositsRatesByDate(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.DepositsRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new DepositsRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Period = b.Period,
                             Bid = b.Bid,
                             Offer = b.Offer,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                           .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy).ThenBy(x3 => x3.Period)
                     .ToList();

            return entry;
        }

        public IEnumerable<DepositsRateViewModel> GetDepositsRatesByDateDistinct(string date)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.DepositsRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                         select new DepositsRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             //Period = b.Period,
                             //Bid = b.Bid,
                             //Offer = b.Offer,
                             //Rate = b.Rate,
                             //ImportedBy = b.ImportedBy,
                             //RecStatus = b.RecStatus,
                             //ImportedTime = b.ImportedTime
                         })
                         .Distinct()
                         .OrderBy(x1 => x1.DataDate).ThenBy(x2 => x2.Ccy)
                     .ToList();

            return entry;
        }

        public DepositsRateViewModel GetDepositsRateByDateCcyPeriod(string date, string ccy, string period)
        {
            DateTime dataDate = DateTime.Parse(date);

            var entry = (from b in appDbContext.DepositsRates
                         where (EF.Functions.DateDiffDay(b.DataDate, dataDate) == 0)
                        && b.Ccy == ccy && b.Period == period 
                         select new DepositsRateViewModel()
                         {
                             DataDate = b.DataDate,
                             Ccy = b.Ccy,
                             Period = b.Period,
                             Bid = b.Bid,
                             Offer = b.Offer,
                             Rate = b.Rate,
                             ImportedBy = b.ImportedBy,
                             RecStatus = b.RecStatus,
                             ImportedTime = b.ImportedTime
                         })
                     .FirstOrDefault();

            return entry;
        }


        public string AddDepositsRate(DepositsRate depositesRate)
        {
            try
            {
                var entry = appDbContext.DepositsRates
                      .Where(e => EF.Functions.DateDiffDay(e.DataDate, depositesRate.DataDate) == 0
                           && e.Ccy == depositesRate.Ccy
                           && e.Period == depositesRate.Period)
                      .FirstOrDefault();

                if (entry == null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (depositesRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = depositesRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (depositesRate.Ccy) + "-" + depositesRate.Period.ToString(),
                        AuditDesc = "DEPOSITS Rate INSERT",
                        AppName = "GUIDE",
                        TableName = "DEPOSITS_RATE",
                        OriginalValue = "",
                        NewValue = depositesRate.Rate.ToString(),
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.DepositsRates.Add(depositesRate);
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

        public string DeleteDepositsRate(string date, string ccy, string period)
        {
            try
            {
                DateTime dataDate = DateTime.Parse(date);

                var entry = appDbContext.DepositsRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, dataDate) == 0
                            && e.Ccy == ccy 
                            && e.Period == period)
                       .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = (entry.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = entry.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (entry.Ccy) + "-" + entry.Rate.ToString(),
                        AuditDesc = "DEPOSITS Rate DELETION",
                        AppName = "GUIDE",
                        TableName = "DEPOSITS_RATE",
                        OriginalValue = entry.Rate.ToString(),
                        NewValue = "",
                    };
                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.DepositsRates.Remove(entry);
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

        public string UpdateDepositsRate(DepositsRate depositesRate)
        {
            try
            {
                var entry = appDbContext.DepositsRates
                       .Where(e => EF.Functions.DateDiffDay(e.DataDate, depositesRate.DataDate) == 0
                            && e.Ccy == depositesRate.Ccy 
                            && e.Period == depositesRate.Period)
                       .FirstOrDefault();

                if (entry != null)
                {
                   AuditLog auditLog = new()
                    {
                        UserId = (depositesRate.ImportedBy).ToUpper(),
                        AuditDate = DateTime.Now,
                        RefNo = depositesRate.DataDate.ToString("yyyy-MM-dd"),
                        TransNo = (depositesRate.Ccy) + "-" + depositesRate.Period.ToString(),
                        AuditDesc = "DEPOSITS Rate UPDATE",
                        AppName = "GUIDE",
                        TableName = "DEPOSITS_RATE",
                        OriginalValue = entry.Rate.ToString(),
                        NewValue = depositesRate.Rate.ToString(),
                    };

                    if (entry.Rate != depositesRate.Rate)
                        appDbContext.AuditLogs.Add(auditLog);

                    entry.Bid = depositesRate.Bid;
                    entry.Offer = depositesRate.Offer;
                    entry.Rate = depositesRate.Rate;
                    entry.ImportedBy = (depositesRate.ImportedBy).ToUpper();
                    entry.ImportedTime = DateTime.Now;      // depositesRate.ImportedTime;


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


        //NDF project - Deposit rates for funding
        public DepositsRate CheckDepostRateImportedTime(string SPConnection, DateTime rundate)
        {
            IEnumerable<DepositsRate> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var parameters = new DynamicParameters();
                parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                query = _dapperAccess.LoadData<DepositsRate, dynamic>("USP_GUIDE_RATES_EOMGeneralFundingRateLastImported2", parameters);

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

        public bool UploadDepositRate(string SPConnection, DateTime rundate, string user)
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
                var blnRtn = _dapperAccess.SaveData("USP_GUIDE_RATES_EOMGenaralFundingRate", parameters);
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
