using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.Shared
{
    public class OrderFormVm
    {
        [Required]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
    }
}
