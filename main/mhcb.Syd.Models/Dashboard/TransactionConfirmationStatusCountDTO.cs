using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models.Dashboard
{
    [Serializable]
    public class TransactionConfirmationStatusCountDTO : BaseDTO
    {
        public int? StatusId { get; set; }
        public string FinalStatus { get; set; }
        public string StatusCode { get; set; }
        public int? Channel { get; set; }
        public int Status_1_Count { get; set; }
        public int Status_2_Count { get; set; }
        public string Status_1_SearchCriteria { get; set; }
        public string Status_2_SearchCriteria { get; set; }
    }
}
