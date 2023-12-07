using CoreLayer;
using CoreLayer.DTOs;
using CoreLayer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SharedLibrary.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
	public class TokenService : ITokenService
	{
		private readonly UserManager<UserApp> _userManager;
		private readonly CustomTokenOptions _tokenOptions;
		public TokenService(UserManager<UserApp> userManager, IOptions<CustomTokenOptions> tokenOptions)//bir taneden fazla optionslarımızı olacağı için böyle birşey yapıyoruz
		{
			_userManager = userManager;
			_tokenOptions = tokenOptions.Value;
		}
		private string CreateRefreshToken()
		{
			var numberByte=new byte[32];
			using var rnd=RandomNumberGenerator.Create();
			rnd.GetBytes(numberByte);
			return Convert.ToBase64String(numberByte);
		}

		public TokenDto CreateToken(UserApp userApp)
		{
			throw new NotImplementedException();
		}

		public ClientTokenDto CreateTokenByClient(Client client)
		{
			throw new NotImplementedException();
		}
	}
}
