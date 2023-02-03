using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("Amphoe")]
	public class TableAmphoe
	{
		[Key]
		public int Id { get; set; }
		public int? acode { get; set; }
		public string? aname { get; set; }
		public int? pcode { get; set; }
		public string? pname { get; set; }
		
	}
}
