using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcommerceWebsite.Backend.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
