using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class Amphoe
	{
		public int Id { get; set; }
		public int? acode { get; set; }
		public string? aname { get; set; }
		public int? pcode { get; set; }
		public string? pname { get; set; }
		

		public Amphoe ToUi(TableAmphoe tableAmphoe) //UI ไปเทเบิล
		{
			return new Amphoe
			{
				Id = tableAmphoe.Id,
				acode = tableAmphoe.acode,
				aname = tableAmphoe.aname,
				pcode = tableAmphoe.pcode,
				pname = tableAmphoe.pname,
				
			};

		}

		public TableAmphoe ToTable(Amphoe NewAmphoe)
		{
			return new TableAmphoe
			{
				Id = NewAmphoe.Id,
				acode = NewAmphoe.acode,
				aname = NewAmphoe.aname,
				pcode = NewAmphoe.pcode,
				pname = NewAmphoe.pname,
				
			};
		}
	}
}
