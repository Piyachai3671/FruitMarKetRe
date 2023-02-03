using ProjectRbRuRe.Data.ModelData;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.Models
{
	public class Store
	{
		public int StoreID { get; set; }
		[Required(ErrorMessage = "กรุณากรอกชื่อร้านค้า !")]
		[MinLength(2, ErrorMessage = "ชื่อร้านค้าต้องมี 2 ตัวอักษรขึ้นไป !")]
		[MaxLength(30, ErrorMessage = "ชื่อร้านค้าต้องมีอักษรต่ำกว่า 30 ตัวอักษร !")]
		public string? SellerName { get; set; }
		public string? SellerDescription { get; set; }
		public string? BankName { get; set; }
		public string? AccountName { get; set; }
		public string? AccountNumber { get; set; }
		public int UserID { get; set; }

		public string? ImgProfile { get; set; }
		public string? ImgCover { get; set; }

		public Store ToUi(TableStore tableStore) //UI ไปเทเบิล
		{
			return new Store
			{
				StoreID = tableStore.StoreID,
				SellerName = tableStore.SellerName,
				SellerDescription = tableStore.SellerDescription,

				BankName = tableStore.BankName,
				AccountName = tableStore.AccountName,
				AccountNumber = tableStore.AccountNumber,


				UserID = tableStore.UserID,

				ImgProfile = tableStore.ImgProfile,
				ImgCover = tableStore.ImgCover,
			};

		}

		public TableStore ToTable(Store NewStore)
		{
			return new TableStore
			{
				StoreID = NewStore.StoreID,
				SellerName = NewStore.SellerName,
				SellerDescription = NewStore.SellerDescription,

				BankName = NewStore.BankName,
				AccountName = NewStore.AccountName,
				AccountNumber = NewStore.AccountNumber,
				UserID = NewStore.UserID,

				ImgProfile = NewStore.ImgProfile,
				ImgCover = NewStore.ImgCover,
			};
		}
	}
}
