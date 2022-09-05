using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_FREQ_REF_TYPE")]
    public partial class FeeFreqRefType
    {
        [Key]
        [Column("DATE_TYPE")]
        public byte DateType { get; set; }
        [Column("FREQ_TYPE")]
        public byte? FreqType { get; set; }
        [Column("DAY")]
        public byte? Day { get; set; }
        [Column("MONTH")]
        public byte? Month { get; set; }

        [ForeignKey(nameof(FreqType))]
        [InverseProperty(nameof(FeeFreqType.FeeFreqRefTypes))]
        public virtual FeeFreqType FreqTypeNavigation { get; set; }
    }
}
