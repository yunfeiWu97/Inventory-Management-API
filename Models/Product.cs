namespace InventoryManagementApi.Models
{
    /// <summary>
    /// Represents a product in the inventory system.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The product name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The product category (optional).
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// The current quantity in stock.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The unit price (optional).
        /// </summary>
        public decimal? Price { get; set; }
    }
}
