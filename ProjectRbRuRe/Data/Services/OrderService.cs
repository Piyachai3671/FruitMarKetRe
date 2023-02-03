using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class OrderService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public OrderService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<Order> orders = new List<Order>()
		{

		};
		//public async Task<List<Order>> GetOrderAsync()
		//{
		//    return await Task.FromResult(orders);
		//}
		public async Task<List<TableOrder>> GetOrderAsync()
		{

			var u = _Context.TableOrder.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewOrder(TableOrder NewOrder)
		{
			_Context.TableOrder.Add(NewOrder);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void EditOrder(TableOrder EditOrder)
		{
			var FindID = _Context.TableOrder.First(e => e.OrderID == EditOrder.OrderID);
			FindID.OrderDateCreate = EditOrder.OrderDateCreate;
			FindID.OrderDateEnd = EditOrder.OrderDateEnd;
			FindID.OrderStatus = EditOrder.OrderStatus;
			
			FindID.OrderNameExpress = EditOrder.OrderNameExpress;
			FindID.OrderNumberExpress = EditOrder.OrderNumberExpress;
			FindID.OrderImgPay = EditOrder.OrderImgPay;

			_Context.TableOrder.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}
