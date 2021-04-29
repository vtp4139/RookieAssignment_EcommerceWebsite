using System.Collections.Generic;


namespace EcommerceWebsite.Shared
{
    public class CartItemsVm
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public List<string> ImageLocation { get; set; }

    }
}
