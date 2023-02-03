using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class AmphoeService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public AmphoeService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<Amphoe>	amphoes	 = new List<Amphoe>()
		{

		};

		public async Task<List<TableAmphoe>> GetAmphoeAsync()
		{

			var u = _Context.TableAmphoe.ToList();
			return await Task.FromResult(u);
		}
	
	}
}
