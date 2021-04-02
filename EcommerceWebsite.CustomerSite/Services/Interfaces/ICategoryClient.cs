using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.Interfaces
{
    public interface ICategoryClient
    {
        Task<IList<CategoriesVm>> GetProducts();
        Task<CategoriesVm> GetProduct(int id);
        Task<CategoriesVm> PostProduct();
        Task<CategoriesVm> PutProduct();
        Task<CategoriesVm> DeleteProduct();
    }
}
