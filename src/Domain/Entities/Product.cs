using Solution1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Domain.Entities
{
    public class Product:BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }  
        public decimal? DiscountedPrice { get; set; }
        public Category Category { get; set; } = null!;
        public int CategoryId { get; set; }
        public string Image { get; set; } = null!;
    }
}
