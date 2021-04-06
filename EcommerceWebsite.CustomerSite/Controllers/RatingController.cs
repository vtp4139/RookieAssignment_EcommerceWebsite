using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingClient _ratingApiClient;
        private readonly IConfiguration _configuration;

        public RatingController(IRatingClient ratingApiClient, IConfiguration configuration)
        {
            _ratingApiClient = ratingApiClient;
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult AddRating(int ProductID, int rating)
        {
            if(!User.Identity.IsAuthenticated)
                return RedirectToAction(actionName: "SignIn", controllerName: "Account");

            RatingFormVm x = new RatingFormVm();
            x.RatingPoint = rating;
            x.UploadedTime = DateTime.Now;
            x.ProductID = ProductID;

            //var claimsIdentity = User.Identity as ClaimsIdentity;
            //string userId = claimsIdentity.FindFirst("sub").Value;
            x.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _ratingApiClient.PostRating(x);

            string referer = Request.Headers["Referer"].ToString();
            return Redirect(referer);

        }
    }
}
