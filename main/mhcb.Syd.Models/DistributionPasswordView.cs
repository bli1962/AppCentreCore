using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class DistributionPasswordView
    {   
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string Password { get; set; }
        public string CustomerBranch { get; set; }
        public string CustomerAbbr { get; set; }
        public bool Encode { get; set; }
    }
}
