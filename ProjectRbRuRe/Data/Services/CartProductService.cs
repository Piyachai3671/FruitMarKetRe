using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class CartProductService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public CartProductService(ApplicationContext context)
		{
			_Context = context;
		}
		public List<CartProduct> cartproducts = new List<CartProduct>()
		{
			//new CartProduct{ CartProductName="Dummy" ,CartProductStoreID=1 ,CartProductAmount=99 ,CartProductID=10, CartProductPrice=50,CartProductProductID=5,CartProductUnit="กล่อง"}
		};
		public async Task<List<CartProduct>> GetCartProductNoDataBaseAsync()
		{
			return await Task.FromResult(cartproducts);
		}

		public async Task<List<TableCartProduct>> GetCartProductAsync()
		{
			var u = _Context.TableCartProduct.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewCartProduct(TableCartProduct NewCartProduct)
		{
			_Context.TableCartProduct.Add(NewCartProduct);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		
	}
}
