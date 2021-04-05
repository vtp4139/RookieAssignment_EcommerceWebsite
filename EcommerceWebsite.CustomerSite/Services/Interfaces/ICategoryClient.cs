using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.Interfaces
{
    public interface ICategoryClient
    {
        Task<IList<CategoriesVm>> GetCategories();
        Task<CategoriesVm> GetCategory(int id);
    }
}
