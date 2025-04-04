using PAP.Data.Models;
using PAP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Business
{
    public interface IProductManager
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }

    public class ProductManager(IProductRepository productRepository) : IProductManager
    {
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<IEnumerable<Product>> GetAllAsync()
        {

            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.FindAsync(id);
        }

    }
}
