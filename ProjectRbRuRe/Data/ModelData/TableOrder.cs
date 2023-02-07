using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("Order")]
	public class TableOrder
	{
		[Key]
		public int OrderID { get; set; }
		public double? OrderSumPrice { get; set; }
		public int OrderUserID { get; set; }
		public string? Ordername { get; set; } //เก็บเพราะ ใช้Compunent radzen เลยไม่ยาก findall หาไอดี
		public string? OrderAddress { get; set; }
		public string? OrderProvince { get; set; }
		public string? OrderDistrict { get; set; }
		public string? OrderSubDistrict { get; set; }
		public string? OrderTel { get; set; }
		public string? OrderPostcode { get; set; }
		public int OrderStoreID { get; set; }
		public string? OrderStoreName { get; set; }
		public DateTime OrderDateCreate { get; set; }
		public DateTime OrderDateEnd { get; set; }
		public DateTime OrderDatePaySuccess { get; set; }
		public string? OrderStatus { get; set; }
		
		
		public string? OrderNameExpress { get; set; }
		public string? OrderNumberExpress { get; set; }

		public string? OrderImgPay { get; set; }

	}

}
