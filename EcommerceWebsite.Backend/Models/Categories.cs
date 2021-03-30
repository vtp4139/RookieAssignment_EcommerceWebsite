﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceWebsite.Backend.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}