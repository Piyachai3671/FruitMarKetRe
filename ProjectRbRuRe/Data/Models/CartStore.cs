using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class CartStore
	{
		public int CartStoreID { get; set; }
		public string? NameStore { get; set; }  //ชื่อ

		public int? CartStoreUserID { get; set; }  //ชื่อ
		public CartStore ToUi(TableCartStore tableCartStore) //UI ไปเทเบิล
		{
			return new CartStore
			{
				NameStore= tableCartStore.NameStore,
					CartStoreUserID= tableCartStore.CartStoreUserID,
			};

		}

		public TableCartStore ToTable(CartStore NewCartStore)
		{
			return new TableCartStore
			{
				NameStore = NewCartStore.NameStore,
				CartStoreUserID = NewCartStore.CartStoreUserID,
			};
		}
	}
}
