using PAP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Repositories.Interfaces
{
    public interface IDogRepository
    {
        Task<List<Dog>> GetAllDogsAsync();
    }
}