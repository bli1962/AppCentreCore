using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("Reuters_DataScope")]
    public partial class ReutersDataScope
    {
        [Column("Data_Scope_Id")]
        public int DataScopeId { get; set; }
        [Key]
        [Column("RIC")]
        [StringLength(20)]
        public string Ric { get; set; }
        [Column("Security_Description")]
        [StringLength(100)]
        public string SecurityDescription { get; set; }
        [Column("Bid_Price", TypeName = "decimal(23, 6)")]
        public decimal? BidPrice { get; set; }
        [Column("Ask_Price", TypeName = "decimal(23, 6)")]
        public decimal? AskPrice { get; set; }
        [Column("Mid_Price", TypeName = "decimal(23, 6)")]
        public decimal? MidPrice { get; set; }
        [Column("High_Price", TypeName = "decimal(23, 6)")]
        public decimal? HighPrice { get; set; }
        [Column("Low_Price", TypeName = "decimal(23, 6)")]
        public decimal? LowPrice { get; set; }
        [Column("Open_Price", TypeName = "decimal(23, 6)")]
        public decimal? OpenPrice { get; set; }
        [Column("Last_Price", TypeName = "decimal(23, 6)")]
        public decimal? LastPrice { get; set; }
        [Column("Close_Price", TypeName = "decimal(23, 6)")]
        public decimal? ClosePrice { get; set; }
        [Column("Last_Updated_Close_Price_Date", TypeName = "datetime")]
        public DateTime? LastUpdatedClosePriceDate { get; set; }
        [Column("Settlement_Price", TypeName = "decimal(23, 6)")]
        public decimal? SettlementPrice { get; set; }
        [Column("Settlement_Date", TypeName = "datetime")]
        public DateTime? SettlementDate { get; set; }
        [Column("Ask_Yield", TypeName = "decimal(23, 6)")]
        public decimal? AskYield { get; set; }
        [Column("Bid_Yield", TypeName = "decimal(23, 6)")]
        public decimal? BidYield { get; set; }
        [Column("Mid_Yield", TypeName = "decimal(23, 6)")]
        public decimal? MidYield { get; set; }
        [Column("Expiration_Date", TypeName = "datetime")]
        public DateTime? ExpirationDate { get; set; }
        [Column("Asset_Category")]
        [StringLength(3)]
        public string AssetCategory { get; set; }
        [Column("Asset_Category_Description")]
        [StringLength(40)]
        public string AssetCategoryDescription { get; set; }
        [Column("Asset_Type")]
        [StringLength(4)]
        public string AssetType { get; set; }
        [Column("Asset_Type_Description")]
        [StringLength(40)]
        public string AssetTypeDescription { get; set; }
        [Column("Asset_SubType")]
        [StringLength(4)]
        public string AssetSubType { get; set; }
        [Column("Asset_SubType_Description")]
        [StringLength(40)]
        public string AssetSubTypeDescription { get; set; }
        [Column("Instrument_Group_Id")]
        public int InstrumentGroupId { get; set; }
        [Column("Instrument_ID_Type")]
        [StringLength(3)]
        public string InstrumentIdType { get; set; }
        [Column("Exchange_Code")]
        [StringLength(3)]
        public string ExchangeCode { get; set; }
        [Column("Exchange_Description")]
        [StringLength(40)]
        public string ExchangeDescription { get; set; }
        [Key]
        [Column("Time_Stamp", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [Key]
        [StringLength(2)]
        public string AmPm { get; set; }
        [Column("PRIMACT_1", TypeName = "decimal(23, 6)")]
        public decimal? Primact1 { get; set; }
        [Column("PRIMACT_2", TypeName = "decimal(23, 6)")]
        public decimal? Primact2 { get; set; }
        [Column("SECONDACT_1", TypeName = "decimal(23, 6)")]
        public decimal? Secondact1 { get; set; }
    }
}
