
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IBankInfService
    {
        Task<IEnumerable<BankInfView>> GetPendingBIF();
        Task<IEnumerable<BankInfView>> GetBIFByCustName(string custName, string branchNo);
        Task<IEnumerable<BankInfView>> GetBIFBySwiftID(string swiftId);
        Task<IEnumerable<BankInfView>> GetBIFByStatus(string status);
        Task<IEnumerable<BankInfView>> GetFullBankInfByStatus(string status);
        Task<int> UpdateStatus(BankInfStatus status);

        //Task<Task<IEnumerable<Employee>> GetEmployees();
        //Task<Employee> GetEmployee(int id);
    }
}
