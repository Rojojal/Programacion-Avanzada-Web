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

        }

        public class ProductRepository : RepositoryBase<Product>, IProductRepository
        {

            public async Task<IEnumerable<Product>> GetAllProductsAsync()
            {
                return await ReadAsync();
            }

        }

}