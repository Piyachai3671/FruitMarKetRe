using ProjectRbRuRe.Data.ModelData;
namespace ProjectRbRuRe.Data.Models
{
	public class Report
	{

		public int ReportID { get; set; }
		public int? ReportUserID { get; set; }
		public string? ReportUserName { get; set; } //ชื่อลูกค้าไม่ใช่รหัสผู้ใช้

		public int? ReportOrderID { get; set; }
		public int? ReportOrderItemID { get; set; }	
		public double? ReportPriceSum { get; set; }
		public string? ReportStatus { get; set; }
		public DateTime ReportDate { get; set; }

		public int ReportStoreID { get; set; }
		public string? ReportStoreName { get; set; }

		public Report() { }
		public Report ToUi(TableReport tableReport) //UI ไปเทเบิล
		{

			return new Report
			{
				ReportID = tableReport.ReportID,
				ReportUserID = tableReport.ReportUserID,
				ReportUserName = tableReport.ReportUserName,

				ReportOrderID = tableReport.ReportOrderID,
				ReportOrderItemID = tableReport.ReportOrderItemID,		
				ReportPriceSum = tableReport.ReportPriceSum,
				ReportDate = tableReport.ReportDate,
				ReportStatus = tableReport.ReportStatus,

				ReportStoreID= tableReport.ReportStoreID,
				ReportStoreName = tableReport.ReportStoreName,
			};

		}

		public TableReport ToTable(Report NewReport)
		{
			return new TableReport
			{
				ReportID = NewReport.ReportID,
				ReportUserID = NewReport.ReportUserID,
				ReportUserName = NewReport.ReportUserName,
				ReportOrderID = NewReport.ReportOrderID,
				ReportOrderItemID = NewReport.ReportOrderItemID,
				ReportPriceSum = NewReport.ReportPriceSum,
				ReportDate = NewReport.ReportDate,
				ReportStatus = NewReport.ReportStatus,

				ReportStoreID = NewReport.ReportStoreID,
				ReportStoreName = NewReport.ReportStoreName,
			};
		}
	}
}
