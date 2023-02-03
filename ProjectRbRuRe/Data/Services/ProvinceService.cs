using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class ProvinceService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public ProvinceService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<province> provinces = new List<province>()
		{

		};
		public async Task<List<TableProvince>> GetProvinceAsync()
		{

			var u = _Context.TableProvince.ToList();
			return await Task.FromResult(u);
		}
	}
}
