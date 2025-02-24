﻿using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
    public interface IDomesticClearing
    {
        IEnumerable<DomesticClearingPaymentView> GetDomesticClearingPaymentByDate(string optDate, string dateType);
        string UpdateStatus(DomesticClearingAttribute status);
    }
}
