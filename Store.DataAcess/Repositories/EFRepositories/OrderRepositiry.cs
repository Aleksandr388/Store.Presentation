﻿using Store.DataAcess.Entities;
using Store.DataAcess.Repositories.Base;
using Store.DataAcess.Repositories.Interfaces;
using Store.DataAcess.StoreContext;

namespace Store.DataAcess.Repositories.EFRepositories
{
    public class OrderRepositiry : BaseEFRepository<Order>, IOrderRepository
    {
        public OrderRepositiry(ShopDbContext context) : base(context)
        {
        }
    }
}
