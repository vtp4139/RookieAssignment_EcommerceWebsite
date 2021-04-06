using EcommerceWebsite.Backend.Data;
using EcommerceWebsite.Backend.Models;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceWebsite.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class RatingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RatingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<RatingVm>>> GetRatings()
        {
            return await _context.Ratings
                .Select(x => new RatingVm
                {
                    RatingId = x.RatingPoint,
                    RatingPoint = x.RatingPoint,
                    UploadedTime = x.UploadedTime,
                })
                .ToListAsync();
        }

        bool CheckIfExist(int idPro, string idUser)
        {
            var x = _context.Ratings.Where(x => x.ProductID == idPro && x.UserId == idUser).FirstOrDefault();
            if (x == null)
                return false;
            return true;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Rating>> PostRating(RatingFormVm RatingFormVm)
        {
            //If the user has rated it, set the update ratingpoint.
            if (CheckIfExist(RatingFormVm.ProductID, RatingFormVm.UserId) == true)
            {
                var x = await _context.Ratings.Where(x => x.ProductID == RatingFormVm.ProductID && x.UserId == RatingFormVm.UserId).FirstOrDefaultAsync();

                if (x == null)
                {
                    return NotFound();
                }

                x.RatingPoint = RatingFormVm.RatingPoint;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            //Set new ratingpoint.
            var nRating = new Rating
            {
                RatingPoint = RatingFormVm.RatingPoint,
                UploadedTime = RatingFormVm.UploadedTime,
                UserId = RatingFormVm.UserId,
                ProductID = RatingFormVm.ProductID
            };

            _context.Ratings.Add(nRating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRatings",
                new { id = nRating.RatingId },
                new RatingVm
                {
                    RatingPoint = nRating.RatingPoint,
                    UploadedTime = nRating.UploadedTime,
                });
        }
    }
}
