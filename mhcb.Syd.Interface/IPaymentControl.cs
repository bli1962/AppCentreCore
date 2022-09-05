using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IPaymentControl
	{
		string DeleteSwiftPayment(SwiftPaymentStatus status);
		IEnumerable<SwiftPaymentView> GetPaymentControlPaymentByDate(string dateValue, string dateType);
		IEnumerable<SwiftPaymentView> GetSwiftPaymentByDate(string dateValue, string dateType);
		string UpdateStatus(SwiftPaymentStatus status);
	}
}