using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.Shared
{
    public class ProductFormVm
    {
        [Required(ErrorMessage = "Enter product name!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Enter description!")]
        public string Description { get; set; }

        [Required]
        [Range(0, 99999.99, ErrorMessage = "The value must belong (0, 99999.99) !")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Error: CategoryID is empty")]
        public int CategoryID { get; set; }

        public List<IFormFile> Images { get; set; }
    }
}
