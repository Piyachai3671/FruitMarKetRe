using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class Order
	{
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
		public Order()
		{ }
		public Order ToUi(TableOrder tableOrder) //UI ไปเทเบิล
		{

			return new Order
			{
				OrderID = tableOrder.OrderID,
				OrderSumPrice = tableOrder.OrderSumPrice,
				//เวลา
				OrderDateCreate = tableOrder.OrderDateCreate,
				OrderDateEnd = tableOrder.OrderDateEnd,
				OrderDatePaySuccess = tableOrder.OrderDatePaySuccess,
				OrderStatus = tableOrder.OrderStatus,
				//ส่วนของรายละเอียดผู้ซื้อ
				OrderUserID = tableOrder.OrderUserID,
				Ordername = tableOrder.Ordername,
				OrderAddress = tableOrder.OrderAddress,
				OrderProvince = tableOrder.OrderProvince,
				OrderDistrict = tableOrder.OrderDistrict,
				OrderSubDistrict = tableOrder.OrderSubDistrict,
				OrderPostcode = tableOrder.OrderPostcode,
				OrderTel = tableOrder.OrderTel,
				//ส่วนของรายละเอียดผู้ขาย
				OrderStoreID = tableOrder.OrderStoreID,
				OrderStoreName = tableOrder.OrderStoreName,



				OrderNumberExpress = tableOrder.OrderNumberExpress,
				OrderNameExpress = tableOrder.OrderNameExpress,

				OrderImgPay = tableOrder.OrderImgPay,
			};
		}

		public TableOrder ToTable(Order NewOrder)
		{
			return new TableOrder
			{
				OrderID = NewOrder.OrderID,
				OrderSumPrice = NewOrder.OrderSumPrice,
				//เวลา
				OrderDateCreate = NewOrder.OrderDateCreate,
				OrderDateEnd = NewOrder.OrderDateEnd,
				OrderDatePaySuccess = NewOrder.OrderDatePaySuccess,
				OrderStatus = NewOrder.OrderStatus,
				//ส่วนของรายละเอียดผู้ซื้อ
				OrderUserID = NewOrder.OrderUserID,
				Ordername = NewOrder.Ordername,
				OrderAddress = NewOrder.OrderAddress,
				OrderProvince = NewOrder.OrderProvince,
				OrderDistrict = NewOrder.OrderDistrict,
				OrderSubDistrict = NewOrder.OrderSubDistrict,
				OrderPostcode = NewOrder.OrderPostcode,
				OrderTel = NewOrder.OrderTel,
				//ส่วนของรายละเอียดผู้ขาย
				OrderStoreID = NewOrder.OrderStoreID,
				OrderStoreName = NewOrder.OrderStoreName,


				OrderNumberExpress = NewOrder.OrderNumberExpress,
				OrderNameExpress = NewOrder.OrderNameExpress,

				OrderImgPay = NewOrder.OrderImgPay,
			};
		}
	}
}
