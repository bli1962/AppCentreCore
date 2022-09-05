using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;


namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface ISwiftPaymentService
    {

        //**************
        //Task<IEnumerable<SwiftPaymentView>> GetPPTransByDate(string strDateValue, string dateType);
        //Task<int> UpdateStatus(SwiftPaymentStatus status);

        //**************
        Task<IEnumerable<SwiftPaymentView>> GetSwiftPTransByDate(string dateValue, string dateType);
        Task<int> DeleteSwiftPayment(SwiftPaymentStatus status);
    }
}
