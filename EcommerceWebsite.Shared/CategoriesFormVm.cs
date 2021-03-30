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
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
