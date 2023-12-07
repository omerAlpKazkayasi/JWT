using CoreLayer.DTOs;
using SharedLibrary.DTOs;

namespace CoreLayer.Services
{
	public interface IUserService
	{
		Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

		Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
	}

}
