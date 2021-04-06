using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.Backend.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        public int RatingPoint { get; set; }

        public DateTime UploadedTime { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User Users { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
