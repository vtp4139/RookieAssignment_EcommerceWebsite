using System.ComponentModel.DataAnnotations;


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
