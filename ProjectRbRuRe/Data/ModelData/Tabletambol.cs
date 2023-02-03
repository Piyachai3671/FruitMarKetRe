using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("tambol")]
	public class Tabletambol
	{
		[Key]
		public int Id { get; set; }
		public int? tcode { get; set; }
		public string? tname { get; set; }
		public int? acode { get; set; }
		public string? aname { get; set; }
		public int? pcode { get; set; }
		public string? pname { get; set; }
	}
}

