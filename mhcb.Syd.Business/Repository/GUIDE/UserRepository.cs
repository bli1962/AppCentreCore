using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
//using mhcb.syd.Encryption;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class UserRepository : IUser
	{
        private readonly GUIDEDbContext appDbContext;
        public UserRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<UserView> LoadUsersByRecStatus(string status)
		{
            //using GUIDEDbContext appDbContext = new();
            var entry = (from b in appDbContext.Users
                        .Where(e => e.RecStatus == status)
                         select new UserView()
                         {
                             USER_ID = b.UserId,
                             FIRST_NAME = b.FirstName,
                             LAST_NAME = b.LastName,
                             PWD_CHANGE_IND = b.PwdChangeInd,
                             RACF_STATUS_CODE = b.RacfStatusCode,
                             BU_STATUS_CODE = b.BuStatusCode,
                             ACU_STATUS_CODE = b.AcuStatusCode,
                             NO_OF_LOGIN_ATTEMPTS = b.NoOfLoginAttempts,
                             ENABLED_IND = b.EnabledInd,
                             REC_STATUS = b.RecStatus,
                             GBASE_STATUS_CODE = b.GbaseStatusCode,
                             GBASE_PWD_BU_STATUS_CODE = b.GbasePwdBuStatusCode,
                             PWD_CREATE_DATE = b.PwdCreateDate
                         })
                        .ToList();
            return entry;
        }

		public IEnumerable<UserView> LoadUserByUserId(string userId)
		{
            //using GUIDEDbContext appDbContext = new();
            var entry = (from b in appDbContext.Users
                            .Where(e => e.UserId == userId)
                         select new UserView()
                         {
                             USER_ID = b.UserId,
                             FIRST_NAME = b.FirstName,
                             LAST_NAME = b.LastName,
                             PWD_CHANGE_IND = b.PwdChangeInd,
                             RACF_STATUS_CODE = b.RacfStatusCode,
                             BU_STATUS_CODE = b.BuStatusCode,
                             ACU_STATUS_CODE = b.AcuStatusCode,
                             NO_OF_LOGIN_ATTEMPTS = b.NoOfLoginAttempts,
                             ENABLED_IND = b.EnabledInd,
                             REC_STATUS = b.RecStatus,
                             GBASE_STATUS_CODE = b.GbaseStatusCode,
                             GBASE_PWD_BU_STATUS_CODE = b.GbasePwdBuStatusCode,
                             PWD_CREATE_DATE = b.PwdCreateDate
                         })
                         .ToList();
                         //.FirstOrDefault();
            return entry;
        }

		public string UpdateStatus(UserAttribute status)
		{
			try
			{
                //using GUIDEDbContext appDbContext = new();
                var entry = appDbContext.Users
                         .Where(e => e.UserId == status.UserId)
                         .FirstOrDefault();

                if (entry != null)
                {

                    var v1 = entry.RacfStatusCode;
                    var v2 = entry.BuStatusCode;
                    var v3 = entry.AcuStatusCode;
                    var v4 = entry.PwdChangeInd;
                    var v5 = entry.NoOfLoginAttempts;
                    var v6 = entry.EnabledInd;

                    var v7 = entry.GbasePwdBuStatusCode;
                    var v8 = entry.GbasePwdAcuStatusCode;
                    var v9 = entry.GbasePwdStatusCode;
                    var v10 = entry.GbaseStatusCode;


                    var v11 = entry.PwdCreateDate;
                    var v12 = entry.GbaseUploadedDate;


                    //var v7 = entry.GBASE_PWD_BU_STATUS_CODE;
                    //var v8 = entry.GBASE_PWD_ACU_STATUS_CODE;
                    //var v9 = entry.GBASE_PWD_STATUS_CODE;
                    //var v10 = entry.GBASE_STATUS_CODE;

                    //var v11 = entry.PWD_CREATE_DATE;
                    //var v12 = entry.GBASE_UPLOADED_DATE;


                    //if (!string.IsNullOrEmpty(status.Password))
                    //{
                    //    var enccPassword1 = Krypting.Encrypt(status.Password.ToUpper());
                    //    var enccPassword2 = Krypting.Encrypt(status.Password.ToUpper());
                    //    var enccPassword3 = Krypting.Encrypt(status.Password.ToUpper());

                    //    entry.Password = enccPassword1;
                    //    entry.RacfPreviousPwd = enccPassword2;
                    //    entry.GbasePreviousPwd = enccPassword3;
                    //}


                    //AuditLog auditLog  = new()
                    //{
                    //    UserId = userAttr.USER_ID,
                    //    AuditDate = DateTime.Now,
                    //    RefNo = userAttr.USER_ID,
                    //    TransNo = "",
                    //    AuditDesc = "Reset GUIDE user profile status",
                    //    AppName = "GUIDE",
                    //    TableName = "Users",
                    //    OriginalValue = "RACF_STATUS_CODE: " + v1 + ", BU_STATUS_CODE :" + v2 + ", ACU_STATUS_CODE: " + v3 +
                    //", PWD_CHANGE_IND: " + v4 + ",NO_OF_LOGIN_ATTEMPTS: " + v5,
                    //    NewValue = "N:MS:MS:MS:0",
                    //};

                    if (v1 != "MS")
                    {
                        AuditLog auditLog = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "RACF_STATUS_CODE: " + v1,
                            NewValue = "MS",
                        };
                        entry.RacfStatusCode = "MS";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v2 != "MS")
                    {
                        AuditLog auditLog = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "BU_STATUS_CODE: " + v2,
                            NewValue = "MS",
                        };
                        entry.BuStatusCode = "MS";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v3 != "MS")
                    {
                        AuditLog auditLog = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "ACU_STATUS_CODE: " + v3,
                            NewValue = "MS",
                        };
                        entry.AcuStatusCode = "MS";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v4 != "N")
                    {
                        AuditLog auditLog = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "PWD_CHANGE_IND: " + v4,
                            NewValue = "N",
                        };
                        entry.PwdChangeInd = "N";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v5 != null)
                    {
                        AuditLog auditLog  = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "NO_OF_LOGIN_ATTEMPTS: " + v5,
                            NewValue = null,
                        };
                        entry.NoOfLoginAttempts = null;
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v6 != "")
                    {
                        AuditLog auditLog  = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "ENABLED_IND: " + v6,
                            NewValue = "",
                        };
                        entry.EnabledInd = "";
                        appDbContext.AuditLogs.Add(auditLog);
                    }


                    if (v7 != "U")
                    {
                        AuditLog auditLog  = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "GBASE_PWD_BU_STATUS_CODE: " + v7,
                            NewValue = "U",
                        };
                        entry.GbasePwdBuStatusCode = "U";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v8 != "U")
                    {
                        AuditLog auditLog  = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "GBASE_PWD_ACU_STATUS_CODE: " + v8,
                            NewValue = "U",
                        };
                        entry.GbasePwdAcuStatusCode = "U";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v9 != "U")
                    {
                        AuditLog auditLog  = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "GBASE_PWD_STATUS_CODE: " + v9,
                            NewValue = "U",
                        };
                        entry.GbasePwdStatusCode = "U";
                        appDbContext.AuditLogs.Add(auditLog);
                    }

                    if (v10 != "U")
                    {
                        AuditLog auditLog  = new()
                        {
                            UserId = status.UserId,
                            AuditDate = DateTime.Now,
                            RefNo = status.UserId,
                            TransNo = "",
                            AuditDesc = "Reset GUIDE user profile status",
                            AppName = "GUIDE",
                            TableName = "Users",
                            OriginalValue = "GBASE_STATUS_CODE: " + v10,
                            NewValue = "U",
                        };
                        entry.GbaseStatusCode = "U";
                        appDbContext.AuditLogs.Add(auditLog);
                        //AuditLogRepository.InsertAuditLog(auditLog);
                    }


                    AuditLog auditLog1  = new()
                    {
                        UserId = status.UserId,
                        AuditDate = DateTime.Now,
                        RefNo = status.UserId,
                        TransNo = "",
                        AuditDesc = "Reset GUIDE user profile status",
                        AppName = "GUIDE",
                        TableName = "Users",
                        OriginalValue = "PWD_CREATE_DATE: " + v11,
                        NewValue = DateTime.Today.AddDays(-27).ToString(),
                    };
                    entry.PwdCreateDate = DateTime.Today.AddDays(-27);
                    appDbContext.AuditLogs.Add(auditLog1);
                    //AuditLogRepository.InsertAuditLog(auditLog1);


                    AuditLog auditLog2  = new()
                    {
                        UserId = status.UserId,
                        AuditDate = DateTime.Now,
                        RefNo = status.UserId,
                        TransNo = "",
                        AuditDesc = "Reset GUIDE user profile status",
                        AppName = "GUIDE",
                        TableName = "Users",
                        OriginalValue = "GBASE_UPLOADED_DATE: " + v12,
                        NewValue = DateTime.Today.AddDays(-27).ToString(),
                    };
                    entry.GbaseUploadedDate = DateTime.Today.AddDays(-27);
                    appDbContext.AuditLogs.Add(auditLog2);
                    //AuditLogRepository.InsertAuditLog(auditLog2);
                  
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
