using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class DistributionPreferenceView
    {
        public string CUST_ABBR { get; set; }
        public string CUST_NAME { get; set; }
        public string VisableToSystem { get; set; }
        public string DistributionType { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }

}


//d.[CustomerAbbr]
//--,[DistributionType]

//,c.[CUST_NAME]
//,t.VisableToSystem
//,t.DistributionType

//-- ,[DistributionChannel]
//--,d.[Address]

//--,REPLACE(d.[Address], CHAR(10), ',') as address
//,REPLACE(REPLACE(REPLACE(d.[Address], CHAR(13), ''), CHAR(10), ''), ' ', '') as address