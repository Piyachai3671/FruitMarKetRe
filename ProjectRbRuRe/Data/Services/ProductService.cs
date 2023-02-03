using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class ProductService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public ProductService(ApplicationContext context)
		{
			_Context = context;
		}

		//private List<Product> products = new List<Product>()
		//{

		//};
		//public async Task<List<Product>> GetProductsAsync()
		//{
		//	return await Task.FromResult(products);
		//}

		public async Task<List<TableProduct>> GetProductsAsync()
		{

			var u = _Context.TableProduct.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewProduct(TableProduct NewProduct)
		{
			_Context.TableProduct.Add(NewProduct);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void EditProduct(TableProduct EditProduct)
		{
			var FindID = _Context.TableProduct.First(e => e.IDProduct == EditProduct.IDProduct);
			FindID.NameProduct = EditProduct.NameProduct;
			FindID.RemainderProduct = EditProduct.RemainderProduct;
			FindID.UnitProduct = EditProduct.UnitProduct;
			FindID.PriceProduct = EditProduct.PriceProduct;
			FindID.ProductDescription = EditProduct.ProductDescription;
            FindID.ProductStatus= EditProduct.ProductStatus;
			FindID.ProductImg = EditProduct.ProductImg;


			_Context.TableProduct.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
		public void DeleteProduct(TableProduct DeleteProduct)
		{
			var FindID = _Context.TableProduct.First(e => e.IDProduct == DeleteProduct.IDProduct);

			_Context.TableProduct.Remove(FindID);
			_Context.SaveChanges();
		}
	}
}
