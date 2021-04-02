using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.Interfaces
{
    public interface IProductClient
    {
        Task<IList<ProductVm>> GetProducts();
        Task<ProductVm> GetProduct(int id);
    }
}
