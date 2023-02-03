using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("Report")]
	public class TableReport
	{
		[Key]
		public int ReportID { get; set; }
		public int? ReportUserID { get; set; }
		public string? ReportUserName { get; set; }

		public int? ReportOrderID { get; set; }
		public int? ReportOrderItemID { get; set; }
		public double? ReportPriceSum { get; set; }
		public DateTime ReportDate { get; set; }
		public string? ReportStatus { get; set; }

		public int ReportStoreID { get; set; }
		public string? ReportStoreName { get; set; }
	}
}
