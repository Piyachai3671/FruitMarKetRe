using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("Province")]
	public class TableProvince
	{
		[Key]
		public int Id { get; set; }
		public int? pcode { get; set; }
		public string? pname { get; set; }
		public int? type_soilder { get; set; }
	}
}
