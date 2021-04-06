using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
