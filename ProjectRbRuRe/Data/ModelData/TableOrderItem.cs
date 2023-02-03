using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("OrderItem")]
	public class TableOrderItem
	{
		[Key]
		public int OrderItemID { get; set; }
		public int? OrderItemProductID { get; set; }
		public string? OrderItemProductName { get; set; }
		public int? OrderItemProductAmount { get; set; }
		public double? OrderItemProductPrice { get; set; }
		public double? OrderItemProductSumPrice { get; set; }
		public int OrderItemOrderID { get; set; }

	}
}
