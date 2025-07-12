using System.Collections.Generic;

namespace InventoryManagementSystem.Api.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string Address { get; set; } = null!;
        
        public ICollection<Product>? Products { get; set; }
    }
}
