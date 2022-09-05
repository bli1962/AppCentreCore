using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface ISettlementInf
	{
		IEnumerable<SettlementInfView> GetPendingTrans();
		string InsertSettlementInf(SettlementInf settlement_inf);
		IEnumerable<SettlementInfView> GetSettlementInfByCustAbbr(string custAbbr);
		IEnumerable<SettlementInfView> GetSifInstructionsByStatus(string status);
		IEnumerable<SettlementInfView> GetSettlementInfByDetails(string custAbbr, string ccyCD, string recordKind);
		IEnumerable<SettlementInfView> GetSettlementInfBySifId(int id);
		IEnumerable<SettlementInf> GetSettlementInfsByStatus(string status = "All");

		string DeleteSettlementInf(int id);

		string UpdateStatus(SIFStatus status);
	}
}