using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.Shared
{
    public class CategoriesFormVm
    {
        [Required(ErrorMessage = "Enter category name!")]
        [StringLength(100, ErrorMessage = "Not exceed 100 characters !")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Enter description!")]
        public string Description { get; set; }
    }
}
