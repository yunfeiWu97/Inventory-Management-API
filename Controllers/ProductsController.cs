using InventoryManagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementApi.Controllers
{
    /// <summary>
    /// Provides CRUD endpoints for managing products in memory.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Cola", Category = "Beverage", Quantity = 24, Price = 1.99m },
            new Product { Id = 2, Name = "Chips", Category = "Snack", Quantity = 50, Price = 2.49m }
        };

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Products);
        }

        /// <summary>
        /// Retrieves a product by id.
        /// </summary>
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Product? product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { message = "Product not found." });
            }

            return Ok(product);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            int nextId = Products.Count == 0 ? 1 : Products.Max(p => p.Id) + 1;

            newProduct.Id = nextId;
            Products.Add(newProduct);

            return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
        }

        /// <summary>
        /// Updates an existing product by id.
        /// </summary>
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            Product? existingProduct = Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound(new { message = "Product not found." });
            }

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Category = updatedProduct.Category;
            existingProduct.Quantity = updatedProduct.Quantity;
            existingProduct.Price = updatedProduct.Price;

            return Ok(existingProduct);
        }

        /// <summary>
        /// Deletes a product by id.
        /// </summary>
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            Product? existingProduct = Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound(new { message = "Product not found." });
            }

            Products.Remove(existingProduct);
            return NoContent();
        }
    }
}
