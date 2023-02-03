using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class tambol
	{
		public int Id { get; set; }
		public int? tcode { get; set; }
		public string? tname { get; set; }
		public int? acode { get; set; }
		public string? aname { get; set; }
		public int? pcode { get; set; }
		public string? pname { get; set; }

		public tambol ToUi(Tabletambol tabletambol) //UI ไปเทเบิล
		{
			return new tambol
			{
					Id = tabletambol.Id,
				tcode = tabletambol.tcode,
				tname = tabletambol.tname,
				acode = tabletambol.acode,
				aname = tabletambol.aname,
				pcode = tabletambol.pcode,
				pname = tabletambol.pname,
			};

		}

		public Tabletambol ToTable(tambol NewTambol)
		{
			return new Tabletambol
			{	
				Id = NewTambol.Id,
				tcode = NewTambol.tcode,
				tname = NewTambol.tname,
				acode = NewTambol.acode,
				aname = NewTambol.aname,
				pcode = NewTambol.pcode,
				pname = NewTambol.pname,
			};
		}
	}
}
