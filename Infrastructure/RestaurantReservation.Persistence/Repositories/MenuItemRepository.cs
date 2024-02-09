﻿using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Contracts.Persistence;

namespace RestaurantReservation.Application.Contracts
{
    internal class MenuItemRepository : EntityRepository<MenuItem, MenuItemDTO>, IMenuItemRepository
    {
        public MenuItemRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
