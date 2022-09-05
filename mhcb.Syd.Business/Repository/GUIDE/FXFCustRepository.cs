using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class FXFCustRepository : IFXFCust
	{
        private readonly GUIDEDbContext appDbContext;
        public FXFCustRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<FXFCustomerView> LoadFXCustByCustAbbr(string abbreviation)
		{
            //using GUIDEDbContext appDbContext  = new();
            var entry = appDbContext.Fxfcusts
                                .Where(e => e.Abbreviation.Contains(abbreviation))
                                .Select(x => new FXFCustomerView()
                                {
                                    SHORTNAME = x.Shortname,
                                    Abbreviation = x.Abbreviation,
                                    DeptCode = x.DeptCode,
                                    TaxCode = x.TaxCode,
                                    IBOSNO = x.Ibosno,
                                    Location = x.Location,
                                    Active = x.Active,
                                    STATUS = x.Status,
                                    DeletionStatus = x.DeletionStatus,
                                    CCIF = x.Ccif,
                                    Category = x.Category,
                                    Email = x.Email,
                                    Country = x.Country
                                })
                                .ToList();
            return entry;
        }

		public string UpdateStatus(FXFCustAttribute status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                var fxfCust = appDbContext.Fxfcusts
                        .FirstOrDefault(e => e.Abbreviation.ToUpper() == status.Abbreviation.ToUpper()
                        && (e.AuthorizeBy.ToUpper() == status.AuthorizeBy || e.AuthorizeBy.ToUpper() == "SYSTEM"));

                var mxGuideCustDetail = appDbContext.MxGuideCustDetails
                        .FirstOrDefault(e => e.Id == fxfCust.MxGuideCustDetailId);

                // must check the customer exists
                if (fxfCust != null)
                {
                    var taxCode = fxfCust.TaxCode;
                    var deptCode = fxfCust.DeptCode;
                    var statusCode = fxfCust.Status;

                    AuditLog auditLogTaxCode = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.Abbreviation.ToString(),
                        TransNo = "",
                        AuditDesc = "Update FX Customer Tax Code",
                        AppName = "GUIDE",
                        TableName = "FXCustomer",
                        OriginalValue = taxCode,
                        //NewValue = status.GIP_STATUS,
                    };

                    AuditLog auditLogDeptCode = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.Abbreviation.ToString(),
                        TransNo = "",
                        AuditDesc = "Update FX Customer Department Code",
                        AppName = "GUIDE",
                        TableName = "FXCustomer",
                        OriginalValue = deptCode,
                        //NewValue = status.GIP_STATUS,
                    };

                    AuditLog auditLogStatus = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.Abbreviation.ToString(),
                        TransNo = "",
                        AuditDesc = "Update FX Customer Finalized",
                        AppName = "GUIDE",
                        TableName = "FXCustomer",
                        OriginalValue = statusCode,
                        NewValue = status.Status,
                    };

                    status.TaxCode ??= "";
                    //custAttr.TaxCode = custAttr.TaxCode ?? "";

                    if (status.TaxCode != "NA")
                    {
                        if (taxCode != status.TaxCode)
                        {
                            fxfCust.TaxCode = status.TaxCode;
                            auditLogTaxCode.NewValue = status.TaxCode;
                        }
                    }

                    status.DeptCode ??= "";
                    //custAttr.DeptCode = custAttr.DeptCode ?? "";

                    if (status.DeptCode != "NA")
                    {
                        if (deptCode != status.DeptCode)
                        {
                            fxfCust.DeptCode = status.DeptCode;
                            auditLogDeptCode.NewValue = status.DeptCode;
                        }
                    }

                    if (!string.IsNullOrEmpty(status.Status))
                    {
                        if (statusCode != status.Status)
                        {
                            fxfCust.Status = status.Status;
                            auditLogStatus.NewValue = status.Status;
                        }

                        if (mxGuideCustDetail != null)
                        {
                            if (status.Status == "D")
                            {
                                mxGuideCustDetail.MxCustomerEvent = 3;
                                mxGuideCustDetail.MxCustomerStatus = 1;
                            }
                        }                 
                    }

                    // save whatever changes
                    fxfCust.AuthorizeBy = status.AuthorizeBy;
                

                    // Add audit log if there is a change
                    if (status.TaxCode != "NA")
                    {
                        if (taxCode != status.TaxCode)
                        {
                            appDbContext.AuditLogs.Add(auditLogTaxCode);
                            //AuditLogRepository.InsertAuditLog(auditLogTaxCode);
                        }
                    }


                    // Add audit log if there is a change
                    if (status.DeptCode != "NA")
                    {
                        if (deptCode != status.DeptCode)
                        {
                            appDbContext.AuditLogs.Add(auditLogDeptCode);
                            //AuditLogRepository.InsertAuditLog(auditLogDeptCode);
                        }
                    }

                    // Add audit log if there is a change
                    if (!string.IsNullOrEmpty(status.Status))
                    {
                        if (statusCode != status.Status)
                        {
                            appDbContext.AuditLogs.Add(auditLogStatus);
                            //AuditLogRepository.InsertAuditLog(auditLogStatus);
                        }
                    }

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
	}
}
