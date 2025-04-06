using PAP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PAP.Repositories.ProductRepository;

namespace PAP.Repositories
{    
        public interface IProductRepository
        {
            Task<IEnumerable<Product>> GetAllProductsAsync();

            Task<Product> FindAsync(int id);

            Task<bool> AddProductAsync(Product product);

            Task<bool> DeleteProductAsync(Product product);

            Task<bool> UpdateProductAsync(Product product);

            Task<Product> GetProductAsync(int id);

    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await ReadAsync();
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            return await CreateAsync(product);
        }

        public async Task<bool> DeleteProductAsync(Product product)
        {
            return await DeleteAsync(product);
        }

        public async Task<Product> GetProductAsync(int id)
        {
            var product = await ReadAsync();
            return product.SingleOrDefault(x => x.ProductId == id);
        }

        public async Task<bool> UpdateProductAsync(Product product)
            {
                return await UpdateAsync(product);
            }


    }

}