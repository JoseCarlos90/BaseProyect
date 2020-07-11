using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IExampleRepository
    {
        private readonly ExampleContext _context;
        public ProductRepository(ExampleContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<ExampleItem>> GetProductExampleItemAsync()
        {
            return await _context.ExampleItems.ToListAsync();
        }

        public async Task<Example> GetProductByIdAsync(int id)
        {
            return await _context.Examples
            .Include(p => p.ExampleItem)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Example>> GetProductsdAsync()
        {
            return await _context.Examples
            .Include(p => p.ExampleItem)
            .ToListAsync();
        }

    }
}