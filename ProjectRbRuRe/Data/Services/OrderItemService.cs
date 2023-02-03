using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class OrderItemService
	{

		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public OrderItemService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<OrderItem> ordersitems = new List<OrderItem>()
		{
			new OrderItem{

			},
		};
		//public async Task<List<OrderItem>> GetOrderItemServices()
		//{
		//	return await Task.FromResult(ordersitems);
		//}
		public async Task<List<TableOrderItem>> GetOrderItemServices()
		{
			var u = _Context.TableOrderItem.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewOrderItem(TableOrderItem NewOrderItem)
		{
			_Context.TableOrderItem.Add(NewOrderItem);

			_Context.SaveChanges();//บันทึกลง SQL

		}
	}
}
