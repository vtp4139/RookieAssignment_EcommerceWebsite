using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWebsite.Backend.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CategoryName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(1000)")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
