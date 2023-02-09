using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class CartStoreService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public CartStoreService(ApplicationContext context)
		{
			_Context = context;
		}
		public List<CartStore> cartstroes = new List<CartStore>()
		{ };
		public async Task<List<CartStore>> GetCartStoreNoDataBaseAsync()
		{
			return await Task.FromResult(cartstroes);
		}
		public async Task<List<TableCartStore>> GetCartStoreAsync()
		{
			var u = _Context.TableCartStore.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewCartStore(TableCartStore NewCartStore)
		{
			_Context.TableCartStore.Add(NewCartStore);

			_Context.SaveChanges();//บันทึกลง SQL

		}

		public void DeleteCartStore(TableCartStore DeleteCartStore)
		{
			var FindID = _Context.TableCartStore.First(e => e.IDLink == DeleteCartStore.IDLink && e.CartStoreUserID == DeleteCartStore.CartStoreUserID);

			_Context.TableCartStore.Remove(FindID);
			_Context.SaveChanges();
		}
	}
}
