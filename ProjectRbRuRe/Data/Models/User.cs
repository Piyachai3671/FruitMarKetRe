using Microsoft.AspNetCore.Components;
using ProjectRbRuRe.Data.ModelData;
using System.ComponentModel.DataAnnotations;

namespace ProjectRbRuRe.Data.Models
{
	public class User
	{
		public int UserID { get; set; }
		[Required(ErrorMessage = "กรุณากรอกชื่อ - นามสกุล !")]
		[MinLength(2, ErrorMessage = "รหัสผู้ใช้ต้องมี 2 ตัวอักษรขึ้นไป !")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "กรุณากรอกรหัสผู้ใช้!")]
		[MinLength(6, ErrorMessage = "รหัสผู้ใช้ต้องมี 6 ตัวอักษรขึ้นไป !")]
		public string? Username { get; set; }
		[Required(ErrorMessage = "กรุณากรอกรหัสผ่าน !")]
		[MinLength(6, ErrorMessage = "รหัสผ่านต้องมี 6 ตัวอักษรขึ้นไป !")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์ !")]
		[MinLength(10, ErrorMessage = "เบอร์โทรศัพท์ต้องมี 10 ตัวอักษรเท่านั้น !")]
		public string? Tel { get; set; }
		public string? Permission { get; set; }
		[Required(ErrorMessage = "กรุณากรอกที่อยู่ !")]
		[MinLength(1, ErrorMessage = "ที่อยู่ต้องมี 1 ตัวอักษรขึ้นไป !")]
		public string? Address { get; set; }
		[Required(ErrorMessage = "กรุณาเลือกจังหวัด !")]
		public string? Province { get; set; }
		[Required(ErrorMessage = "กรุณาเลือกอำเภอ !")]
		public string? District { get; set; }
		[Required(ErrorMessage = "กรุณาเลือกตำบล !")]
		public string? SubDistrict { get; set; }
		[Required(ErrorMessage = "กรุณากรอกเลขไปรษณีย์ !")]
		[MinLength(5, ErrorMessage = "เลขไปรษณีย์ต้องมี 5 ตัวอักษรขึ้นไป !")]
		public string? Postcode { get; set; }
		[Required(ErrorMessage = "กรุณากรอกชื่อร้านค้า !")]
		[MinLength(2, ErrorMessage = "ชื่อร้านค้าต้องมี 2 ตัวอักษรขึ้นไป !")]
		public string? StoreName { get; set; }

		//public bool Usernull = true;
		public User() { }
		public User ToUi(TableUser tableUser) //UI ไปเทเบิล
		{
			//if (tableUser is null) return new User();
			if (tableUser is null)
			{
				return new User()
				{
					
				};
			}

				return new User
			{
				UserID = tableUser.UserID,
				Username = tableUser.Username,
				Password = tableUser.Password,

				Name = tableUser.Name,
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
