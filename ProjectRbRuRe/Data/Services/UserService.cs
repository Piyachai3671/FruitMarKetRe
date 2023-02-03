using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;

namespace ProjectRbRuRe.Data.Services
{
	public class UserService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public UserService(ApplicationContext context)
		{
			_Context = context;
		}

		private List<User> Users = new List<User>()
		{
			
		};
		//public async Task<List<User>> GetUserAsync()
		//{
		//    return await Task.FromResult(Users);
		//}
		public async Task<List<TableUser>> GetUserAsync()
		{
			var u = _Context.TableUser.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewUser(TableUser NewUser)
		{
			_Context.TableUser.Add(NewUser);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void EditUser(TableUser EditUser)
		{
			var FindID = _Context.TableUser.First(e => e.UserID == EditUser.UserID);
			FindID.Name = EditUser.Name;
			FindID.Address = EditUser.Address;
			FindID.Province = EditUser.Province;
			FindID.District = EditUser.District;
			FindID.SubDistrict = EditUser.SubDistrict;
			FindID.Postcode = EditUser.Postcode;
			FindID.Tel = EditUser.Tel;
			FindID.Password = EditUser.Password;

			_Context.TableUser.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
		public Task<TableUser> SelectUser(string username, string password)
		{
			var u = _Context.TableUser.FirstOrDefault(e => e.Username == username && e.Password == password);
			if (u != null)
			{
				return Task.FromResult(u);
			}
			else
			{
				return Task.FromResult(new TableUser());
			}
		}
	}
}
