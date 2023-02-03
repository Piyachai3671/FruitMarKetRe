using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class Product
	{
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

        public Product ToUi(TableProduct tableProduct) //UI ไปเทเบิล
		{
			return new Product
			{
				IDProduct= tableProduct.IDProduct,
				NameProduct = tableProduct.NameProduct,
				RemainderProduct = tableProduct.RemainderProduct,
				UnitProduct = tableProduct.UnitProduct,
				PriceProduct = tableProduct.PriceProduct,
				ProductDescription = tableProduct.ProductDescription,
				ProductStatus= tableProduct.ProductStatus,


				ProductStoreID = tableProduct.ProductStoreID,
				ProductStoreName= tableProduct.ProductStoreName,
				ProductCartID = tableProduct.ProductCartID,

                ProductImg = tableProduct.ProductImg,
            };

		}

		public TableProduct ToTable(Product NewProduct)
		{
			return new TableProduct
			{
				IDProduct = NewProduct.IDProduct,
				NameProduct = NewProduct.NameProduct,
				RemainderProduct = NewProduct.RemainderProduct,
				UnitProduct = NewProduct.UnitProduct,
				PriceProduct = NewProduct.PriceProduct,
				ProductDescription = NewProduct.ProductDescription,
				ProductStatus = NewProduct.ProductStatus,


				ProductStoreID = NewProduct.ProductStoreID,
				ProductStoreName = NewProduct.ProductStoreName,
				ProductCartID = NewProduct.ProductCartID,

                ProductImg = NewProduct.ProductImg,
            };
		}
	}
}
