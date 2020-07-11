using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IExampleRepository
    {
        Task<Example> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Example>> GetProductsdAsync();
        Task<IReadOnlyList<ExampleItem>> GetProductExampleItemAsync();

    }
}