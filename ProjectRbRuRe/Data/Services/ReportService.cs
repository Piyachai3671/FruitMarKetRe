using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class ReportService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public ReportService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<Report> Reports = new List<Report>()
		{

		};
		//public async Task<List<Report>> GetReportsAsync()
		//{
		//	return await Task.FromResult(Reports);
		//}
		public async Task<List<TableReport>> GetReportsAsync()
		{

			var u = _Context.TableReport.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewReport(TableReport NewReport)
		{
			_Context.TableReport.Add(NewReport);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void EditReport(TableReport EditReport)
		{
			var FindID = _Context.TableReport.First(e => e.ReportID == EditReport.ReportID);
			FindID.ReportDate = EditReport.ReportDate;
			FindID.ReportStatus = EditReport.ReportStatus;
			FindID.ReportPriceSum = EditReport.ReportPriceSum;


			_Context.TableReport.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}
