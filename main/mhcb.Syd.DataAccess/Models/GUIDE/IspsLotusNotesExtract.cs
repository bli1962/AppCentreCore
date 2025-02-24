using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("Isps_LotusNotesExtract", Schema = "dbo")]
    public partial class IspsLotusNotesExtract
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        public int TransformStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string SourceName { get; set; }
        [Column("SHENM")]
        [Unicode(false)]
        public string Shenm { get; set; }
        [Column("FGNewSheet")]
        [Unicode(false)]
        public string FgnewSheet { get; set; }
        [Unicode(false)]
        public string Form { get; set; }
        [Column("RMLINK")]
        [Unicode(false)]
        public string Rmlink { get; set; }
        [Column("SPREDIA")]
        [Unicode(false)]
        public string Spredia { get; set; }
        [Column("INTRAIA")]
        [Unicode(false)]
        public string Intraia { get; set; }
        [Column("INLRAIA")]
        [Unicode(false)]
        public string Inlraia { get; set; }
        [Column("PSheetAbbr")]
        [Unicode(false)]
        public string PsheetAbbr { get; set; }
        [Column("SN_1")]
        [Unicode(false)]
        public string Sn1 { get; set; }
        [Column("SN_2")]
        [Unicode(false)]
        public string Sn2 { get; set; }
        [Column("SN_3")]
        [Unicode(false)]
        public string Sn3 { get; set; }
        [Column("SN_4")]
        [Unicode(false)]
        public string Sn4 { get; set; }
        [Column("SN_5")]
        [Unicode(false)]
        public string Sn5 { get; set; }
        [Column("CFlagSPRED")]
        [Unicode(false)]
        public string CflagSpred { get; set; }
        [Column("CFlagINTRA")]
        [Unicode(false)]
        public string CflagIntra { get; set; }
        [Column("CFlagINLRA")]
        [Unicode(false)]
        public string CflagInlra { get; set; }
        [Column("ACCOUNTLISTA")]
        [Unicode(false)]
        public string Accountlista { get; set; }
        [Column("ACCOUNTLISTB")]
        [Unicode(false)]
        public string Accountlistb { get; set; }
        [Column("LOAGM")]
        [Unicode(false)]
        public string Loagm { get; set; }
        [Column("PROMN")]
        [Unicode(false)]
        public string Promn { get; set; }
        [Column("LOCFM")]
        [Unicode(false)]
        public string Locfm { get; set; }
        [Column("INITIALDEPT")]
        [Unicode(false)]
        public string Initialdept { get; set; }
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Column("SV")]
        [Unicode(false)]
        public string Sv { get; set; }
        [Column("CODEDB")]
        [Unicode(false)]
        public string Codedb { get; set; }
        [Column("EUCDB")]
        [Unicode(false)]
        public string Eucdb { get; set; }
        [Column("APPDB")]
        [Unicode(false)]
        public string Appdb { get; set; }
        [Column("UseMAIL")]
        [Unicode(false)]
        public string UseMail { get; set; }
        [Column("MAILDB")]
        [Unicode(false)]
        public string Maildb { get; set; }
        [Column("ISPSDB")]
        [Unicode(false)]
        public string Ispsdb { get; set; }
        [Column("PRINTHEADER")]
        [Unicode(false)]
        public string Printheader { get; set; }
        [Unicode(false)]
        public string Version { get; set; }
        [Column("ID1")]
        [Unicode(false)]
        public string Id1 { get; set; }
        [Column("ID2")]
        [Unicode(false)]
        public string Id2 { get; set; }
        [Unicode(false)]
        public string Hide2 { get; set; }
        [Column("ID3")]
        [Unicode(false)]
        public string Id3 { get; set; }
        [Unicode(false)]
        public string Hide3 { get; set; }
        [Column("ID4")]
        [Unicode(false)]
        public string Id4 { get; set; }
        [Unicode(false)]
        public string Hide4 { get; set; }
        [Column("ID5")]
        [Unicode(false)]
        public string Id5 { get; set; }
        [Unicode(false)]
        public string Hide5 { get; set; }
        [Column("SID2")]
        [Unicode(false)]
        public string Sid2 { get; set; }
        [Column("SHide2")]
        [Unicode(false)]
        public string Shide2 { get; set; }
        [Column("SID3")]
        [Unicode(false)]
        public string Sid3 { get; set; }
        [Column("SHide3")]
        [Unicode(false)]
        public string Shide3 { get; set; }
        [Column("SID4")]
        [Unicode(false)]
        public string Sid4 { get; set; }
        [Column("SHide4")]
        [Unicode(false)]
        public string Shide4 { get; set; }
        [Column("SID5")]
        [Unicode(false)]
        public string Sid5 { get; set; }
        [Column("SHide5")]
        [Unicode(false)]
        public string Shide5 { get; set; }
        [Column("SID6")]
        [Unicode(false)]
        public string Sid6 { get; set; }
        [Column("SHide6")]
        [Unicode(false)]
        public string Shide6 { get; set; }
        [Column("SID7")]
        [Unicode(false)]
        public string Sid7 { get; set; }
        [Column("SHide7")]
        [Unicode(false)]
        public string Shide7 { get; set; }
        [Column("SID8")]
        [Unicode(false)]
        public string Sid8 { get; set; }
        [Column("SHide8")]
        [Unicode(false)]
        public string Shide8 { get; set; }
        [Column("SID9")]
        [Unicode(false)]
        public string Sid9 { get; set; }
        [Column("SHide9")]
        [Unicode(false)]
        public string Shide9 { get; set; }
        [Column("SID10")]
        [Unicode(false)]
        public string Sid10 { get; set; }
        [Column("SHide10")]
        [Unicode(false)]
        public string Shide10 { get; set; }
        [Column("SIDCU")]
        [Unicode(false)]
        public string Sidcu { get; set; }
        [Column("S2ID2")]
        [Unicode(false)]
        public string S2id2 { get; set; }
        [Column("S2Hide2")]
        [Unicode(false)]
        public string S2hide2 { get; set; }
        [Column("S2ID3")]
        [Unicode(false)]
        public string S2id3 { get; set; }
        [Column("S2Hide3")]
        [Unicode(false)]
        public string S2hide3 { get; set; }
        [Column("S2ID4")]
        [Unicode(false)]
        public string S2id4 { get; set; }
        [Column("S2Hide4")]
        [Unicode(false)]
        public string S2hide4 { get; set; }
        [Column("S2ID5")]
        [Unicode(false)]
        public string S2id5 { get; set; }
        [Column("S2Hide5")]
        [Unicode(false)]
        public string S2hide5 { get; set; }
        [Column("S2ID6")]
        [Unicode(false)]
        public string S2id6 { get; set; }
        [Column("S2Hide6")]
        [Unicode(false)]
        public string S2hide6 { get; set; }
        [Column("S2ID7")]
        [Unicode(false)]
        public string S2id7 { get; set; }
        [Column("S2Hide7")]
        [Unicode(false)]
        public string S2hide7 { get; set; }
        [Column("S2ID8")]
        [Unicode(false)]
        public string S2id8 { get; set; }
        [Column("S2Hide8")]
        [Unicode(false)]
        public string S2hide8 { get; set; }
        [Column("S2ID9")]
        [Unicode(false)]
        public string S2id9 { get; set; }
        [Column("S2Hide9")]
        [Unicode(false)]
        public string S2hide9 { get; set; }
        [Column("S2ID10")]
        [Unicode(false)]
        public string S2id10 { get; set; }
        [Column("S2Hide10")]
        [Unicode(false)]
        public string S2hide10 { get; set; }
        [Column("S2IDCU")]
        [Unicode(false)]
        public string S2idcu { get; set; }
        [Unicode(false)]
        public string Hide { get; set; }
        [Unicode(false)]
        public string Branch { get; set; }
        [Unicode(false)]
        public string DateType { get; set; }
        [Column("SLDocID")]
        [Unicode(false)]
        public string SldocId { get; set; }
        [Column("SFFlag")]
        [Unicode(false)]
        public string Sfflag { get; set; }
        [Column("SFFFlag")]
        [Unicode(false)]
        public string Sffflag { get; set; }
        [Column("SNFlag")]
        [Unicode(false)]
        public string Snflag { get; set; }
        [Unicode(false)]
        public string Error { get; set; }
        [Unicode(false)]
        public string OtherError { get; set; }
        [Unicode(false)]
        public string OriginalSheet { get; set; }
        [Unicode(false)]
        public string NextUser { get; set; }
        [Unicode(false)]
        public string EditFg { get; set; }
        [Column("DELSF")]
        [Unicode(false)]
        public string Delsf { get; set; }
        [Column("ISPSID")]
        [Unicode(false)]
        public string Ispsid { get; set; }
        [Column("STPID")]
        [Unicode(false)]
        public string Stpid { get; set; }
        [Unicode(false)]
        public string Keep { get; set; }
        [Column("IAFlag")]
        [Unicode(false)]
        public string Iaflag { get; set; }
        [Column("P_PVNO")]
        [Unicode(false)]
        public string PPvno { get; set; }
        [Unicode(false)]
        public string Status { get; set; }
        [Unicode(false)]
        public string Export { get; set; }
        [Unicode(false)]
        public string Batch { get; set; }
        [Unicode(false)]
        public string InitialApp { get; set; }
        [Column("NumberingPV")]
        [Unicode(false)]
        public string NumberingPv { get; set; }
        [Unicode(false)]
        public string AppDate150 { get; set; }
        [Unicode(false)]
        public string AppDate250 { get; set; }
        [Unicode(false)]
        public string AppDate350 { get; set; }
        [Unicode(false)]
        public string FinalApp { get; set; }
        [Unicode(false)]
        public string InitialApprover { get; set; }
        [Unicode(false)]
        public string MadeI { get; set; }
        [Unicode(false)]
        public string Made { get; set; }
        [Unicode(false)]
        public string Approver250 { get; set; }
        [Unicode(false)]
        public string Approver350 { get; set; }
        [Unicode(false)]
        public string FinalApprover { get; set; }
        [Unicode(false)]
        public string RejectDate { get; set; }
        [Unicode(false)]
        public string RejectUser { get; set; }
        [Unicode(false)]
        public string FlagForDummySave { get; set; }
        [Unicode(false)]
        public string InitialItemStatus { get; set; }
        [Unicode(false)]
        public string ItemStatus { get; set; }
        [Column("STPNO")]
        [Unicode(false)]
        public string Stpno { get; set; }
        [Column("ReqIAFlag")]
        [Unicode(false)]
        public string ReqIaflag { get; set; }
        [Unicode(false)]
        public string RejFlag { get; set; }
        [Unicode(false)]
        public string PrintFlag { get; set; }
        [Column("LOANFUNDFLAG")]
        [Unicode(false)]
        public string Loanfundflag { get; set; }
        [Unicode(false)]
        public string ParentInitialFlag { get; set; }
        [Column("LIAFlag")]
        [Unicode(false)]
        public string Liaflag { get; set; }
        [Column("LAppRole")]
        [Unicode(false)]
        public string LappRole { get; set; }
        [Unicode(false)]
        public string SheetAbbr { get; set; }
        [Column("PRCCYCC")]
        [Unicode(false)]
        public string Prccycc { get; set; }
        [Column("IPCCYCC")]
        [Unicode(false)]
        public string Ipccycc { get; set; }
        [Unicode(false)]
        public string UserRoles { get; set; }
        [Column("ISAuthors")]
        [Unicode(false)]
        public string Isauthors { get; set; }
        [Unicode(false)]
        public string Readers { get; set; }
        [Unicode(false)]
        public string AppRole { get; set; }
        [Unicode(false)]
        public string PrintBreakFlag { get; set; }
        [Unicode(false)]
        public string FinalDept { get; set; }
        [Unicode(false)]
        public string AppDept250 { get; set; }
        [Unicode(false)]
        public string AppDept350 { get; set; }
        [Column("MODDA1")]
        [Unicode(false)]
        public string Modda1 { get; set; }
        [Column("MADE1")]
        [Unicode(false)]
        public string Made1 { get; set; }
        [Column("DEPT1")]
        [Unicode(false)]
        public string Dept1 { get; set; }
        [Column("MINIAPPRO1")]
        [Unicode(false)]
        public string Miniappro1 { get; set; }
        [Column("MODDA2")]
        [Unicode(false)]
        public string Modda2 { get; set; }
        [Column("MADE2")]
        [Unicode(false)]
        public string Made2 { get; set; }
        [Column("DEPT2")]
        [Unicode(false)]
        public string Dept2 { get; set; }
        [Column("MINIAPPRO2")]
        [Unicode(false)]
        public string Miniappro2 { get; set; }
        [Column("MODDA3")]
        [Unicode(false)]
        public string Modda3 { get; set; }
        [Column("MADE3")]
        [Unicode(false)]
        public string Made3 { get; set; }
        [Column("DEPT3")]
        [Unicode(false)]
        public string Dept3 { get; set; }
        [Column("MINIAPPRO3")]
        [Unicode(false)]
        public string Miniappro3 { get; set; }
        [Column("MODDA4")]
        [Unicode(false)]
        public string Modda4 { get; set; }
        [Column("MADE4")]
        [Unicode(false)]
        public string Made4 { get; set; }
        [Column("DEPT4")]
        [Unicode(false)]
        public string Dept4 { get; set; }
        [Column("MINIAPPRO4")]
        [Unicode(false)]
        public string Miniappro4 { get; set; }
        [Column("MODDA5")]
        [Unicode(false)]
        public string Modda5 { get; set; }
        [Column("MADE5")]
        [Unicode(false)]
        public string Made5 { get; set; }
        [Column("DEPT5")]
        [Unicode(false)]
        public string Dept5 { get; set; }
        [Column("MINIAPPRO5")]
        [Unicode(false)]
        public string Miniappro5 { get; set; }
        [Column("MODDA6")]
        [Unicode(false)]
        public string Modda6 { get; set; }
        [Column("MADE6")]
        [Unicode(false)]
        public string Made6 { get; set; }
        [Column("DEPT6")]
        [Unicode(false)]
        public string Dept6 { get; set; }
        [Column("MINIAPPRO6")]
        [Unicode(false)]
        public string Miniappro6 { get; set; }
        [Column("MODDA7")]
        [Unicode(false)]
        public string Modda7 { get; set; }
        [Column("MADE7")]
        [Unicode(false)]
        public string Made7 { get; set; }
        [Column("DEPT7")]
        [Unicode(false)]
        public string Dept7 { get; set; }
        [Column("MINIAPPRO7")]
        [Unicode(false)]
        public string Miniappro7 { get; set; }
        [Column("MODDA8")]
        [Unicode(false)]
        public string Modda8 { get; set; }
        [Column("MADE8")]
        [Unicode(false)]
        public string Made8 { get; set; }
        [Column("DEPT8")]
        [Unicode(false)]
        public string Dept8 { get; set; }
        [Column("MINIAPPRO8")]
        [Unicode(false)]
        public string Miniappro8 { get; set; }
        [Column("MODDA9")]
        [Unicode(false)]
        public string Modda9 { get; set; }
        [Column("MADE9")]
        [Unicode(false)]
        public string Made9 { get; set; }
        [Column("DEPT9")]
        [Unicode(false)]
        public string Dept9 { get; set; }
        [Column("MINIAPPRO9")]
        [Unicode(false)]
        public string Miniappro9 { get; set; }
        [Column("MODDA10")]
        [Unicode(false)]
        public string Modda10 { get; set; }
        [Column("MADE10")]
        [Unicode(false)]
        public string Made10 { get; set; }
        [Column("DEPT10")]
        [Unicode(false)]
        public string Dept10 { get; set; }
        [Column("MINIAPPRO10")]
        [Unicode(false)]
        public string Miniappro10 { get; set; }
        [Column("DISPNAME")]
        [Unicode(false)]
        public string Dispname { get; set; }
        [Unicode(false)]
        public string ProcessedNum { get; set; }
        [Column("FTCWD")]
        [Unicode(false)]
        public string Ftcwd { get; set; }
        [Column("INCOM")]
        [Unicode(false)]
        public string Incom { get; set; }
        [Column("PVNO")]
        [Unicode(false)]
        public string Pvno { get; set; }
        [Column("REFNO")]
        [Unicode(false)]
        public string Refno { get; set; }
        [Column("DDNO")]
        [Unicode(false)]
        public string Ddno { get; set; }
        [Column("COMCO")]
        [Unicode(false)]
        public string Comco { get; set; }
        [Column("CUSTNAMELIST")]
        [Unicode(false)]
        public string Custnamelist { get; set; }
        [Column("BORRO")]
        [Unicode(false)]
        public string Borro { get; set; }
        [Column("CUNAM")]
        [Unicode(false)]
        public string Cunam { get; set; }
        [Column("SCHNO")]
        [Unicode(false)]
        public string Schno { get; set; }
        [Column("AUTHO")]
        [Unicode(false)]
        public string Autho { get; set; }
        [Column("VALDA")]
        [Unicode(false)]
        public string Valda { get; set; }
        [Column("FDUED")]
        [Unicode(false)]
        public string Fdued { get; set; }
        [Column("DUEDA")]
        [Unicode(false)]
        public string Dueda { get; set; }
        [Column("INTTD")]
        [Unicode(false)]
        public string Inttd { get; set; }
        [Column("PRCCY")]
        [Unicode(false)]
        public string Prccy { get; set; }
        [Column("PRINC")]
        [Unicode(false)]
        public string Princ { get; set; }
        [Column("IPCCY")]
        [Unicode(false)]
        public string Ipccy { get; set; }
        [Column("IPRIM")]
        [Unicode(false)]
        public string Iprim { get; set; }
        [Column("CACO1")]
        [Unicode(false)]
        public string Caco1 { get; set; }
        [Column("CACO2")]
        [Unicode(false)]
        public string Caco2 { get; set; }
        [Column("CACO3")]
        [Unicode(false)]
        public string Caco3 { get; set; }
        [Column("CACO4")]
        [Unicode(false)]
        public string Caco4 { get; set; }
        [Column("BRS1")]
        [Unicode(false)]
        public string Brs1 { get; set; }
        [Column("BRS2")]
        [Unicode(false)]
        public string Brs2 { get; set; }
        [Column("BRS3")]
        [Unicode(false)]
        public string Brs3 { get; set; }
        [Column("SPRED")]
        [Unicode(false)]
        public string Spred { get; set; }
        [Column("INTRA")]
        [Unicode(false)]
        public string Intra { get; set; }
        [Column("INTAR")]
        [Unicode(false)]
        public string Intar { get; set; }
        [Column("INTAM")]
        [Unicode(false)]
        public string Intam { get; set; }
        [Column("INTCO")]
        [Unicode(false)]
        public string Intco { get; set; }
        [Column("INLRC")]
        [Unicode(false)]
        public string Inlrc { get; set; }
        [Column("INLRA")]
        [Unicode(false)]
        public string Inlra { get; set; }
        [Column("TAXCO")]
        [Unicode(false)]
        public string Taxco { get; set; }
        [Column("TAXRA")]
        [Unicode(false)]
        public string Taxra { get; set; }
        [Column("WITAX")]
        [Unicode(false)]
        public string Witax { get; set; }
        [Column("RCMET")]
        [Unicode(false)]
        public string Rcmet { get; set; }
        [Column("RCACC")]
        [Unicode(false)]
        public string Rcacc { get; set; }
        [Column("CUSTNAMELISTA")]
        [Unicode(false)]
        public string Custnamelista { get; set; }
        [Column("RCCAB")]
        [Unicode(false)]
        public string Rccab { get; set; }
        [Column("CUNAMA")]
        [Unicode(false)]
        public string Cunama { get; set; }
        [Column("RN1")]
        [Unicode(false)]
        public string Rn1 { get; set; }
        [Column("RN2")]
        [Unicode(false)]
        public string Rn2 { get; set; }
        [Column("PAMET")]
        [Unicode(false)]
        public string Pamet { get; set; }
        [Column("PAACC")]
        [Unicode(false)]
        public string Paacc { get; set; }
        [Column("CUSTNAMELISTB")]
        [Unicode(false)]
        public string Custnamelistb { get; set; }
        [Column("PACAB")]
        [Unicode(false)]
        public string Pacab { get; set; }
        [Column("CUNAMB")]
        [Unicode(false)]
        public string Cunamb { get; set; }
        [Column("PN1")]
        [Unicode(false)]
        public string Pn1 { get; set; }
        [Column("PN2")]
        [Unicode(false)]
        public string Pn2 { get; set; }
        [Column("REMAR")]
        [Unicode(false)]
        public string Remar { get; set; }
        [Column("RESCH")]
        [Unicode(false)]
        public string Resch { get; set; }
        [Column("SECUR")]
        [Unicode(false)]
        public string Secur { get; set; }
        [Column("OVERA")]
        [Unicode(false)]
        public string Overa { get; set; }
        [Column("DELRA")]
        [Unicode(false)]
        public string Delra { get; set; }
        [Column("ATTEN")]
        [Unicode(false)]
        public string Atten { get; set; }
        [Column("LSENT")]
        [Unicode(false)]
        public string Lsent { get; set; }
        [Column("OUGRM")]
        [Unicode(false)]
        public string Ougrm { get; set; }
        [Column("TFT1")]
        [Unicode(false)]
        public string Tft1 { get; set; }
        [Column("SELOT1")]
        [Unicode(false)]
        public string Selot1 { get; set; }
        [Column("TFT2")]
        [Unicode(false)]
        public string Tft2 { get; set; }
        [Column("SELOT2")]
        [Unicode(false)]
        public string Selot2 { get; set; }
        [Column("TFT3")]
        [Unicode(false)]
        public string Tft3 { get; set; }
        [Column("SELOT3")]
        [Unicode(false)]
        public string Selot3 { get; set; }
        [Column("TFT4")]
        [Unicode(false)]
        public string Tft4 { get; set; }
        [Column("SELOT4")]
        [Unicode(false)]
        public string Selot4 { get; set; }
        [Column("TFT5")]
        [Unicode(false)]
        public string Tft5 { get; set; }
        [Column("SELOT5")]
        [Unicode(false)]
        public string Selot5 { get; set; }
        [Column("TFT6")]
        [Unicode(false)]
        public string Tft6 { get; set; }
        [Column("SELOT6")]
        [Unicode(false)]
        public string Selot6 { get; set; }
        [Column("TFT7")]
        [Unicode(false)]
        public string Tft7 { get; set; }
        [Column("SELOT7")]
        [Unicode(false)]
        public string Selot7 { get; set; }
        [Column("TFT8")]
        [Unicode(false)]
        public string Tft8 { get; set; }
        [Column("SELOT8")]
        [Unicode(false)]
        public string Selot8 { get; set; }
        [Column("TFT9")]
        [Unicode(false)]
        public string Tft9 { get; set; }
        [Column("SELOT9")]
        [Unicode(false)]
        public string Selot9 { get; set; }
        [Column("TFT10")]
        [Unicode(false)]
        public string Tft10 { get; set; }
        [Column("SELOT10")]
        [Unicode(false)]
        public string Selot10 { get; set; }
        [Column("TFT11")]
        [Unicode(false)]
        public string Tft11 { get; set; }
        [Column("SELOT11")]
        [Unicode(false)]
        public string Selot11 { get; set; }
        [Column("TFT12")]
        [Unicode(false)]
        public string Tft12 { get; set; }
        [Column("SELOT12")]
        [Unicode(false)]
        public string Selot12 { get; set; }
        [Column("TFT13")]
        [Unicode(false)]
        public string Tft13 { get; set; }
        [Column("SELOT13")]
        [Unicode(false)]
        public string Selot13 { get; set; }
        [Column("TFT14")]
        [Unicode(false)]
        public string Tft14 { get; set; }
        [Column("SELOT14")]
        [Unicode(false)]
        public string Selot14 { get; set; }
        [Column("TFT15")]
        [Unicode(false)]
        public string Tft15 { get; set; }
        [Column("SELOT15")]
        [Unicode(false)]
        public string Selot15 { get; set; }
        [Column("TFT16")]
        [Unicode(false)]
        public string Tft16 { get; set; }
        [Column("SELOT16")]
        [Unicode(false)]
        public string Selot16 { get; set; }
        [Column("TFT17")]
        [Unicode(false)]
        public string Tft17 { get; set; }
        [Column("SELOT17")]
        [Unicode(false)]
        public string Selot17 { get; set; }
        [Column("TFT18")]
        [Unicode(false)]
        public string Tft18 { get; set; }
        [Column("SELOT18")]
        [Unicode(false)]
        public string Selot18 { get; set; }
        [Column("TFT19")]
        [Unicode(false)]
        public string Tft19 { get; set; }
        [Column("SELOT19")]
        [Unicode(false)]
        public string Selot19 { get; set; }
        [Column("TFT20")]
        [Unicode(false)]
        public string Tft20 { get; set; }
        [Column("SELOT20")]
        [Unicode(false)]
        public string Selot20 { get; set; }
        [Column("TFT21")]
        [Unicode(false)]
        public string Tft21 { get; set; }
        [Column("SELOT21")]
        [Unicode(false)]
        public string Selot21 { get; set; }
        [Column("TFT22")]
        [Unicode(false)]
        public string Tft22 { get; set; }
        [Column("SELOT22")]
        [Unicode(false)]
        public string Selot22 { get; set; }
        [Column("TFT23")]
        [Unicode(false)]
        public string Tft23 { get; set; }
        [Column("SELOT23")]
        [Unicode(false)]
        public string Selot23 { get; set; }
        [Column("TFT24")]
        [Unicode(false)]
        public string Tft24 { get; set; }
        [Column("SELOT24")]
        [Unicode(false)]
        public string Selot24 { get; set; }
        [Column("TFT25")]
        [Unicode(false)]
        public string Tft25 { get; set; }
        [Column("SELOT25")]
        [Unicode(false)]
        public string Selot25 { get; set; }
        [Column("TFT26")]
        [Unicode(false)]
        public string Tft26 { get; set; }
        [Column("SELOT26")]
        [Unicode(false)]
        public string Selot26 { get; set; }
        [Column("TFT27")]
        [Unicode(false)]
        public string Tft27 { get; set; }
        [Column("SELOT27")]
        [Unicode(false)]
        public string Selot27 { get; set; }
        [Column("TFT28")]
        [Unicode(false)]
        public string Tft28 { get; set; }
        [Column("SELOT28")]
        [Unicode(false)]
        public string Selot28 { get; set; }
        [Column("TFT29")]
        [Unicode(false)]
        public string Tft29 { get; set; }
        [Column("SELOT29")]
        [Unicode(false)]
        public string Selot29 { get; set; }
        [Column("TFT30")]
        [Unicode(false)]
        public string Tft30 { get; set; }
        [Column("SELOT30")]
        [Unicode(false)]
        public string Selot30 { get; set; }
        [Column("UPDATEDBY")]
        [Unicode(false)]
        public string Updatedby { get; set; }
        [Column("RECCYCC")]
        [Unicode(false)]
        public string Reccycc { get; set; }
        [Column("RECCY")]
        [Unicode(false)]
        public string Reccy { get; set; }
        [Column("REAMT")]
        [Unicode(false)]
        public string Reamt { get; set; }
        [Column("EXPIR")]
        [Unicode(false)]
        public string Expir { get; set; }
        [Column("EXPIN")]
        [Unicode(false)]
        public string Expin { get; set; }
        [Column("WIHTA")]
        [Unicode(false)]
        public string Wihta { get; set; }
        [Unicode(false)]
        public string ShowAsterisk { get; set; }
        [Column("ACCOUNTLISTC")]
        [Unicode(false)]
        public string Accountlistc { get; set; }
        [Column("ACCOUNTLISTD")]
        [Unicode(false)]
        public string Accountlistd { get; set; }
        [Column("INTACCC")]
        [Unicode(false)]
        public string Intaccc { get; set; }
        [Column("WIHTCCC")]
        [Unicode(false)]
        public string Wihtccc { get; set; }
        [Column("PRICYCC")]
        [Unicode(false)]
        public string Pricycc { get; set; }
        [Column("INPCYCC")]
        [Unicode(false)]
        public string Inpcycc { get; set; }
        [Column("INTAC")]
        [Unicode(false)]
        public string Intac { get; set; }
        [Column("WIHTC")]
        [Unicode(false)]
        public string Wihtc { get; set; }
        [Unicode(false)]
        public string O1 { get; set; }
        [Unicode(false)]
        public string O2 { get; set; }
        [Column("FINDS")]
        [Unicode(false)]
        public string Finds { get; set; }
        [Column("FINDD")]
        [Unicode(false)]
        public string Findd { get; set; }
        [Column("PRICY")]
        [Unicode(false)]
        public string Pricy { get; set; }
        [Column("INPCY")]
        [Unicode(false)]
        public string Inpcy { get; set; }
        [Column("INPRI")]
        [Unicode(false)]
        public string Inpri { get; set; }
        [Column("BACD1")]
        [Unicode(false)]
        public string Bacd1 { get; set; }
        [Column("BACD2")]
        [Unicode(false)]
        public string Bacd2 { get; set; }
        [Column("BACD3")]
        [Unicode(false)]
        public string Bacd3 { get; set; }
        [Column("INTAT")]
        [Unicode(false)]
        public string Intat { get; set; }
        [Column("INTCL")]
        [Unicode(false)]
        public string Intcl { get; set; }
        [Column("RVMET")]
        [Unicode(false)]
        public string Rvmet { get; set; }
        [Column("RVACC")]
        [Unicode(false)]
        public string Rvacc { get; set; }
        [Column("CUSTNAMELISTC")]
        [Unicode(false)]
        public string Custnamelistc { get; set; }
        [Column("RVCAB")]
        [Unicode(false)]
        public string Rvcab { get; set; }
        [Column("CUNAMC")]
        [Unicode(false)]
        public string Cunamc { get; set; }
        [Column("VN1")]
        [Unicode(false)]
        public string Vn1 { get; set; }
        [Column("VN2")]
        [Unicode(false)]
        public string Vn2 { get; set; }
        [Column("PYMET")]
        [Unicode(false)]
        public string Pymet { get; set; }
        [Column("PYACC")]
        [Unicode(false)]
        public string Pyacc { get; set; }
        [Column("CUSTNAMELISTD")]
        [Unicode(false)]
        public string Custnamelistd { get; set; }
        [Column("PYCAB")]
        [Unicode(false)]
        public string Pycab { get; set; }
        [Column("CUNAMD")]
        [Unicode(false)]
        public string Cunamd { get; set; }
        [Column("YN1")]
        [Unicode(false)]
        public string Yn1 { get; set; }
        [Column("YN2")]
        [Unicode(false)]
        public string Yn2 { get; set; }
        [Column("STPVALUES")]
        [Unicode(false)]
        public string Stpvalues { get; set; }
        [Column("MENO")]
        [Unicode(false)]
        public string Meno { get; set; }
        [Column("DDNO1")]
        [Unicode(false)]
        public string Ddno1 { get; set; }
        [Column("DDNO2")]
        [Unicode(false)]
        public string Ddno2 { get; set; }
        [Column("DDNO3")]
        [Unicode(false)]
        public string Ddno3 { get; set; }
        [Column("DDNO4")]
        [Unicode(false)]
        public string Ddno4 { get; set; }
        [Column("DDNO5")]
        [Unicode(false)]
        public string Ddno5 { get; set; }
        [Column("DDNO6")]
        [Unicode(false)]
        public string Ddno6 { get; set; }
        [Column("DDNO7")]
        [Unicode(false)]
        public string Ddno7 { get; set; }
        [Column("DDNO8")]
        [Unicode(false)]
        public string Ddno8 { get; set; }
        [Column("DDNO9")]
        [Unicode(false)]
        public string Ddno9 { get; set; }
        [Column("DDNO10")]
        [Unicode(false)]
        public string Ddno10 { get; set; }
        [Column("DDNO11")]
        [Unicode(false)]
        public string Ddno11 { get; set; }
        [Column("DDNO12")]
        [Unicode(false)]
        public string Ddno12 { get; set; }
        [Column("COMAV")]
        [Unicode(false)]
        public string Comav { get; set; }
        [Column("NDDNO")]
        [Unicode(false)]
        public string Nddno { get; set; }
        [Column("METP")]
        [Unicode(false)]
        public string Metp { get; set; }
        [Column("VALDT")]
        [Unicode(false)]
        public string Valdt { get; set; }
        [Column("MULCU")]
        [Unicode(false)]
        public string Mulcu { get; set; }
        [Column("ACCYA")]
        [Unicode(false)]
        public string Accya { get; set; }
        [Column("ACDKA")]
        [Unicode(false)]
        public string Acdka { get; set; }
    }
}
