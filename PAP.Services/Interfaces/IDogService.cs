using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAP.Models.Models;

namespace PAP.Services.Interfaces
{
    public interface IDogService
    {
        Task<List<Dog>> GetDogsAsync();
    }
}

