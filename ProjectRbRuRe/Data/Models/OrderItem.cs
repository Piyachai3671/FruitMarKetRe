using ProjectRbRuRe.Data.ModelData;
namespace ProjectRbRuRe.Data.Models
{
	public class OrderItem
	{
		public int OrderItemID { get; set; }
		public int? OrderItemProductID { get; set; }
		public string? OrderItemProductName { get; set; }
		public int? OrderItemProductAmount { get; set; }
		public double? OrderItemProductPrice { get; set; }
		public double? OrderItemProductSumPrice { get; set; }
		public int OrderItemOrderID { get; set; }

		public OrderItem()
		{ }
		public OrderItem ToUi(TableOrderItem tableOrderItem) //UI ไปเทเบิล
		{

			return new OrderItem
			{
				OrderItemID = tableOrderItem.OrderItemID,

				OrderItemProductID = tableOrderItem.OrderItemProductID,
				OrderItemProductName = tableOrderItem.OrderItemProductName,
				OrderItemProductAmount = tableOrderItem.OrderItemProductAmount,
				OrderItemProductPrice = tableOrderItem.OrderItemProductPrice,
				OrderItemProductSumPrice = tableOrderItem.OrderItemProductSumPrice,
				OrderItemOrderID = tableOrderItem.OrderItemOrderID,
			};
		}

		public TableOrderItem ToTable(OrderItem NewOrderItem)
		{
			return new TableOrderItem
			{
				OrderItemID = NewOrderItem.OrderItemID,

				OrderItemProductID = NewOrderItem.OrderItemProductID,
				OrderItemProductName = NewOrderItem.OrderItemProductName,
				OrderItemProductAmount = NewOrderItem.OrderItemProductAmount,
				OrderItemProductPrice = NewOrderItem.OrderItemProductPrice,
				OrderItemProductSumPrice = NewOrderItem.OrderItemProductSumPrice,
				OrderItemOrderID = NewOrderItem.OrderItemOrderID,
			};
		}
	}
}
