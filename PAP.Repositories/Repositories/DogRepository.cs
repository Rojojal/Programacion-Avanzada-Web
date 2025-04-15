using PAP.Data;
using PAP.Models.Models;
using PAP.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Repositories.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly PAPDbContext _context;

        public DogRepository(PAPDbContext context)
        {
            _context = context;
        }

        public async Task<List<Dog>> GetAllDogsAsync()
        {
            return await _context.Dog
                .Include(d => d.Breed)
                .ThenInclude(b => b.Species)
                .ToListAsync();
        }
    }
}