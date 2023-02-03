using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class StoreService
	{
		//private List<Store> stores = new List<Store>()
		//{


		//};
		//public async Task<List<Store>> GetStoresAsync()
		//{
		//	return await Task.FromResult(stores);
		//}
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public StoreService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<Store> Stores = new List<Store>()
		{

		};
		
		public async Task<List<TableStore>> GetStoresAsync()
		{

			var u = _Context.TableStore.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewStore(TableStore NewRStore)
		{
			_Context.TableStore.Add(NewRStore);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void EditStore(TableStore EditStore)
		{
			var FindID = _Context.TableStore.First(e => e.StoreID == EditStore.StoreID);
			FindID.SellerName = EditStore.SellerName;
			FindID.SellerDescription = EditStore.SellerDescription;
			FindID.BankName = EditStore.BankName;
			FindID.AccountName = EditStore.AccountName;
			FindID.AccountNumber = EditStore.AccountNumber;
			FindID.ImgProfile= EditStore.ImgProfile;
			FindID.ImgCover = EditStore.ImgCover;


			_Context.TableStore.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}
