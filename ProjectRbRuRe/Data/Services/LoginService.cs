using ProjectRbRuRe.Data.ModelData;
using ProjectRbRuRe.Data.Models;
namespace ProjectRbRuRe.Data.Services
{
	public class LoginService
	{
		public TableUser UserToLogin;
        private UserService UserService; // เอาuser มาใช้
		public LoginService(UserService userService)
		{
			if (userService is null) return;
			UserService = userService;
			
		}
       
        public async Task<bool> Login(string UserName, string Password)
		{
			bool Status = false;
			
			TableUser? Users = await UserService.SelectUser(UserName, Password); //การล็อคอินมีได้แค่1คนจึงใช้การค้นหา

			
			if (Users.Username != null)
			{
                UserToLogin = Users;
				Status = true;
            }
			return await Task.FromResult(Status);
		}
		public bool LogOut()
		{
			UserToLogin = UserToLogin;
			bool Status = false;
            return Status;
		}
	}
}
