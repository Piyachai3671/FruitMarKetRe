using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data.Models
{
	public class User
	{
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
		public User() { }
		public User ToUi(TableUser tableUser) //UI ไปเทเบิล
		{
			return new User
			{
				UserID = tableUser.UserID,
				Username = tableUser.Username,
				Password = tableUser.Password,

				Name = tableUser.Name,
				Email = tableUser.Email,
				Tel = tableUser.Tel,

				Address = tableUser.Address,
				Province = tableUser.Province,
				District = tableUser.District,
				SubDistrict = tableUser.SubDistrict,
				Postcode = tableUser.Postcode,

				Permission = tableUser.Permission,

				StoreName = tableUser.StoreName,
			};

		}

		public TableUser ToTable(User NewUser)
		{
			return new TableUser
			{
				UserID = NewUser.UserID,
				Username = NewUser.Username,
				Password = NewUser.Password,

				Name = NewUser.Name,
				Email = NewUser.Email,
				Tel = NewUser.Tel,

				Address = NewUser.Address,
				Province = NewUser.Province,
				District = NewUser.District,
				SubDistrict = NewUser.SubDistrict,
				Postcode = NewUser.Postcode,

				Permission = NewUser.Permission,

				StoreName = NewUser.StoreName,
			};
		}
	}
}
