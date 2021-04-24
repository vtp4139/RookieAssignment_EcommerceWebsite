using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.Backend.Models
{
    public class ImageFile
    {
        [Key]
        public int ImageId { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string ImageLocation { get; set; }

        public DateTime UploadedTime { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
