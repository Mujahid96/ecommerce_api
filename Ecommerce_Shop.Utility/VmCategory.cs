using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Shop.Utility
{
   public class VmCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public CategoryStatus Status { get; set; }


    }
}
