using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Ecommerce_Shop.Utility;

namespace Ecommerce_Shop.Models
{

    public class Category: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public CategoryStatus Status { get; set; }

    }
}
