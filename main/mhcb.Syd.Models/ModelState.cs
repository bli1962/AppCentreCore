using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class ModelState
    {
        public bool IsValid { get; set; }
        public string ModelError { get; set; }
        public string CallbackUrl { get; set; }
        public bool isPersistent { get; set; }
        public bool lockoutOnFailure { get; set; }

    }
}
