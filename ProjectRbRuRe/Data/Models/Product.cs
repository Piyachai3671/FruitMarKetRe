using ProjectRbRuRe.Data.ModelData;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.Models
{
	public class Product
	{
		public int IDProduct { get; set; }  //IDรหัสสินค้า
		[Required(ErrorMessage = "กรุณากรอกชื่อสินค้า !")]
		[MinLength(2, ErrorMessage = "ชื่อสินค้าต้องมี 2 ตัวอักษรขึ้นไป !")]
		public string? NameProduct { get; set; }  //ชื่อ
		[Required(ErrorMessage = "กรุณากรอกจำนวนสินค้าที่มากกว่า 1 หน่วย !")]
		public int? RemainderProduct { get; set; } //สินค้าคงเหลือ
		[Required(ErrorMessage = "กรุณาเลือกหน่วยของสินค้า !")]
		public string? UnitProduct { get; set; } //หน่วย
		[Required(ErrorMessage = "กรุณากรอกราคาสินค้า !")]
		public double? PriceProduct { get; set; }  //ราคาปลีก
		[Required(ErrorMessage = "กรุณากรอกรายละเอียดสินค้า !")]
		[MinLength(10, ErrorMessage = "รายละเอียดสินค้าสินค้าต้องมี 10 ตัวอักษรขึ้นไป !")]
		public string? ProductDescription { get; set; }
		[Required(ErrorMessage = "กรุณาเลือกสถานะสินค้า !")]
		public string? ProductStatus { get; set; }

		public int ProductStoreID { get; set; }
		public string? ProductStoreName { get; set; }
		public int ProductCartID { get; set; }
		[Required(ErrorMessage = "กรุณาเลือกภาพสินค้า !")]
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
