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

        Task<Product> AddProductAsync(Product product);

        Task<Product> DeleteProductAsync(Product product);

        Task<Product> UpdateProductAsync(Product product);

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

        public async Task<Product> AddProductAsync(Product product)
        {

            var result = await _productRepository.AddProductAsync(product);
            if (!result) throw new Exception("Error al intentar guardar el product");

            return await _productRepository.GetProductAsync(product.ProductId);
        }

        public async Task<Product> DeleteProductAsync(Product product)
        {
            var result = await _productRepository.DeleteProductAsync(product);
            if (!result) throw new Exception("Error al intentar guardar el product");

            return await _productRepository.GetProductAsync(product.ProductId);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            var result = await _productRepository.UpdateProductAsync(product);
            if (!result) throw new Exception("No se actualizo correctamente product");

            return await _productRepository.GetProductAsync(product.ProductId);
        }

    }
}
