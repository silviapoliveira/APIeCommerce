﻿using APIeCommerce.Entities;

namespace APIeCommerce.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);

        Task<IEnumerable<Product>> GetPopularProductsAsync();

        Task<IEnumerable<Product>> GetBestSellerProductsAsync();

        Task<Product> GetProductDetailsAsync(int id);
    }
}
