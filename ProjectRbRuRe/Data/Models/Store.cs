using ProjectRbRuRe.Data.ModelData;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.Models
{
	public class Store
	{
		public int StoreID { get; set; }
		[Required(ErrorMessage = "กรุณากรอกชื่อร้านค้า !")]
		[MinLength(2, ErrorMessage = "ชื่อร้านค้าต้องมี 2 ตัวอักษรขึ้นไป !")]
		public string? SellerName { get; set; }
		public string? SellerDescription { get; set; }
		[Required(ErrorMessage = "กรุณาเลือกธนาคาร !")]
		public string? BankName { get; set; }
		[Required(ErrorMessage = "กรุณากรอกชื่อบัญชีธนาคาร !")]
		[MinLength(2, ErrorMessage = "ชื่อบัญชีธนาคารต้องมี 2 ตัวอักษรขึ้นไป !")]
		public string? AccountName { get; set; }
		[Required(ErrorMessage = "กรุณากรอกเลขบัญชีธนาคาร !")]
		[MinLength(10, ErrorMessage = "เลขบัญชีธนาคารต้องมี 10 ตัวอักษรเท่านั้น !")]
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
