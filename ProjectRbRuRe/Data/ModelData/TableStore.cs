using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("Store")]
	public class TableStore
	{
		[Key]
		public int StoreID { get; set; }
		public string? SellerName { get; set; }
		public string? SellerDescription { get; set; }
		public string? BankName { get; set; }
		public string? AccountName { get; set; }
		public string? AccountNumber { get; set; }
		public int UserID { get; set; }
		public string? ImgProfile { get; set; }
		public string? ImgCover { get; set; }

	

	}
}
