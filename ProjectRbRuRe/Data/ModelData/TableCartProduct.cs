using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("CartProduct")]
	public class TableCartProduct
	{
		[Key]
		public int CartProductID { get; set; }
		public int? CartProductProductID { get; set; }
		public string? CartProductName { get; set; }
		public int? CartProductAmount { get; set; } //สินค้าคงเหลือ
		public string? CartProductUnit { get; set; } //หน่วย
		public double? CartProductPrice { get; set; }  //ราคาปลีก
		public double? CartProductSumPrice { get; set; }  //ราคาปลีก
		public int? CartProductStoreID { get; set; }
	}
}
