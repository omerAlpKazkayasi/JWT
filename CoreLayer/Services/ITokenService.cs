using CoreLayer.DTOs;

namespace CoreLayer.Services
{
	public interface ITokenService
	{
		TokenDto CreateToken(UserApp userApp);

		ClientTokenDto CreateTokenByClient(Client client);
	}

}
