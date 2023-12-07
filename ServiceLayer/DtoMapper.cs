﻿using AutoMapper;
using CoreLayer;
using CoreLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
	internal class DtoMapper : Profile
	{
		public DtoMapper()
		{
			CreateMap<ProductDto, Product>().ReverseMap();
			CreateMap<UserAppDto, UserApp>().ReverseMap();
		}
	}
}
