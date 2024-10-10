using APIeCommerce.Entities;

namespace APIeCommerce.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
