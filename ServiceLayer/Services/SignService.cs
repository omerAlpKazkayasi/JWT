﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
	public static class SignService
	{
		public static SecurityKey GetSymetricSecurityKey(string SecurityKey)
		{
			return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
		}
	}
}
