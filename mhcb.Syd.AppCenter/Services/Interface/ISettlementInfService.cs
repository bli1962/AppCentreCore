using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface ISettlementInfService
    {
		Task<IEnumerable<SettlementInfView>> GetPendingSIF();
		Task<IEnumerable<SettlementInfView>> GetSIFById(int id);
		Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbr(string custAbbr);
		Task<IEnumerable<SettlementInfView>> GetSifInstructionsByStatus(string status);
		Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbrCcyCDRecKind(string custAbbr, string ccyCD, string recordKind);

		Task<IEnumerable<SettlementInf>> GetSIFByStatus(string status = "All");

		Task<int> DeleteSettlementInf(int id);
		Task<int> UpdateStatus(SIFStatus status);
		Task<int> InsertSettlementInf(SettlementInf settlement_inf);
	}
}
