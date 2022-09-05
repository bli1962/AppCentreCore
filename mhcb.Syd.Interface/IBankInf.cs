using mhcb.Syd.Models;
using System;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IBankInf
	{
		IEnumerable<BankInfView> GetPendingTrans();
        IEnumerable<BankInfView> GetBankInfByDetails(string custName, string branchNo);
        IEnumerable<BankInfView> GetBankInfBySwiftID(string swiftId);
        IEnumerable<BankInfView> GetFullBankInfByStatus(string status);
        IEnumerable<BankInfView> GetBankInfsByStatus(string status = "All");
        string UpdateStatus(BankInfStatus status);
    }
}
