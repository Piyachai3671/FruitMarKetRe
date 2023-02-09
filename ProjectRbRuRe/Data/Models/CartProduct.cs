using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class CartProduct
	{
		public int CartProductID { get; set; }
		public int? CartProductProductID { get; set; }
		public string? CartProductName { get; set; }
		public int? CartProductAmount { get; set; } //สินค้าคงเหลือ
		public string? CartProductUnit { get; set; } //หน่วย
		public double? CartProductPrice { get; set; }  //ราคาปลีก
		public double? CartProductSumPrice { get; set; }  //ราคาปลีก
		public int? CartProductStoreID { get; set; }
		public int? CartProductUserID { get; set; }

		public CartProduct ToUi(TableCartProduct tableCartProduct) //UI ไปเทเบิล
		{
			return new CartProduct
			{
				CartProductProductID = tableCartProduct.CartProductProductID,
				CartProductName = tableCartProduct.CartProductName,
				CartProductAmount = tableCartProduct.CartProductAmount,
				CartProductUnit = tableCartProduct.CartProductUnit,
				CartProductPrice = tableCartProduct.CartProductPrice,
				CartProductSumPrice = tableCartProduct.CartProductSumPrice,
				CartProductStoreID = tableCartProduct.CartProductStoreID,
				CartProductUserID = tableCartProduct.CartProductUserID
			};

		}

		public TableCartProduct ToTable(CartProduct NewCartProduct)
		{
			return new TableCartProduct
			{
				CartProductProductID = NewCartProduct.CartProductProductID,
				CartProductName = NewCartProduct.CartProductName,
				CartProductAmount = NewCartProduct.CartProductAmount,
				CartProductUnit = NewCartProduct.CartProductUnit,
				CartProductPrice = NewCartProduct.CartProductPrice,
				CartProductSumPrice = NewCartProduct.CartProductSumPrice,
				CartProductStoreID = NewCartProduct.CartProductStoreID,
				CartProductUserID = NewCartProduct.CartProductUserID
			};
		}
	}
}
