using Microsoft.EntityFrameworkCore;
using SKBKonturInternshipProject.Data;
using SKBKonturInternshipProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SKBKonturInternshipProject.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                throw new ProductNotFoundException($"Product with id {id} not found.");
            return product;
        }

        public async Task AddProductAsync(Product product)
        {
            // Исправление: Проверка на null перед добавлением
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            // Исправление: Проверка на null и проверка существования продукта
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            var existingProduct = await _context.Products.FindAsync(product.Id);
            if (existingProduct == null)
                throw new ProductNotFoundException($"Product with id {product.Id} not found.");

            // Рефакторинг: Обновление полей
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            existingProduct.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                throw new ProductNotFoundException($"Product with id {id} not found.");

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}