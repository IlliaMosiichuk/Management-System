﻿using API.ViewModels;
using ApplicationCore.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderListItemViewModel>();

            CreateMap<OrderListItemViewModel, Order>()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
