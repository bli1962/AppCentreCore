using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Table("Ondm_Table_Read_Flag")]
    [Index(nameof(OndmTableName), nameof(ImportBatchId), Name = "IX_Ondm_Table_Read_Flag")]
    public partial class OndmTableReadFlag
    {
        [Key]
        [Column("Ondm_Table_Read_Flag_Id")]
        public int OndmTableReadFlagId { get; set; }
        [Required]
        [Column("Ondm_Table_Name")]
        [StringLength(50)]
        public string OndmTableName { get; set; }
        [Column("Imported_Rows_Count")]
        public int? ImportedRowsCount { get; set; }
        [Column("Import_Batch_Id")]
        public int? ImportBatchId { get; set; }
        [Column("Read_Flag")]
        public int? ReadFlag { get; set; }
    }
}
