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
		public void DeleteCartProduct(TableCartProduct DeleteCartProduct)
		{
			var FindID = _Context.TableCartProduct.First(e => e.CartProductProductID == DeleteCartProduct.CartProductProductID && e.CartProductUserID == DeleteCartProduct.CartProductUserID);

			_Context.TableCartProduct.Remove(FindID);
			_Context.SaveChanges();
		}
		public void EditCartProduct(TableCartProduct EditCartProduct)
		{
			var FindID = _Context.TableCartProduct.First(e => e.CartProductProductID == EditCartProduct.CartProductProductID && e.CartProductUserID == EditCartProduct.CartProductUserID);
			FindID.CartProductName = EditCartProduct.CartProductName;
			FindID.CartProductPrice = EditCartProduct.CartProductPrice;
			FindID.CartProductUnit = EditCartProduct.CartProductUnit;
			FindID.CartProductAmount = EditCartProduct.CartProductAmount;

			_Context.TableCartProduct.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}
