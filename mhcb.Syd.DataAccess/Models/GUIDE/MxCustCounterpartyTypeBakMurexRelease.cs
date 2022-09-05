using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MxCustCounterpartyType_Bak_MurexRelease")]
    public partial class MxCustCounterpartyTypeBakMurexRelease
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CustID")]
        public int CustId { get; set; }
        [Column("CounterpartyTypeID")]
        public int CounterpartyTypeId { get; set; }
    }
}
