public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public int SupplierID { get; set; }
    public int LowStockThreshold { get; set; }
}
