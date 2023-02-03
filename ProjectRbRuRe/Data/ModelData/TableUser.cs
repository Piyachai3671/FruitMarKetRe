using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.ModelData
{
	[Table("User")]
	public class TableUser
	{
		[Key]
		public int UserID { get; set; }

		public string? Name { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }

		public string? Email { get; set; }
		public string? Tel { get; set; }
		public string? Permission { get; set; }

		public string? Address { get; set; }
		public string? Province { get; set; }
		public string? District { get; set; }
		public string? SubDistrict { get; set; }
		public string? Postcode { get; set; }

		public string? StoreName { get; set; }
	}
}
