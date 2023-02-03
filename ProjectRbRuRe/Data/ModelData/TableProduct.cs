using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("Product")]
	public class TableProduct
	{
		[Key]
		public int IDProduct { get; set; }  //IDรหัสสินค้า
		public string? NameProduct { get; set; }  //ชื่อ
		public int? RemainderProduct { get; set; } //สินค้าคงเหลือ
		public string? UnitProduct { get; set; } //หน่วย


		public double? PriceProduct { get; set; }  //ราคาปลีก

		public string? ProductDescription { get; set; }
		public string? ProductStatus { get; set; }

		public int ProductStoreID { get; set; }
		public string? ProductStoreName { get; set; }
		public int ProductCartID { get; set; }
        public string? ProductImg { get; set; }
    }
}
