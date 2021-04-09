﻿using Microsoft.EntityFrameworkCore;
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
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public decimal Total()
        {
            return this.UnitPrice * this.Quantity;
        }
    }
}
