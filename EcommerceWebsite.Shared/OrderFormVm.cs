using System;
using System.ComponentModel.DataAnnotations;


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
