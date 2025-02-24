using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;
using System;

namespace mhcb.Syd.Interface
{
	public interface IFXTransaction
	{
		IEnumerable<FxTransactionCompleteView> GetFullFXTransactionByDates(string strDateFrom, string strDateTo, string dateType);
		IEnumerable<FXTransactionView> GetPendingTrans();
		IEnumerable<FXTransactionView> GetFXTransactionByDatesCustAbbr(string dateFrom, string dateTo, string dateType, string custName);	
		FxTransaction GetFxTransByRefNo(string refNo);
		string UpdateStatus(InputFXTrans status);

        //NDF project 
        Int32 CheckFxTransactionQueues(string SPConnection, DateTime rundate);
    }
}