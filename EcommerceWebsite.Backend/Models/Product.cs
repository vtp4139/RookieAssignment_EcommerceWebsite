using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWebsite.Backend.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, 999.99)]
        public decimal Price { get; set; }

        public string Images { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey("Categories")]
        public int CategoryID { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
