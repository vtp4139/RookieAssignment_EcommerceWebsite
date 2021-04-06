using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.Interfaces
{
    public interface IRatingClient
    {
        Task<RatingVm> PostRating(RatingFormVm RatingFormVm);
    }
}
