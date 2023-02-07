using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class CartStore
	{
        public int CartStoreID { get; set; }
        public int IDLink { get; set; }


		public int? CartStoreUserID { get; set; }  //ชื่อ
		public CartStore ToUi(TableCartStore tableCartStore) //UI ไปเทเบิล
		{
			return new CartStore
			{
                IDLink = tableCartStore.IDLink,

				CartStoreUserID= tableCartStore.CartStoreUserID,
			};

		}

		public TableCartStore ToTable(CartStore NewCartStore)
		{
			return new TableCartStore
			{
                IDLink = NewCartStore.IDLink,
               
				CartStoreUserID = NewCartStore.CartStoreUserID,
			};
		}
	}
}
