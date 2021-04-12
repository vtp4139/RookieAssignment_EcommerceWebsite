using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.Interfaces
{
    public interface IOrderClient
    {
        Task<IList<OrderVm>> GetOrders(string idUser);
        Task<IList<CartItemsVm>> GetOrder(int id);
        Task<OrderVm> PostOrders(List<CartItemsVm> ListItem);
    }
}
