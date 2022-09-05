using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface ISpecialRate
	{
		IEnumerable<ExchRateView> LoadSpcialRate();
		string UpdateStatus(RateAttribute rate);
	}
}