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

        [Column(TypeName = "nvarchar(300)")]
        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<ImageFile> ImageFiles { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        [ForeignKey("Categories")]
        public int CategoryID { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
