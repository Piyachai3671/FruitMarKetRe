using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class province
	{
		public int Id { get; set; }
		public int? pcode { get; set; }
		public string? pname { get; set; }
		public int? type_soilder { get; set; }

		public province ToUi(TableProvince tableProvince) //UI ไปเทเบิล
		{
			return new province
			{
				Id = tableProvince.Id,
				pcode = tableProvince.pcode,
				pname = tableProvince.pname,
				type_soilder = tableProvince.type_soilder,
			};

		}

		public TableProvince ToTable(province NewProvince)
		{
			return new TableProvince
			{
				Id = NewProvince.Id,
				pcode = NewProvince.pcode,
				pname = NewProvince.pname,
				type_soilder = NewProvince.type_soilder,
			};
		}
	}
}
