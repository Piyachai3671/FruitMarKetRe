using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class TambolService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public TambolService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<tambol> tambols = new List<tambol>()
		{

		};

		public async Task<List<Tabletambol>> GetTambolAsync()
		{

			var u = _Context.Tabletambol.ToList();
			return await Task.FromResult(u);
		}
	}
}
