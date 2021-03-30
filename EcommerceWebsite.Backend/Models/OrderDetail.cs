using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.Backend.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId  { get; set; }
        //[ForeignKey("OrderDetailFK")]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        //[ForeignKey("ProductFK")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
