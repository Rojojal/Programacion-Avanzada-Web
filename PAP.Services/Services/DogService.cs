using PAP.Models.Models;
using PAP.Services.Interfaces;
using PAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Services.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository _repo;

        public DogService(IDogRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Dog>> GetDogsAsync()
        {
            return await _repo.GetAllDogsAsync();
        }
    }
}