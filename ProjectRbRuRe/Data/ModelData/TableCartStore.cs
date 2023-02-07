using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("CartStore")]
	public class TableCartStore
	{
		[Key]
        public int CartStoreID { get; set; }
        public int IDLink { get; set; }
        
		public int? CartStoreUserID { get; set; }  //ชื่อ

	}
}
