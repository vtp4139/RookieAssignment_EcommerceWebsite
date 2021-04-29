using System;

namespace EcommerceWebsite.Shared
{
    public class RatingFormVm
    {
        public int RatingPoint { get; set; }

        public DateTime UploadedTime { get; set; }

        public string UserId { get; set; }

        public int ProductID { get; set; }
    }
}
