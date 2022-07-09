using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miniproject.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string ManufactureDate { get; set; }
        public string ExpirationDate { get; set; }
    }
}
