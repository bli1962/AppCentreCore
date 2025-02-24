using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Models.LOAN;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository.LOAN
{
	public class TrancheCovenantTypeRepository : ITrancheCovenantType
	{
		private readonly LOANDbContext appDbContext;
		private readonly GUIDEDbContext appDbContextGuide;
		public TrancheCovenantTypeRepository(LOANDbContext appDbContext,
											GUIDEDbContext appDbContext2)
		{
			this.appDbContext = appDbContext;
			this.appDbContextGuide = appDbContext2;
		}

		public IEnumerable<TrancheType> LoadTrancheType()
		{
			//var entry = (from e in appDbContext.TrancheTypes
			//			 orderby e.TrancheType1
			//			 select new TrancheType()
			//			 {
			//				 TrancheType1 = e.TrancheType1,
			//				 TrancheTypeDesc = e.TrancheTypeDesc
			//			 })
			//			.ToList();

			//var entry = (from e in appDbContext.TrancheTypes
			//			  orderby e.TrancheType1
			//			  select e)
			//.ToList();

			var entry = appDbContext.TrancheTypes.OrderBy(x => x.TrancheType1).ToList();
			return entry;
		}

		public IEnumerable<CovenantConditionGroup> LoadCovenantConditionGroup()
		{
			//var entry = (from e in appDbContext.CovenantConditionGroups
			//			 orderby e.ConditionGroupDesc
			//			 select new CovenantConditionGroup()
			//			 {
			//				 ConditionGroupType = e.ConditionGroupType,
			//				 ConditionGroupDesc = e.ConditionGroupDesc
			//			 })
			//			.ToList();

			//var entry = (from e in appDbContext.CovenantConditionGroups
			//			 orderby e.ConditionGroupDesc
			//			 select e);

			var entry = appDbContext.CovenantConditionGroups.OrderBy(x =>x.ConditionGroupDesc).ToList();
			return entry;
		}

		public string AddTrancheType(InputTrancheType inputTrancheType)
		{
			try
			{
				//var entry = appDbContext.TrancheTypes
				//			.FirstOrDefault(e => e.TrancheType1 == inputTrancheType.TrancheType && e.TrancheTypeDesc == inputTrancheType.TrancheTypeDesc) ;

				//var entry = appDbContext.TrancheTypes.Where(e => e.TrancheType1 == inputTrancheType.TrancheType
				//							&& e.TrancheTypeDesc == inputTrancheType.TrancheTypeDesc).FirstOrDefault<TrancheType>();
				var entry = appDbContext.TrancheTypes.Where(e => e.TrancheType1 == inputTrancheType.TrancheType
															&& e.TrancheTypeDesc == inputTrancheType.TrancheTypeDesc).FirstOrDefault();

				if (entry == null)
				{
                    DataAccess.Models.GUIDE.AuditLog auditLog = new()
					{
						UserId = inputTrancheType.AuthorizeBy,
						AuditDate = DateTime.Now,
						RefNo = inputTrancheType.TrancheType,
						TransNo = "",
						AuditDesc = "Add new Tranche Type",
						AppName = "Tranche",
						TableName = "Tranche Types",
						OriginalValue = "",
						NewValue = inputTrancheType.TrancheType,
					};

					TrancheType newTranchType = new TrancheType()
					{
						TrancheType1 = inputTrancheType.TrancheType,
						TrancheTypeDesc = inputTrancheType.TrancheTypeDesc,
					};

					appDbContext.TrancheTypes.Add(newTranchType);
					appDbContext.SaveChanges();

					appDbContextGuide.AuditLogs.Add(auditLog);
					appDbContextGuide.SaveChanges();
					return "OK";
				}
				else
				{
					return "NotFound";
				}		
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}

		public IEnumerable<CovenantConditionViewModel> LoadCovenantConditionByGroup(string conditionGroupDesc)
		{
			//var entry = (from cc in appDbContext.CovenantConditions
			//			 join ccg in appDbContext.CovenantConditionGroups on cc.ConditionGroup equals ccg.ConditionGroupType
			//			 where ccg.ConditionGroupDesc == conditionGroupDesc
			//			 orderby cc.ConditionDesc
			//			 select new CovenantConditionViewModel
			//			 {
			//				 ConditionType = cc.ConditionType,
			//				 ConditionDesc = cc.ConditionDesc,
			//                          ConditionGroupDesc = ccg.ConditionGroupDesc
			//			 })
			//			 .ToList();

			
			var entry = appDbContext.CovenantConditions
							.Join(
									appDbContext.CovenantConditionGroups,
									 t1 => t1.ConditionGroup,
									 t2 => t2.ConditionGroupType,
									 (t1, t2) => new
									 {
										 ConditionType = t1.ConditionType,
										 ConditionDesc = t1.ConditionDesc,
										 ConditionGroupDesc = t2.ConditionGroupDesc
									 })
							.Where(x => x.ConditionGroupDesc == conditionGroupDesc)
							.Select(x => new CovenantConditionViewModel()
							{
								ConditionType = x.ConditionType,
								ConditionDesc = x.ConditionDesc,
								ConditionGroupDesc = x.ConditionGroupDesc
							})
							.ToList();

			return entry;
		}

		public string AddCovenantCondition(InputCovenantCondition inputCovenantCondition)
		{
			try
			{
				// does the group exist?
				var entryGp = appDbContext.CovenantConditionGroups
							.FirstOrDefault(e => e.ConditionGroupDesc == inputCovenantCondition.conditionGroupDesc);

				// Yes
				if (entryGp != null)
				{					
					// does condition exist
					var entry = appDbContext.CovenantConditions
							.FirstOrDefault(e => e.ConditionDesc == inputCovenantCondition.conditionDesc && 
												 e.ConditionGroup == entryGp.ConditionGroupType);

					// no exist condition
					// No, to be new
					if (entry == null)
					{
						DataAccess.Models.GUIDE.AuditLog auditLog = new()
						{
							UserId = inputCovenantCondition.AuthorizeBy,
							AuditDate = DateTime.Now,
							RefNo = inputCovenantCondition.conditionGroupDesc,
							TransNo = "",
							AuditDesc = "Add new Covenant condition",
							AppName = "Covenant",
							TableName = "Covenant Condition",
							OriginalValue = "",
							NewValue = inputCovenantCondition.conditionDesc,
						};

						CovenantCondition newCovenantCondition = new CovenantCondition
						{
							ConditionDesc = inputCovenantCondition.conditionDesc,
							ConditionGroup = entryGp.ConditionGroupType,
						};

						appDbContext.CovenantConditions.Add(newCovenantCondition);
						appDbContext.SaveChanges();

						appDbContextGuide.AuditLogs.Add(auditLog);
						appDbContextGuide.SaveChanges();

						return "OK";
					}	
					else
					{
						return "NotFound";
					}
				}
				else
				{
					// Create new group
					// then create new condition
					int maxGroupType = appDbContext.CovenantConditionGroups.Max(p => p.ConditionGroupType);

					CovenantConditionGroup newCovenantConditionGroup = new CovenantConditionGroup
					{
						ConditionGroupType = (byte)(maxGroupType + 1),
						ConditionGroupDesc = inputCovenantCondition.conditionGroupDesc,

					};

                    CovenantCondition newCovenantCondition = new CovenantCondition
                    {
                        ConditionDesc = inputCovenantCondition.conditionDesc,
                        ConditionGroup = newCovenantConditionGroup.ConditionGroupType,  // (byte)(maxGroupType + 1),
                    };

                    DataAccess.Models.GUIDE.AuditLog auditLog1 = new()
					{
						UserId = inputCovenantCondition.AuthorizeBy,
						AuditDate = DateTime.Now,
						RefNo = (maxGroupType + 1).ToString(),
						TransNo = "",
						AuditDesc = "Add new Covenant condition group",
						AppName = "Covenant",
						TableName = "Covenant Condition Group",
						OriginalValue = "",
						NewValue = inputCovenantCondition.conditionGroupDesc,
					};

					DataAccess.Models.GUIDE.AuditLog auditLog2 = new()
					{
						UserId = inputCovenantCondition.AuthorizeBy,
						AuditDate = DateTime.Now,
						RefNo = inputCovenantCondition.conditionGroupDesc,
						TransNo = "",
						AuditDesc = "Add new Covenant condition",
						AppName = "Covenant",
						TableName = "Covenant Condition",
						OriginalValue = "",
						NewValue = inputCovenantCondition.conditionDesc,
					};

                    appDbContext.CovenantConditionGroups.Add(newCovenantConditionGroup);
                    appDbContext.CovenantConditions.Add(newCovenantCondition);
                    appDbContext.SaveChanges();

                    appDbContextGuide.AuditLogs.Add(auditLog1);
					appDbContextGuide.AuditLogs.Add(auditLog2);
					appDbContextGuide.SaveChanges();
					
					return "OK";
				}
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}


		public IEnumerable<CovenantReceiptTiming> LoadCovenantReceiptTiming()
		{
			//var entry = (from e in appDbContext.CovenantReceiptTimings
			//			 orderby e.Order
			//			 select new CovenantReceiptTiming()
			//			 {
			//				 TimingType = e.TimingType,
			//				 TimingDesc = e.TimingDesc,
			//				 Interval = e.Interval,
			//				 DatePart = e.DatePart,
			//				 Order	= e.Order,
			//			 })
			//			.ToList();

			//var entry = (from e in appDbContext.CovenantReceiptTimings
			//			 orderby e.Order
			//			 select e);

			var entry = appDbContext.CovenantReceiptTimings.OrderBy(e => e.Order).ToList();
            return entry;
		}


		public string AddCovenantReceiptTiming(InputCovenantReceiptTiming inputCovenantReceiptTiming)
		{
			try
			{
				var entry = appDbContext.CovenantReceiptTimings
							.FirstOrDefault(e => e.Interval == inputCovenantReceiptTiming.Interval
												&& e.DatePart == inputCovenantReceiptTiming.DatePart
												);

				if (entry == null)
				{
					int MaxRecord = appDbContext.CovenantReceiptTimings.Max(p => p.TimingType);

					int MaxOrder = appDbContext.CovenantReceiptTimings
										.Where(x => x.DatePart == inputCovenantReceiptTiming.DatePart
										   && x.Interval <= inputCovenantReceiptTiming.Interval).Max(p => p.Order);

					var entryUpdate = appDbContext.CovenantReceiptTimings
										.Where(e => e.Order > MaxOrder).ToList();
					entryUpdate.ForEach(s => s.Order = (byte)(s.Order + 1));
					appDbContext.UpdateRange(entryUpdate);
					appDbContext.SaveChanges();

					CovenantReceiptTiming newCovenantReceiptTiming = new CovenantReceiptTiming()
					{
						TimingType = (byte)(MaxRecord + 1),
						//TimingDesc = inputCovenantReceiptTiming.Interval + " " + inputCovenantReceiptTiming.DatePart,
						TimingDesc = inputCovenantReceiptTiming.Interval +  
									(inputCovenantReceiptTiming.DatePart == "d" ? " days" : " months"),
						Interval = (byte)(inputCovenantReceiptTiming.Interval),
						DatePart = inputCovenantReceiptTiming.DatePart,
						Order = (byte)(MaxOrder + 1),
					};
					appDbContext.CovenantReceiptTimings.Add(newCovenantReceiptTiming);
					appDbContext.SaveChanges();

					DataAccess.Models.GUIDE.AuditLog auditLog = new()
					{
						UserId = inputCovenantReceiptTiming.AuthorizeBy,
						AuditDate = DateTime.Now,
						RefNo = inputCovenantReceiptTiming.Interval + " " + inputCovenantReceiptTiming.DatePart,
						TransNo = "",
						AuditDesc = "Add new Covenant Receipt Timing",
						AppName = "Tranche",
						TableName = "Covenant Receipt Timing",
						OriginalValue = "",
						NewValue = inputCovenantReceiptTiming.Interval + " " + inputCovenantReceiptTiming.Interval + " " +
									(inputCovenantReceiptTiming.DatePart == "d" ? "days" : "months"),
					};

					appDbContextGuide.AuditLogs.Add(auditLog);
					appDbContextGuide.SaveChanges();

					return "OK";
				}
				else
				{
					return "NotFound";
				}
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
	}
}
